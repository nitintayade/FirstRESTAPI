using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameBuilderController : ControllerBase
    {
        private readonly ILogger<NameBuilderController> logger;
        public NameBuilderController(ILogger<NameBuilderController> logger)
        {
            this.logger = logger;
        }

        [HttpGet(Name = "GetFullName")]
        public string Get()
        {
            return "Nitin" + "Tayade";
        }

        [HttpPost(Name = "BuildName")]
        public string Post(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
