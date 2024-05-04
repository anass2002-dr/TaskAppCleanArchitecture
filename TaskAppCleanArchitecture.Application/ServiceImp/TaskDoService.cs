using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Application.Repository;
using TaskAppCleanArchitecture.Application.Service;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Application.ServiceImp
{
    public class TaskDoService : ITaskDoService
    {
        public readonly ITaskDoRepository _IRepository;
        public TaskDoService(ITaskDoRepository repository) { 
            _IRepository = repository;
        }

        public TacheDo CreateTaskDo(TacheDo taskDo)
        {
           return _IRepository.CreateTaskDo(taskDo);
        }

        public bool DeleteTaskDo(int id)
        {
            return _IRepository.DeleteTaskDo(id);
        }

        public List<object> GetTaskDos()
        {
            return _IRepository.GetTaskDos();
        }

        public TacheDo GetTaskDosById(int id)
        {
            return _IRepository.GetTaskDosById(id);
        }

        public List<object> GetTaskFinished()
        {
            return _IRepository.GetTaskFinished();
        }

        public TacheDo UpdateTaskDo(TacheDo taskDo)
        {
            return _IRepository.UpdateTaskDo(taskDo);
        }
    }
}
