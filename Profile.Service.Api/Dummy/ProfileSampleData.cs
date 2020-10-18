using ProfileService.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Api.Dummy
{
    public class ProfileSampleData
    {

        public List<Profile> Profiles { get; set; }

        public ProfileSampleData()
        {
            var linkGuid = Guid.Parse("EBF48525-1DF8-4C8C-BC46-74AC6B2B44ED");
            Profiles = new List<Profile>
            {
                ProfileBuilder
                    .Create(GenderType.Male, "Peter", "Telkamp", new DateTime(1960, 4, 1))
                    .WithId(linkGuid)
                    .AddPhone(PhoneType.HomePhone, "044588548")
                    .AddAddress("Dorpsstraat", 12, "1234AA", "Utrecht", "Utrecht", "Netherlands"),
                ProfileBuilder
                    .Create(GenderType.Female, "Els", "van Meeuwen", new DateTime(1960, 4, 1))
                    .AddPhone(PhoneType.HomePhone, "047583548")
                    .AddAddress("Dorpsstraat", 12, "3234ZQ", "Zeist", "Utrecht", "Netherlands"),
                ProfileBuilder
                    .Create(GenderType.Female, "Petra", "ter Meulen", new DateTime(1960, 4, 1))
                    .AddPhone(PhoneType.HomePhone, "045588441")
                    .AddAddress("Dorpsstraat", 12, "1234DB", "Haarlem", "Noord Holland", "Netherlands")
            };
        }
    }
}
