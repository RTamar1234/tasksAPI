using lesson1.models;
using lesson3.DAL;

namespace lesson1.DAL
{
    public class LoggerDal:ILoggerDal
    {
        private readonly TasksDBContext _context;
        public LoggerDal (TasksDBContext context)
        {
            _context = context;
        }

        public void Add(string message)
        {
            Logger l = new Logger {};
            l.Message = message;
            _context.Logger.Add(l);
            _context.SaveChanges();
        }
    }
}
