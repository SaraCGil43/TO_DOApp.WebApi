namespace ToDo_SolutionWebApi.Models
{
    public class TODOITEM
    {
        public int Id { get; set; }
        public string Task { get; set; }

        public bool IsCompleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
