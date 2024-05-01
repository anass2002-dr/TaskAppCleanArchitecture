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

        public TacheStatut UpdateTaskStatut(TacheStatut TaskStatut)
        {
            throw new NotImplementedException();
        }
    }
}
