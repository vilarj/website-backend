using System;

namespace Website_Backend.Services
{
	public class PersonService : IPersonService
	{
        private static List<Person> people = new List<Person>
        {
        new Person(),
        new Person {Id = 1, First = "Abel", Last = "Marte", Dob = "01-01-2000" },
        new Person{Id = 2, First = "Tony", Last = "Montana", Dob = "01-01-2000"},
        };

        public List<Person> CreatePerson(Person newPerson)
        {
            people.Add(newPerson);
            return people;
        }

        public Person GetPerson()
        {
            return people[0];
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public Person GetPersonById(int Id)
        {
            var person = people.FirstOrDefault(p => p.Id == Id);

            if (person != null)
            {
                return person;
            }

            throw new Exception("Person not found");
        }
    }
}

