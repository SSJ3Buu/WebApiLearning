using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiLearning.Models.Temporary
{
    public class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public List<Hobbies> Hobbies { get; set; } = new List<Hobbies>();
    }
}