using Lesson9.Models;
using Lesson9.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Lesson9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private IInMemoryToDoCollection _toDoCollection;

        public ToDoController(IInMemoryToDoCollection ToDoCollection, ILogger<ToDoController> logger)
        {
            _toDoCollection = ToDoCollection;
            _logger = logger;
        }

        [HttpGet(Name = "GetToDoList")]
        public IActionResult Get() =>  Ok(_toDoCollection.GetAll());

        [HttpPost(Name ="AddItem")]
        public IActionResult Add([FromQuery] string name, [FromQuery] int priority, [FromQuery] DateTime deadLine, [FromQuery] bool isDone)
        {
            ToDoItem item = new(name, "", priority, deadLine, isDone);
            _toDoCollection.Add(item);
            return Ok();
        }

        [HttpDelete(Name = "Delete")]
        public IActionResult Delete([FromQuery]int id)=>  Ok(_toDoCollection.Remove(id));
        
    }
}
