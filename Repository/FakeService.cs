using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Repository
{
    public class FakeService : IFakeService
    {
        public static string Name = "Fake Data Service";
        private OrganizationContext context = new OrganizationContext();
        public Task<List<Person>> GetPeopleAsync()
        {
            return context.People.ToListAsync();
        }

        public async Task<Person> AddPersonAsync(Person person)
        {
            Debug.WriteLine("Add person async with name " + string.Format("{0} {1}", person.FirstName, person.LastName));

            context.People.Add(person);
            await context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> DeletePersonAsync(Person person)
        {
            Debug.WriteLine("Delete person with name " + string.Format("{0} {1}", person.FirstName, person.LastName));

            context.People.Remove(person);
            await context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            Debug.WriteLine("Update person with name " + string.Format("{0} {1}", person.FirstName, person.LastName));

            context.People.Update(person);
            await context.SaveChangesAsync();
            return person;
        }
    }
}
