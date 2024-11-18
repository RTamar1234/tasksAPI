using lesson1.DAL;
using lesson1.models;

namespace lesson1.Services
{
    public class UserService:IUserService
    {
        private readonly ITaskDal _taskDal;
        public UserService(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public List<Tasks> GetUserTasks(int userId)
        {
            var tasks = _taskDal.GetTasks();
            List<Tasks> task = tasks.Where(x =>x.UserId==userId).ToList();
            if (task == null)
                return new List<Tasks>();
            return task;
        }


    }
}
