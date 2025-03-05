namespace Mission08_Team0113.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        void AddTask(Task task);
        void DeleteTask(Task task);
    }
}
