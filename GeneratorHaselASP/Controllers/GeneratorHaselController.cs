using GeneratorHaselASP.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeneratorHaselASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratorHaselController : ControllerBase
    {
        private readonly IGeneratorService _generatorServicel;
        public GeneratorHaselController(IGeneratorService generatorServicel)
        {
            _generatorServicel = generatorServicel;
        }
        [HttpGet]
        public ActionResult<string> GetPassword(int longPass, bool all) 
        {
            if(longPass == 0)
            {
                return StatusCode(400, "please provide the password length");
            }         
            return StatusCode(200, _generatorServicel.GeneratePassword(longPass, all));
        }
    }
}
