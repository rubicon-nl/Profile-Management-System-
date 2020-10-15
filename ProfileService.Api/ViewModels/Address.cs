using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Api.ViewModels
{
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string HouseNumberAddition { get; set; }
        public int HouseNumber { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }
    }
}
