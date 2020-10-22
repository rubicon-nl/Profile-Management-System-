using System;

namespace Profile.Service.Gateway
{
    public class Profile
    {
        public Guid Id { get; set; }

        public string GivenName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
    }
}
