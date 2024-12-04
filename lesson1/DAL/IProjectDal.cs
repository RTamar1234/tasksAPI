using lesson1.models;

namespace lesson1.DAL
{
    public interface IProjectDal
    {
        public List<Projects> GetTasks();
        public void Add(Projects project);
        public void Delete(int id);
        public Projects GetById(int id);
        public void Update(Projects project);
        //public bool ProcessTransaction( Task Task,Projects project);

    }
}
