﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Application.Service
{
    public interface ITaskStatutService
    {

        List<object> GetTaskStatut();
        List<object> GetTaskStatutDo();

        TacheStatut CreateTaskStatut(TacheStatut TaskStatut);

        TacheStatut UpdateTaskStatut(TacheStatut TaskStatut);
        TacheStatut GetTaskStatutById(int id);
        bool DeleteTaskStatut(int id);
    }
}
