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
public class EmployeeController : ControllerBase {

    private IEmployee _employee;

    public EmployeeController(IEmployee employee) => _employee = employee;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetAsync(){
        try {

            var results = await _employee.RetrieveAsync();

            if (results == null) return BadRequest();

            return results.Count() > 0 ? Ok(results) : NotFound();

        } catch (Exception ex) {

            return StatusCode(500, ex.Message);

        }
    }

}
