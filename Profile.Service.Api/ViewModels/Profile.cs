using System;
using System.Collections.Generic;

namespace ProfileService.Api.ViewModels
{
    public class Profile
    {
        public Guid Id { get; set; }

        public GenderType Gender { get; set; }
        public string GivenName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public Address LivingAddress { get; set; }           

        public List<Phone> PhoneNumbers { get; set; }
        
    }
}
