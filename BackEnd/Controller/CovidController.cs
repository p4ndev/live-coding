using Microsoft.AspNetCore.Mvc;
using BackEnd.Interface.Domain;
using System.Net.Mime;
using BackEnd.Entity;

namespace BackEnd.Controller;

[ApiController]
[Route("[controller]")]
[Consumes(MediaTypeNames.Application.Json)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class CovidController : ControllerBase {

    private IQuarentine _quarentine;

    public CovidController(IQuarentine quarentine) => _quarentine = quarentine;

    [HttpPut]    
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PutAsync([FromBody] QuarentineDTO model) {
        try {
            
            _quarentine.SetEmail(model.EmployeeEmail);

            _quarentine.SetEmailNotifications(model.Emails);

            if (!_quarentine.IsValid()) return BadRequest();

            return StatusCode(await _quarentine.SaveAsync() ? 201 : 403);

        } catch (Exception ex) {

            return StatusCode(500, ex.Message);

        }
    }

}
