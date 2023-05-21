using EnergoStatApi.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EnergoStat.Api.Controllers
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            return Ok();
            //var response = 
        } 
    }
}
