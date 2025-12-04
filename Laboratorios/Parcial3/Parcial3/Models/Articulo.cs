using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    [Table("AR_Articulos")]
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required]
        [StringLength(300)]
        public string Titulo { get; set; }

        public string Resumen { get; set; }

        public int? Año { get; set; }

        [ForeignKey("Revista")]
        public int? RevistaId { get; set; }

        public string InformeTecnico { get; set; }

        public virtual Revista Revista { get; set; }

        public virtual ICollection<ArticuloAutor> ArticulosAutores { get; set; }

        public Articulo()
        {
            ArticulosAutores = new HashSet<ArticuloAutor>();
        }
    }
}
