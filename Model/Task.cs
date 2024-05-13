using System.ComponentModel.DataAnnotations;

namespace TodoApp.Model
{
    public class Task
    {

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime completed { get; set; }
        public DateTime Started  { get; set; }

        public  Enum? Status { get;  }
    }
}
