using lesson1.models;
using lesson3.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;
using System;


namespace lesson1.DAL
{
    public class TaskDal : ITaskDal
    {

        private readonly TasksDBContext _context;

        public TaskDal(TasksDBContext context)
        {
            _context = context;
        }

        public List<Tasks> GetTasks()
        {
            return _context.Tasks.ToList();
        }


        public bool Add(Tasks tasks)
        {
            Projects? project = _context.Projects.Find(tasks.ProjectId);
            Users? user = _context.Users.Find(tasks.UserId);
            if (project!=null && user!=null){
                _context.Tasks.Add(tasks);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Delete(int id)
        {
            Tasks? tasks = _context.Tasks.Find(id);

            if (tasks != null)
            {
                _context.Tasks.Remove(tasks);
                _context.SaveChanges();
            }
        }

        public Tasks GetById(int id)
        {
            Tasks? tasks = _context.Tasks.Find(id);
            return tasks;
        }

        public void Update(Tasks tasks)
        {
            _context.Tasks.Update(tasks);
            _context.SaveChanges();
        }

    }
}
