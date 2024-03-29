﻿namespace Website_Backend.Services
{
    public class PersonService : IPersonService
	{

        private static List<Person> people = new List<Person>
        {
            new(),
            new() {Id = 1, First = "Abel", Last = "Marte", Dob = "01-01-2000" },
            new() {Id = 2, First = "Tony", Last = "Montana", Dob = "01-01-2000"},
        };

        public async Task<ServiceResponse<List<Person>>> CreatePerson(Person newPerson)
        {
            var serviceResponse = new ServiceResponse<List<Person>>();

            people.Add(newPerson);
            serviceResponse.Data = people;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Person>> GetPerson()
        {
            var serviceResponse = new ServiceResponse<Person>();

            serviceResponse.Data = people[0];

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Person>>> GetPeople()
        {
            var serviceResponse = new ServiceResponse<List<Person>>();
            serviceResponse.Data = people;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Person>> GetPersonById(int Id)
        {
            var person = people.FirstOrDefault(p => p.Id == Id);


            var serviceResponse = new ServiceResponse<Person>();
            serviceResponse.Data = person;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Person>> UpdatePerson(Person personToBeUpdated)
        {
            var ServiceResponse = new ServiceResponse<Person>();
            var person = people.FirstOrDefault(p => p.Id == personToBeUpdated.Id) ?? throw new Exception($"person with {personToBeUpdated.Id} was not found");

            person.First = personToBeUpdated.First;
            person.Last = personToBeUpdated.Last;

            return ServiceResponse;
        }

        public async Task<ServiceResponse<Person>> DeletePerson(int Id)
        {
            var ServiceResponse = new ServiceResponse<Person>();
            var person = people.First(p => p.Id == Id) ?? throw new Exception($"person with {Id} was not found");

            people.Remove(person);
            ServiceResponse.Data = person;

            return ServiceResponse;
        }
    }
}

