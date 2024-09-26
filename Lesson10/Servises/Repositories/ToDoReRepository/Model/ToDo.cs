namespace Lesson10.Servises.Repositories.ToDoReRepository.Model;
public class ToDo
{
    public int ToDoId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int PersonID {  get; set; }
    public int Priority { get; set; }
    public DateTime Deadline { get; set; }
    public bool Isdone { get; set; }
}

