﻿namespace lesson1.models
{
    public class Attachments
    {
        public int AttachId { get; set; }

        public string? AttachPath { get; set; }

        public string? UploadDate { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();



    }
}
