using Microsoft.AspNetCore.Mvc;

namespace Website_Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService PersonService)
    {
        _personService = PersonService;
    }

    // Get a default person created in the model
    [HttpGet("GetPerson")]
    public ActionResult<Person> Get()
    {
        return Ok(_personService.GetPerson());
    }

    // Get a person by an id
    [HttpGet("{Id}")]
    public ActionResult<Person> GetPersonById(int Id)
    {
        return Ok(_personService.GetPersonById(Id));
    }

    // Get a list of people created in the people object
    [HttpGet("GetPeople")]
    public ActionResult<List<Person>> GetPeople()
    {
        return Ok(_personService.GetPeople());
    }

    [HttpPost]
    public ActionResult <List<Person>> CreatePerson(Person newPerson)
    {
        
        return Ok(_personService.CreatePerson(newPerson));
    }
}

