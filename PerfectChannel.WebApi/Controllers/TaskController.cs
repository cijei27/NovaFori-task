using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PerfectChannel.WebApi.Data;
using PerfectChannel.WebApi.Models;

namespace PerfectChannel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ApplicationContext _db;

        public TaskController(ApplicationContext db)
        {
            _db = db;
        }

        // Action Methods

        [HttpGet]
        public IActionResult GetTask()
        {
            return Ok(_db.TodoTask);
        }

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] ApplicationTask objTask)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error While Creating New task");
            }
            _db.TodoTask.Add(objTask);
            await _db.SaveChangesAsync();

            return new JsonResult("Task Created Successfully");

        }
    }
}