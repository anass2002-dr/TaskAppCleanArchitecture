using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Application.Repository;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Infrastructure
{
    public class TaskStatutRepository : ITaskStatutRepository
    {
        private readonly TachesDbContext _context;
        public TaskStatutRepository(TachesDbContext tachesDbContext) 
        {
            _context = tachesDbContext;
        }
        public TacheStatut CreateTaskStatut(TacheStatut TaskStatut)
        {
            var obj = _context.TacheStatuts.Add(TaskStatut).Entity;
            _context.SaveChanges();
            return obj;
            
        }

        public bool DeleteTaskStatut(int id)
        {
            throw new NotImplementedException();
        }

        public List<TacheStatut> GetTaskStatut()
        {
            throw new NotImplementedException();
        }

        public TacheStatut GetTaskStatutById(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetTaskStatutDo()
        {
            var result = from ts in _context.TacheStatuts
                         join td in _context.Taches on ts.Id equals td.idTacheStatut into jointureGauche
                         from td in jointureGauche.DefaultIfEmpty()
                         select new
                         {
                             IdStatut = ts.Id,
                             Statut = ts.statut,
                             NomTache = td != null ? td.Name : null, // Assurez-vous de traiter le cas où td est null
                             IdTacheStatut = td != null ? td.idTacheStatut : null // Assurez-vous de traiter le cas où td est null
                         };
            return result.ToList<object>();

        }

        public TacheStatut UpdateTaskStatut(TacheStatut TaskStatut)
        {
            throw new NotImplementedException();
        }
    }
}
