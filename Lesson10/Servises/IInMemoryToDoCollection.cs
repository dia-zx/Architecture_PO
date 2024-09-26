using Lesson10.Models;

namespace Lesson10.Services;

public interface IInMemoryToDoCollection
{
    public IEnumerable<ToDoItem> GetAll();
    public void Add(ToDoItem toDoItem);
    public bool Remove(int id);
}

