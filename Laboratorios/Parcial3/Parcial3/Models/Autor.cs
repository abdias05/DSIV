
// Models/Autor.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    [Table("AR_Autores")]
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(150)]
        public string Apellido { get; set; }

        public virtual ICollection<ArticuloAutor> ArticulosAutores { get; set; }

        public Autor()
        {
            ArticulosAutores = new HashSet<ArticuloAutor>();
        }
    }
}