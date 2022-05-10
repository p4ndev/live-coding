using Microsoft.AspNetCore.Mvc;
using BackEnd.Interface.Domain;
using System.Net.Mime;
using BackEnd.Entity;

namespace BackEnd.Controller;

[ApiController]
[Route("[controller]")]
[Consumes(MediaTypeNames.Application.Json)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class ActivityController : ControllerBase {

    private IActivity _activity;

    public ActivityController(IActivity activity) => _activity = activity;

    [HttpGet]    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<EmployeeActivityDTO>>> GetAsync([FromQuery] string email){
        try {

            _activity.SetEmail(email);

            if (!_activity.IsValid()) return BadRequest();

            var results = await _activity.RetrieveAsync();

            if (results == null) return StatusCode(405);

            return results.Count() > 0 ? Ok(results) : NotFound();

        } catch (Exception ex) {

            return StatusCode(500, ex.Message);

        }
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> PutAsync([FromBody] string email) {
        try {

            _activity.SetEmail(email);

            _activity.SetEntrance();

            if (!_activity.IsValid()) return BadRequest();

            var result = await _activity.SaveAsync();

            return StatusCode(result ? 201 : 405);

        } catch (Exception ex) {

            return StatusCode(500, ex.Message);

        }
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> DeleteAsync([FromBody] string email) {
        try {

            _activity.SetEmail(email);

            _activity.SetExit();

            if (!_activity.IsValid()) return BadRequest();

            var result = await _activity.SaveAsync();

            return StatusCode(result ? 201 : 405);

        } catch (Exception ex) {

            return StatusCode(500, ex.Message);

        }
    }

}
