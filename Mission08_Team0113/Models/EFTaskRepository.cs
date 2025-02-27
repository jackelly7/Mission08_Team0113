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
    }
}
