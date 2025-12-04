using System.Data.Entity;

namespace Parcial3.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Revista> Revistas { get; set; }
        public DbSet<ArticuloAutor> ArticulosAutores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuración de la relación muchos a muchos Articulo <-> Autor
            modelBuilder.Entity<ArticuloAutor>()
                .HasKey(aa => new { aa.ArticuloId, aa.AutorId });

            modelBuilder.Entity<ArticuloAutor>()
                .HasRequired(aa => aa.Articulo)
                .WithMany(a => a.ArticulosAutores)
                .HasForeignKey(aa => aa.ArticuloId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ArticuloAutor>()
                .HasRequired(aa => aa.Autor)
                .WithMany(a => a.ArticulosAutores)
                .HasForeignKey(aa => aa.AutorId)
                .WillCascadeOnDelete(true);

            // Configuración opcional de Revista -> Articulos
            modelBuilder.Entity<Articulo>()
                .HasOptional(a => a.Revista)
                .WithMany(r => r.Articulos)
                .HasForeignKey(a => a.RevistaId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
