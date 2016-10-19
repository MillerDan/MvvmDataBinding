using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IFakeService
    {
        Task<List<Person>> GetPeopleAsync();
        Task<Person> AddPersonAsync(Person person);
        Task<Person> DeletePersonAsync(Person person);
        Task<Person> UpdatePersonAsync(Person person);
    }
}
