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
    public class SkillsController : ControllerBase
    {
        private readonly List<Skill> skills = new SkillSampleData().Skills;

        // GET: api/<SkillsController>
        [HttpGet]
        public IEnumerable<Skill> Get()
        {
            return skills;
        }

        // GET api/<SkillsController>/5
        [HttpGet("{id}")]
        public Skill Get(string id)
        {
            return skills.FirstOrDefault(f => f.StandarizedName.Equals(id, StringComparison.InvariantCultureIgnoreCase));
        }

        // POST api/<SkillsController>
        [HttpPost]
        public void Post([FromBody] Skill value)
        {
            skills.Add(value);
        }

        // PUT api/<SkillsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Skill value)
        {
            var currentSkill = skills.FirstOrDefault(f => f.StandarizedName.Equals(id, StringComparison.InvariantCultureIgnoreCase));

            if (currentSkill != null)
            {
                skills.Remove(currentSkill);
            }
            skills.Add(value);
        }

        // DELETE api/<SkillsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var skill = skills.FirstOrDefault(f => f.StandarizedName.Equals(id, StringComparison.InvariantCultureIgnoreCase));

            if (skill != null)
            {
                skills.Remove(skill);
            }
        }
    }
}
