using Lesson11.Models;

namespace Lesson11.Services;

public interface IInMemoryToDoCollection
{
    public IEnumerable<ToDoItem> GetAll();
    public void Add(ToDoItem toDoItem);
    public bool Remove(int id);
}

