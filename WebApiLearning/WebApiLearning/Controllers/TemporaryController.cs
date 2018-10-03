using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiLearning.Models.Temporary;

namespace WebApiLearning.Controllers
{
    public class TemporaryController : ApiController
    {
        public List<Person> persons = FillTemplateData();

        public static List<Person> FillTemplateData()
        {
            List<Person> persons = new List<Person>()
                                            {
                                                new Person()
                                                {
                                                    Name = "John",
                                                    SecondName = "Michael",
                                                    BirthDate = new DateTime(1992, 9, 1),
                                                    Address = new Address()
                                                    {
                                                        StreetName = "Johnowska",
                                                        StreetNumber = "1a",
                                                        PostalCode = "00-123",
                                                        City = "Michaelów"
                                                    },
                                                    Hobbies = new List<Hobbies>()
                                                    {
                                                        new Hobbies()
                                                        {
                                                            HobbyName = "Szachy"
                                                        },
                                                        new Hobbies()
                                                        {
                                                            HobbyName = "Rybki"
                                                        }
                                                    }
                                                },
                                                new Person()
                                                {
                                                    Name = "Jack",
                                                    SecondName = "Daniels",
                                                    BirthDate = new DateTime(1990, 9, 1),
                                                    Address = new Address()
                                                    {
                                                        StreetName = "Whiskey",
                                                        StreetNumber = "69",
                                                        PostalCode = "69-666",
                                                        City = "On Ice"
                                                    },
                                                    Hobbies = new List<Hobbies>()
                                                    {
                                                        new Hobbies()
                                                        {
                                                            HobbyName = "Imprezy"
                                                        },
                                                        new Hobbies()
                                                        {
                                                            HobbyName = "Alkohol"
                                                        }
                                                    }
                                                }
                                             };
            return persons;
        }
        // GET api/values
        public List<Person> Get()
        {
            return persons;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            if(id < persons.Count()-1)
            {
                return persons.ElementAt(id);
            }
            else
            {
                return persons.FirstOrDefault();
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
