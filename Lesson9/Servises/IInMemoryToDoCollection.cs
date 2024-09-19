using Lesson9.Models;

namespace Lesson9.Services;

public interface IInMemoryToDoCollection
{
    public IEnumerable<ToDoItem> GetAll();
    public void Add(ToDoItem toDoItem);
    public bool Remove(int id);
}

