using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Application.Repository;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Infrastructure
{
    public class TaskDoRepository : ITaskDoRepository
    {
        private readonly TachesDbContext _tachesDbContext;
        public TaskDoRepository(TachesDbContext tachesDbContext)
        {
            _tachesDbContext = tachesDbContext;
        }

        public List<object> GetTaskDos()
        {
            var tache = _tachesDbContext.Taches.Join(
                _tachesDbContext.TacheStatuts,
                TacheDo => TacheDo.idTacheStatut,
                TacheStatut => TacheStatut.Id,
                (TacheDo,TacheStatut)=>new
                {
                    Name = TacheDo.Name,
                    Description = TacheDo.Description,
                    Statut=TacheStatut.statut,
                    StatutDesc=TacheStatut.Description
                }
                );

            //return _tachesDbContext.Taches.Include(e=>e.TacheStatut).ToList();
            return tache.ToList<dynamic>();
        }
        public TacheDo GetTaskDosById(int id)
        {
            //return _tachesDbContext.Taches.Find(id);
            return _tachesDbContext.Taches.Include(e => e.TacheStatut).FirstOrDefault(e=>e.Id==id);

        }
        public bool DeleteTaskDo(int id)
        {
            try
            {
                _tachesDbContext.Taches.Remove(GetTaskDosById(id));
                _tachesDbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;

            }

        }
        public TacheDo CreateTaskDo(TacheDo taskDo) 
        {
            _tachesDbContext.Taches.Add(taskDo);
            _tachesDbContext.SaveChanges();
            return taskDo;
        }
        public TacheDo UpdateTaskDo(TacheDo taskDo) 
        {
            var result =_tachesDbContext.Taches.Update(taskDo).Entity;
            _tachesDbContext.SaveChanges();
            return result;
        }

        public List<object> GetTaskFinished()
        {
            var result = from td in _tachesDbContext.Taches
                         join ts in _tachesDbContext.TacheStatuts on td.idTacheStatut equals ts.Id into jointureGauche
                         from ts in jointureGauche.DefaultIfEmpty()
                         where ts.statut == "finished"
                         select new
                         {
                             td.Id,
                             td.Name,
                             td.Description,
                             Statut = ts != null ? ts.statut : null // Assurez-vous de traiter le cas où ts est null
                         };
            return result.ToList<object>();
        }
    }
}
