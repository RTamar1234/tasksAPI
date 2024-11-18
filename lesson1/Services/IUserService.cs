using lesson1.models;

namespace lesson1.Services
{
    public interface IUserService
    {
        List<Tasks> GetUserTasks(int UserId);

    }
}
