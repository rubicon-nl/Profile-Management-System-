using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Profile.Service.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> GetProfiles()
        {
            var client = new HttpClient();
            string url = "http://profile.service.api/api/Profile";
            var result = await client.GetAsync(url);
            
            return Ok(await result.Content.ReadFromJsonAsync<IEnumerable<Profile>>());
        }
    }
}
