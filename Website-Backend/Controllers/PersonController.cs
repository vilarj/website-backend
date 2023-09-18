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

    [HttpGet("GetPerson")]
    public ActionResult<Person> Get()
    {
        return Ok(people[0]);
    }

    [HttpGet("GetPersonById")]
    public ActionResult<Person> GetPersonById(int Id)
    {
        return Ok(people.FirstOrDefault(p => p.Id == Id));
    }

    [HttpGet("GetPeople")]
    public ActionResult<List<Person>> GetPeople()
    {
        return Ok(people);
    }
}

