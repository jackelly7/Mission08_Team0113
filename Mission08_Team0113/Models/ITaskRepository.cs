namespace Mission08_Team0113.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        IQueryable<Category> Categories { get; }
        void UpdateTask(Task task);

        void AddTask(Task task);
        void DeleteTask(Task task);
    }
}
