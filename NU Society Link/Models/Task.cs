
namespace NU_Society_Link.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string rollNum { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string roll, string description, DateTime dueDate)
        {
            Id = id;
            rollNum = roll;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }
    }
}
