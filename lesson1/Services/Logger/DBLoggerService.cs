using lesson1.DAL;
using TasksApi.Services.Logger;

namespace lesson1.Services.Logger
{
    public class DBLoggerService : ILoggerService
    {
        private readonly ILoggerDal _LoggerDal;
        public DBLoggerService(ILoggerDal LoggerDal)
        {
            _LoggerDal = LoggerDal;
        }
        public void Log(string message)
        {
            _LoggerDal.Add(message);
        }
    }
}
