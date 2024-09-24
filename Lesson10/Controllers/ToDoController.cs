using Lesson10.Servises.Repositories.ToDoReRepository;
using Lesson10.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10.Controllers
{
    [Route("ToDo/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IToDoRepository _repository;

        public ToDoController(ILogger<ToDoController> logger, IToDoRepository toDoReRepository)
        {
            _logger = logger;
            _repository = toDoReRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost(Name = "GetById")]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpDelete(Name ="Delete")]
        public IActionResult Get([FromQuery] int id)
        {               
            return Ok(_repository.Delete(id));
        }

        [HttpPut(Name = "Add")]
        public IActionResult Add([FromBody]ToDo todo)
        {
            return Ok(_repository.Add(todo));
        }

        [HttpPatch (Name = "Update")]
        public IActionResult Update([FromBody] ToDo todo)
        {
            return Ok(_repository.Update(todo));
        }
    }
}
