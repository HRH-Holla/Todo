namespace TodoApp.Model
{
    public class Objective
    {

        public int Id { get; set; }
        public required string Name { get; set; }

        public DateTime created { get; set; } = DateTime.Now;
        public DateTime Completed {  get; set; } 
      

    }
}
