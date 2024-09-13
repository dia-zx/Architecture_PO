using Lesson7.Models;

namespace Lesson7.Services;

public class InMemoryToDoCollection
{
    private List<ToDoItem> _toDoItems;

    public InMemoryToDoCollection()
    {
        _toDoItems = Enumerable.Range(0, 10)
            .Select(i => new ToDoItem($"Дело {i}", $"...", i + 5, DateTime.Now.AddDays(i), false)).ToList();
    }
}

