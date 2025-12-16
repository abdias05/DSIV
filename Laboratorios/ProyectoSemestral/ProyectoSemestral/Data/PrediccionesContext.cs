using ProyectoSemestral.Models;
using System.Data.Entity;

namespace ProyectoSemestral.Data
{
    public class PrediccionesDbContext : DbContext
    {
        public PrediccionesDbContext() : base("name=PrediccionesDB") { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipos> Equipos { get; set; }
        public DbSet<Partidos> Partidos { get; set; }
        public DbSet<Predicciones> Predicciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuarios>().HasKey(u => u.ID_usuario);
            modelBuilder.Entity<Equipos>().HasKey(e => e.ID_equipo);
            modelBuilder.Entity<Partidos>().HasKey(p => p.ID_partido);
            modelBuilder.Entity<Predicciones>().HasKey(pr => pr.ID_prediccion);
        }
    }
}
