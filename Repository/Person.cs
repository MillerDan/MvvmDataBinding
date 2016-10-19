using System;
using System.ComponentModel.DataAnnotations;

namespace Repository
{
    public class Person
    {
        public Person() { }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
    }
}
