using Microsoft.AspNetCore.Mvc;

using AssignmentWebApi.Models;
using AssignmentWebApi.IRepository;

namespace AssignmentWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubTasksController : ControllerBase
    {
        private readonly ITaskRepository _tasksRepository;

        public SubTasksController(ITaskRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        [HttpPost]
        public ActionResult<SubTask> AddSubTask(SubTask subTask)
        {
            var addedSubTask = _tasksRepository.AddSubTask(subTask);
            return CreatedAtAction(nameof(GetSubTasksByTaskId), new { id = subTask.TaskId }, addedSubTask);
        }

        [HttpGet("tasks/{taskId}")]
        public ActionResult<IEnumerable<SubTask>> GetSubTasksByTaskId(int taskId)
        {
            var subTasks = _tasksRepository.GetSubTasksByTaskId(taskId);
            return Ok(subTasks);
        }
    }
}