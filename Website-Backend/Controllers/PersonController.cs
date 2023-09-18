using Microsoft.AspNetCore.Mvc;

namespace Website_Backend.Controllers;

[ApiController]
[Route("api/")]
public class PersonController : ControllerBase
{
    private readonly ILogger<Person> _logger;
    private static List<Person> people = new List<Person>
    {
        new Person(),
        new Person(1, "Abel", "Marte", "01-01-2000"),
        new Person(2, "Tony", "Montana", "01-01-2000"),
    };

    public PersonController(ILogger<Person> logger)
    {
        _logger = logger;
    }

    // Get a default person created in the model
    [HttpGet("GetPerson")]
    public ActionResult<Person> Get()
    {
        return Ok(people[0]);
    }

    // Get a person by an id
    [HttpGet("{id}")]
    public ActionResult<Person> GetPersonById(int Id)
    {
        return Ok(people.FirstOrDefault(p => p.Id == Id));
    }

    // Get a list of people created in the people object
    [HttpGet("GetPeople")]
    public ActionResult<List<Person>> GetPeople()
    {
        return Ok(people);
    }
}

