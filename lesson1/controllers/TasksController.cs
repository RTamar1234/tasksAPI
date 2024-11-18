using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lesson1.models;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;
using System.Net.NetworkInformation;
using lesson1.Services;

namespace lesson1.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _tasksService;

        public TasksController(ITaskService tasksService)
        {
            _tasksService = tasksService;
        }

        //get : api/Tasks
        [HttpGet]
        public ActionResult<IEnumerable<Tasks>> GetTasks()
        {
            var tasks = _tasksService.GetTasks();
            return tasks;
        }

        // get : api/Tasks/{id}
        [HttpGet("{status1}")]
        public ActionResult<List<Tasks>> GetTask(string status1)
        {
            var tasks = _tasksService.GetTasks(status1);
            return tasks;
        }

        //post : api/Tasks/
        [HttpPost]
        public ActionResult<Tasks> CreateTasks(Tasks taskCreat)
        {
            bool good = _tasksService.AddTasks(taskCreat);

            //Tasks task = new Tasks();
            //task.Id = tasks.Count + 1;
            //task.Priority = taskCreat.Priority;
            //task.DueDate = taskCreat.DueDate;
            //task.Status = taskCreat.Status;
            //tasks.Add(task);
            if (good)
                return Ok("new task created");
            return BadRequest("not exists");
        }

        //post : api/Tasks/{updateTask}
        [HttpPut("{updateTask}")]
        public ActionResult<Tasks> UpdateTask(Tasks updateTask)
        {
            var tasks = _tasksService.UpdateTask(updateTask);

            //var task = tasks.FirstOrDefault(x => x.Id == updateTask.Id);
            //task.Status = updateTask.Status;

            return Ok(tasks);
        }

        //post : api/Tasks/{id
    
    [HttpDelete("{id}")]
    public ActionResult<Tasks> DeleteTask(int id)
    {
        _tasksService.DeleteTask(id);

        return Ok();
    }
        [HttpGet("projectId/{projectId}")]
        public ActionResult<List<Tasks>> GetTask(int projectId)
        {
            var tasks = _tasksService.GetAllProjectTasks(projectId);
            //List<Tasks> task = tasks.Where(x => x.Status.Contains(status1)).ToList();
            //if (task == null)
            //    return NotFound();
            return tasks;
        }

    }
}
