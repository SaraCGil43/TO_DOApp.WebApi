using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ToDo_SolutionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet]
        public async Task<IActionResult> GetHelloWorld()
        {
            return Ok("¡Hello World!");
        }
    }
}
