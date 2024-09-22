using Lesson9.Models;

namespace Lesson9.Services;

public class InMemoryToDoCollection : IInMemoryToDoCollection
{
    private List<ToDoItem> _toDoItems;

    public InMemoryToDoCollection()
    {
        _toDoItems = Enumerable.Range(0, 3)
            .Select(i => new ToDoItem($"Дело {i}", $"...", i + 5, DateTime.Now.AddDays(i), false)).ToList();
    }

    public void Add(ToDoItem toDoItem) => _toDoItems.Add(toDoItem);

    public IEnumerable<ToDoItem> GetAll() => _toDoItems;

    public bool Remove(int id) =>  _toDoItems.Remove(_toDoItems.Find(item => item.ID == id));
}

