using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAppApi.Dtos.TacheStatutDtos;
using TaskAppCleanArchitecture.Application.Service;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskStatutController : ControllerBase
    {
        private readonly ITaskStatutService _taskStatutService;
        public TaskStatutController(ITaskStatutService taskStatutService)
        {
            _taskStatutService  = taskStatutService;
        }
        [HttpPost("AddTaskStatut")]
        public ActionResult AddTaskStatut(CreateTacheStatutsDtos CreateTacheStatutsDtos)
        {
            var taskStatut = new TacheStatut { Description = CreateTacheStatutsDtos.Description, statut = CreateTacheStatutsDtos.statut };
            return Ok(_taskStatutService.CreateTaskStatut(taskStatut));
        }
        [HttpGet("GetTaskStatutToDo")]
        public ActionResult GetTaskStatutToDo()
        {
            
            return Ok(_taskStatutService.GetTaskStatutDo());
        }

    }
}
