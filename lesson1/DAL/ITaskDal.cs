using lesson1.models;
using Microsoft.AspNetCore.Mvc;

namespace lesson1.DAL
{
    public interface ITaskDal
    {
        List<Tasks> GetTasks();
        //void SaveTasks(List<Tasks> tasks);
        public bool Add(Tasks tasks);
        public void Delete(int id);
         public Tasks GetById(int id);
         public void Update(Tasks tasks);
    }
}
