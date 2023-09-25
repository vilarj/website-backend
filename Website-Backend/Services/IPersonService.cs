using System;
namespace Website_Backend.Services
{
	public interface IPersonService
	{
		public Person GetPerson();

		public Person GetPersonById(int Id);

		public List<Person> GetPeople();

		public List<Person> CreatePerson(Person newPerson);
    }
}

