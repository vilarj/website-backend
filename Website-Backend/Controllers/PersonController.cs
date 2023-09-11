using Microsoft.AspNetCore.Mvc;

namespace Website_Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<Person> _logger;

    public PersonController(ILogger<Person> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPerson")]
    public IEnumerable<Person> Get()
    {
        return Enumerable.Range(1, 4).Select(index => new Person
        {
            id = 3,
            first = "Abel",
            last = "Marte",
            dob = "1998-03-05"
        })
        .ToArray();
    }
}

