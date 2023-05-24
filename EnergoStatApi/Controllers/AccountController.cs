namespace EnergoStat.Api.Controllers
{
    using EnergoStatApi.Domain.Entity;
    using EnergoStatApi.Domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Register")]
        public IActionResult Register(RegistrationModel model)
        {
            _accountService.Register(model);
            return Ok(model);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginModel model)
        {
            _accountService.Login(model);
            return Ok(model);
        }
    }
}
