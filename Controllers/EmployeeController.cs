using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ZeissEmpMgmt.Filter;
using ZeissEmpMgmt.Model;
using ZeissEmpMgmt.Services;

namespace ZeissEmpMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [LogActionFilter]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        private ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get(string? name)
        {
            return Ok(_employeeService.GetEmployees(name));
        }

        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _employeeService.Save(employee);
            return Ok();
        }
    }
}
