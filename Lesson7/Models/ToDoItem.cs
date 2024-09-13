namespace Lesson7.Models;

public class ToDoItem
{
    private static int _nextID = 0;
    private int _id;
    public ToDoItem(string name, string description, int priority, DateTime deadline, bool isdone)
    {
        _id= _nextID++;
        Name = name;
        Description = description;
        Priority = priority;
        DeadLine = deadline;
        IsDone = isdone;
    }
    public int ID { get=>_id; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; }
}

