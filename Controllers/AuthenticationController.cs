using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ZeissEmpMgmt.Filter;
using ZeissEmpMgmt.Services;

namespace ZeissEmpMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [LogActionFilter]
    public class JwtTokenController : ControllerBase
    {
        private IConfiguration _config;

        public JwtTokenController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpGet]
        public string GetJwtToken()
        {
            var jwt = new JwtTokenService(_config);
            var token = jwt.GenerateSecurityToken();
            return token;
        }
    }
}
