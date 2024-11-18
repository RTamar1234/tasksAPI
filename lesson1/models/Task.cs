namespace lesson1.models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Priority { get; set; }
        public string? DueDate { get; set; }
        public string? Status { get; set; }
        public int? ProjectId { get; set; }
        public int? UserId { get; set; }
        public virtual Users? User { get; set; }
        public virtual Projects? Project { get; set; }
        public virtual Attachments? Attachment { get; set; }

        public int? AttachId { get; set; }
    }
}
