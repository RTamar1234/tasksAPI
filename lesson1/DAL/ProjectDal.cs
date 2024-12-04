using lesson1.models;
using lesson3.DAL;
using Microsoft.Data.SqlClient;

namespace lesson1.DAL
{
    public class ProjectDal 
    {
        private readonly TasksDBContext _context;
        public IConfiguration _configuration;
    
       

        public ProjectDal(TasksDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public List<Projects> GetTasks()
        {
            return _context.Projects.ToList();
        }
         

        public void Add(Projects project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Projects? project = _context.Projects.Find(id);

            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
            }
        }

        public Projects GetById(int id)
        {
            Projects? project = _context.Projects.Find(id);
            return project;
        }

        public void Update(Projects project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }

        //public bool ProcessTransaction(Task task, Projects project)
        //{

        //    string connectionString = _configuration.GetConnectionString("DefaultConnection");

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Start a local transaction
        //        SqlTransaction transaction = connection.BeginTransaction();

        //        try
        //        {
        //            using (SqlCommand command1 = new SqlCommand("INSERT INTO Projects (ProjectId),(Title),(Gender),(DueDate) " +
        //                "VALUES (@ProjectId),(@Title),(@Title),(@DueDate)", connection, transaction))
        //            {
        //                command1.Parameters.AddWithValue("@ProjectId", project.ProjectId);
        //                command1.Parameters.AddWithValue("@Title", project.Title);
        //                command1.Parameters.AddWithValue("@Gender", project.Title);
        //                command1.Parameters.AddWithValue("@DueDate", project.Title);
        //                command1.ExecuteNonQuery();
        //            }

        //            using (SqlCommand command2 = new SqlCommand("INSERT INTO Tasks (Id),(Priority),(DueDate),(Status),(ProjectId),(UserId),(AttachId) VALUES (@Id),(@Priority),(@DueDate),(@Status),(@ProjectId),(@UserId),(@AttachId)", connection, transaction))
        //            {
        //                command2.Parameters.AddWithValue("@Id", task.Id);
        //                command2.Parameters.AddWithValue("@Priority", task.Priority);
        //                command2.Parameters.AddWithValue("@DueDate", task.DueDate);
        //                command2.Parameters.AddWithValue("@Status", task.Status);
        //                command2.Parameters.AddWithValue("@ProjectId", task.ProjectId);
        //                command2.Parameters.AddWithValue("@UserId", task.UserId);
        //                command2.Parameters.AddWithValue("@AttachId", task.AttachId);
        //                command2.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            Console.WriteLine("Transaction committed.");
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Transaction failed: " + ex.Message);
        //            try
        //            {
        //                transaction.Rollback();
        //                return false;
        //            }
        //            catch (Exception rollbackEx)
        //            {
        //                Console.WriteLine("Rollback failed: " + rollbackEx.Message);
        //                return false;
        //            }
        //        }
        //    }
        //}
    }
}


