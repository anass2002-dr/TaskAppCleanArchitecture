using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppCleanArchitecture.Domaine.Models;

namespace TaskAppCleanArchitecture.Infrastructure
{
    public class TachesDbContext:DbContext
    {
        public TachesDbContext(DbContextOptions<TachesDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TacheStatut>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasMany(x => x.TacheDo);
            });
            modelBuilder.Entity<TacheDo>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.TacheStatut)
                .WithMany(x => x.TacheDo)
                .HasForeignKey(x => x.idTacheStatut)
                .OnDelete(DeleteBehavior.NoAction);
                
            });


        }
        public DbSet<TacheStatut> TacheStatuts { get; set; }

        public DbSet<TacheDo> Taches { get; set; }
    }
}
