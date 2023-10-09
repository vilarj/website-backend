namespace Website_Backend.Services
{
    public interface IPersonService
	{
		// GET a person
		public Task<ServiceResponse<Person>> GetPerson();

		// GET a person given an Id
		public Task<ServiceResponse<Person>> GetPersonById(int Id);

		// GET people 
		public Task<ServiceResponse<List<Person>>> GetPeople();

		// POST create a person
		public Task<ServiceResponse<List<Person>>> CreatePerson(Person newPerson);

		// PUT a person's first and last name
		public Task<ServiceResponse<Person>> UpdatePerson(Person personToBeUpdated);
    }
}

