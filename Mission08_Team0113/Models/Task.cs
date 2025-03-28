using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0113.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName {  get; set; }
        public DateTime? DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        [Required]
        [ForeignKey(name: "CategoryId")]
        public string CategoryId { get; set; }
        public Category? CategoryName { get; set; }
        public bool? Completed { get; set; }

    }
}
