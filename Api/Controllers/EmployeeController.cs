using System.Linq;
using System.Threading.Tasks;
using Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Text.Json;
using Model.DB;
using Model.API;
using Interface.API;
using Newtonsoft.Json.Linq;

namespace Api.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IDal<Employee> _dal;
        public EmployeeController(IDal<Employee> dal)
        {
            _dal = dal;
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(ApiRequest<JsonElement> dtReq)
        {
            var employees = await _dal.GetAllAsync(dtReq);
            return Json(employees);
        }
    }
}
