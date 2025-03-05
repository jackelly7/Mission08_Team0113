namespace Mission08_Team0113.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskDbContext _context;

        public EFTaskRepository(TaskDbContext temp) 
        {
            _context = temp;
        }

        public List<Task> Tasks => _context.Tasks.ToList(); 
        
        
        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
