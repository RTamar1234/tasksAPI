namespace lesson1.models
{
    public class Projects
    {

        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Gender { get; set; }
        public string? DueDate { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
