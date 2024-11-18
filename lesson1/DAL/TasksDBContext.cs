using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using lesson1.models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace lesson3.DAL
{
    public partial class TasksDBContext : DbContext
    {

        public TasksDBContext(DbContextOptions<TasksDBContext> options) : base(options)
        {

        }

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Users> Users { get; set; }
        public virtual DbSet<Attachments> AttachmentsTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project).WithMany(p => p.Tasks)
                     .HasForeignKey(d => d.ProjectId)
                     .HasConstraintName("fk_ProjectToTask");

                entity.HasOne(d => d.User).WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_UserToTask");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.DueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.HasKey(e => e.AttachId);


            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

