using ProfileService.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Api.Dummy
{
    public class ProfileBuilder
    {
        private  Profile profile { get; set; }

        private ProfileBuilder()
        {

        }

        public static ProfileBuilder Create(GenderType gender, string givenName, string lastName, DateTime birthDate)
        {
            var bld = new ProfileBuilder
            {
                profile = new Profile { BirthDate = birthDate, GivenName = givenName, LastName = lastName, Gender = gender, PhoneNumbers = new List<Phone>() }
            };
            return bld;
        }

        public ProfileBuilder AddPhone(PhoneType type, string number)
        {
            profile.PhoneNumbers.Add(new Phone { Type = type, Number = number });
            return this;
        }

        public ProfileBuilder WithId(Guid id)
        {
            profile.Id = id;
            return this;
        }

        public ProfileBuilder AddAddress(string street, int houseNumber, string zipCode, string city, string state, string country)
        {
            profile.LivingAddress = new Address
            {
                City = city,
                HouseNumber = houseNumber,
                State = state,
                Street = street,
                ZipCode = zipCode,
                Country = country
            };
            return this;
        }

        public ProfileBuilder AddAddress(string street, int houseNumber, string housenumberAddition, string zipCode, string city, string state, string country)
        {
            profile.LivingAddress = new Address
            {
                City = city,
                HouseNumber = houseNumber,
                State = state,
                Street = street,
                ZipCode = zipCode,
                HouseNumberAddition = housenumberAddition,
                Country = country
            };
            return this;
        }

        public Profile Build()
        {
            if (profile.Id == Guid.Empty)
            {
                profile.Id = Guid.NewGuid();
            }
            return profile;
        }

        public static implicit operator Profile(ProfileBuilder builder)
        {
            return builder.Build();
        }
    }
}
