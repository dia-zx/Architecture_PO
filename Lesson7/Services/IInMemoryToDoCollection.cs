using Lesson7.Models;

namespace Lesson7.Services
{
    public interface IInMemoryToDoCollection
    {
        public IEnumerable<ToDoItem> GetAll();
    }
}
