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
    public class TaskStatutService : ITaskStatutService
    {
        private readonly ITaskStatutRepository _taskStatutRepository;
        public TaskStatutService(ITaskStatutRepository taskStatutRepository) {
            _taskStatutRepository = taskStatutRepository;
        }
        public TacheStatut CreateTaskStatut(TacheStatut TaskStatut)
        {
            return _taskStatutRepository.CreateTaskStatut(TaskStatut);
        }

        public bool DeleteTaskStatut(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetTaskStatut()
        {
            throw new NotImplementedException();
        }

        public TacheStatut GetTaskStatutById(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetTaskStatutDo()
        {
            return _taskStatutRepository.GetTaskStatutDo();
        }

        public TacheStatut UpdateTaskStatut(TacheStatut TaskStatut)
        {
            throw new NotImplementedException();
        }
    }
}
