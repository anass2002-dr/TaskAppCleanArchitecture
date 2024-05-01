using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Application.Repository
{
    public interface ITaskDoRepository
    {
        List<object> GetTaskDos();
        List<object> GetTaskFinished();
        TacheDo CreateTaskDo(TacheDo taskDo);
        TacheDo UpdateTaskDo(TacheDo taskDo);
        TacheDo GetTaskDosById(int id);
        bool DeleteTaskDo(int id);
    }
}
