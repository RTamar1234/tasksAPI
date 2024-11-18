namespace lesson1.models
{
    public class Users
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
