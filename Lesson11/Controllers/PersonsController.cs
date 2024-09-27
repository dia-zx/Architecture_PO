using Lesson11.Servises.Repositories.PersonsRepository;
using Lesson11.Servises.Repositories.PersonsRepository.Model;
using Lesson11.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson11.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly ILogger<PersonsController> _logger;
        private readonly IPersonsRepository _repository;

        public PersonsController(ILogger<PersonsController> logger, IPersonsRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Person>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost("GetById")]
        public ActionResult<Person> GetById([FromQuery] int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpDelete("DeleteById")]
        public ActionResult<int> Delete([FromQuery] int id)
        {
            return Ok(_repository.Delete(id));
        }

        [HttpPut("Add")]
        public ActionResult<int> Add([FromBody] Person person)
        {
            return Ok(_repository.Add(person));
        }

        [HttpPost("Update")]
        public ActionResult<int> Update([FromBody] Person person)
        {
            return Ok(_repository.Update(person));
        }
    }
}
