using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static List<string> tasks = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult Create(string task)
        {
            tasks.Add(task);
            return Ok(task);
        }
    }
}