namespace backend.controllers;

[ApiController]
[Route("api/contacts")]
public class ContactController : ControllerBase{

    private readonly IContactRepository _repository;

    public ContactController(IContactRepository repository) => this._repository = repository;

    [HttpGet("all")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Contact>))]
    public ActionResult<IEnumerable<Contact>> All(){
        var res = this._repository.All();
        return res.Count() > 0 ? Ok(res) : NotFound();
    }

    [HttpGet("find")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Contact>))]
    public ActionResult<IEnumerable<Contact>> Find([FromQuery] string fullname){
        if(fullname.Length < 3) return BadRequest();
        var res = this._repository.FindBy(fullname);
        return res.Count() > 0 ? Ok(res) : NotFound();
    }

}