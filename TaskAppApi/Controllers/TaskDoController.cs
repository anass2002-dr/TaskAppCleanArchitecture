using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAppApi.Dtos.TacheDoDtos;
using TaskAppCleanArchitecture.Application.Service;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskDoController : Controller
    {
        public readonly ITaskDoService _taskDoService;
        public TaskDoController(ITaskDoService taskDoService) 
        {
            _taskDoService = taskDoService;

        }
        // GET: TaskDoController
        [HttpGet("GetTaskDo")]
        public ActionResult<List<object>> GetTaskDo()
        {
            return Ok(_taskDoService.GetTaskDos());
        }

        [HttpGet("GetTaskFinished")]
        public ActionResult<List<object>> GetTaskFinished()
        {
            return Ok(_taskDoService.GetTaskFinished());
        }
        [HttpGet("GetTaskDoBy/{id}")]
        public ActionResult<TacheDo> GetTaskDoById(int id)
        {
            return Ok(_taskDoService.GetTaskDosById(id));
        }
        [HttpPost("AddTaskDo")]
        public ActionResult<TacheDo> AddTaskDo(CreateTacheDoDtos CreateTacheDoDtos)
        {
            var taskDo = new TacheDo { Name = CreateTacheDoDtos.Name, Description = CreateTacheDoDtos.Description, idTacheStatut = CreateTacheDoDtos.idTacheStatut };
            return Ok(_taskDoService.CreateTaskDo(taskDo));
        }
        [HttpPut("update[controller]")]
        public ActionResult<TacheDo> UpdateTaskDo(TacheDo taskDo)
        {
            return Ok(_taskDoService.UpdateTaskDo(taskDo));
        }
        [HttpDelete("DeleteTaskDo/{id}")]
        public ActionResult<bool> DeleteTaskDo(int id)
        {
            return Ok(_taskDoService.DeleteTaskDo(id));
        }
        //// GET: TaskDoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: TaskDoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: TaskDoController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: TaskDoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TaskDoController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: TaskDoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TaskDoController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
