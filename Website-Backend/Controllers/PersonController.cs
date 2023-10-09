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
    public async Task<ActionResult<ServiceResponse<Person>>> Get()
    {
        return Ok(await _personService.GetPerson());
    }

    // Get a person by an id
    [HttpGet("{Id}")]
    public async Task<ActionResult<ServiceResponse<Person>>> GetPersonById(int Id)
    {
        return Ok(await _personService.GetPersonById(Id));
    }

    // Get a list of people created in the people object
    [HttpGet("GetPeople")]
    public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPeople()
    {
        return Ok(await _personService.GetPeople());
    }

    // Add a new person
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<Person>>>> CreatePerson(Person newPerson)
    {
        return Ok(await _personService.CreatePerson(newPerson));
    }

    // Update first and last of a person
    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Person>>> UpdatePerson(Person personToBeUpdated)
    {
        return Ok(await _personService.UpdatePerson(personToBeUpdated));
    }
}

