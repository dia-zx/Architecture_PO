using Lesson10.Models;
using Lesson10.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoInMemoryController : ControllerBase
    {
        private readonly ILogger<ToDoInMemoryController> _logger;
        private IInMemoryToDoCollection _toDoCollection;

        public ToDoInMemoryController(IInMemoryToDoCollection ToDoCollection, ILogger<ToDoInMemoryController> logger)
        {
            _toDoCollection = ToDoCollection;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() =>  Ok(_toDoCollection.GetAll());

        [HttpPost]
        public IActionResult Add([FromQuery] string name, [FromQuery] int priority, [FromQuery] DateTime deadLine, [FromQuery] bool isDone)
        {
            ToDoItem item = new(name, "", priority, deadLine, isDone);
            _toDoCollection.Add(item);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery]int id)=>  Ok(_toDoCollection.Remove(id));
        
    }
}
