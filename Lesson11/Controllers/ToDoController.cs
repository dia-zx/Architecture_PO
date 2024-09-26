using Lesson11.Servises.Repositories.ToDoReRepository;
using Lesson11.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson11.Controllers
{
    [Route("[controller]")]
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

        [HttpGet("GetAll")]
        public ActionResult<List<ToDo>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost("GetById")]
        public ActionResult<ToDo> GetById([FromQuery] int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpDelete("Delete")]
        public ActionResult<int> Get([FromQuery] int id)
        {               
            return Ok(_repository.Delete(id));
        }

        [HttpPut("Add")]
        public ActionResult<int> Add([FromBody]ToDo todo)
        {
            return Ok(_repository.Add(todo));
        }

        [HttpPatch ("Update")]
        public ActionResult<int> Update([FromBody] ToDo todo)
        {
            return Ok(_repository.Update(todo));
        }
    }
}
