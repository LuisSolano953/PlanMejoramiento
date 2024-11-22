using Microsoft.AspNetCore.Mvc;
using PlanMejoramiento.Functions;
using PlanMejoramiento.Models;
using PlanMejoramiento.Services;

namespace PlanMejoramiento.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class EmployeeController : Controller
    {

        public readonly EmployeeService _Services;
        public IConfiguration _configuration { get; set; }
        public GeneralFunctions        FunctionsGeneral;
        public EmployeeController(IConfiguration configuration, EmployeeService employeeService)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _configuration = configuration;
            _Services = employeeService;
        }

        [HttpPost("Create Employee")]
        public IActionResult Create(EmployeeModel entity)
        {
            try
            {
                _Services.Add(entity);

                return Ok(new {nessage="creado con exito"});
            }
            catch (Exception ex)
            {
                FunctionsGeneral.AddLog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("lista Employee")]
        public ActionResult<IEnumerable<EmployeeModel>> GetEmployee()
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.AddLog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }
    }
}
