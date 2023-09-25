using System;
namespace Website_Backend.Services
{
	public interface IPersonService
	{
		public Task<ServiceResponse<Person>> GetPerson();

		public Task<ServiceResponse<Person>> GetPersonById(int Id);

		public Task<ServiceResponse<List<Person>>> GetPeople();

		public Task<ServiceResponse<List<Person>>> CreatePerson(Person newPerson);
    }
}

