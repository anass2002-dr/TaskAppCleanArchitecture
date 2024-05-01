using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Domaine.Models;
namespace TaskAppCleanArchitecture.Application.Service
{
    public interface ITaskDoService
    {
        List<object> GetTaskDos();
        List<object> GetTaskFinished();
        TacheDo CreateTaskDo(TacheDo taskDo);
        TacheDo UpdateTaskDo(TacheDo taskDo);
        TacheDo GetTaskDosById(int id);
        bool DeleteTaskDo(int id);

    }
}
