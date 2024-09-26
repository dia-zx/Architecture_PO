using Lesson10.Servises.Repositories.PersonsRepository;
using Lesson10.Servises.Repositories.PersonsRepository.Model;
using Lesson10.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10.Controllers
{
    [Route("Persons/[controller]")]
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpDelete]
        public IActionResult Get([FromQuery] int id)
        {
            return Ok(_repository.Delete(id));
        }

        [HttpPut]
        public IActionResult Add([FromBody] Person person)
        {
            return Ok(_repository.Add(person));
        }

        [HttpPatch]
        public IActionResult Update([FromBody] Person person)
        {
            return Ok(_repository.Update(person));
        }
    }
}
