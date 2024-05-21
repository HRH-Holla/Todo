using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace TodoApp.Model
{
    public class TaskObj
    {

        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        
        public string? Description { get; set; }

        //TODO require data validation
        public DateTime DueDate { get; set; } = DateTime.Now;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime completed { get; set; } = DateTime.Now;
        public DateTime Started  { get; set; } = DateTime.Now;

        public  Enum? Status { get; set; }
    }
}
