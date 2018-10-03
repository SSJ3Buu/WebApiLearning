using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiLearning.Models.Temporary
{
    public class Address
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}