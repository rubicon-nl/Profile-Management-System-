using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProfileService.Api.Dummy;
using ProfileService.Api.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfileService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {

        private readonly List<Profile> profiles = new ProfileSampleData().Profiles;

        // GET: api/<Profile>
        [HttpGet]
        public IEnumerable<Profile> Get()
        {
            return profiles;
        }

        // GET api/<Profile>/5
        [HttpGet("{id}")]
        public Profile Get(Guid id)
        {
            return profiles.FirstOrDefault(f => f.Id == id);
        }

        // POST api/<Profile>
        [HttpPost]
        public void Post([FromBody] Profile value)
        {
            profiles.Add(value);
        }

        // PUT api/<Profile>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Profile value)
        {
            var profile = profiles.Where(f => f.Id == id).FirstOrDefault();
            if (profile != null)
            {
                profiles.Remove(profile);
                profiles.Add(value);
            }
        }

        // DELETE api/<Profile>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var profile = profiles.Where(f => f.Id == id).FirstOrDefault();
            if (profile != null)
            {
                profiles.Remove(profile);                
            }
        }
    }
}
