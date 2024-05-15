using System.ComponentModel.DataAnnotations;

namespace TodoApp.Model
{
    public class Task
    {
        Task() { }
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required] //TODO require data validation
        public DateTime DueDate { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime completed { get; set; }
        public DateTime Started  { get; set; }

        public  Enum? Status { get;  }
    }
}
