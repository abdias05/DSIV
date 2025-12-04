

// Models / Revista.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    [Table("AR_Revistas")]
    public class Revista
    {
        [Key]
        public int RevistaId { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreRevista { get; set; }

        public string ISSN { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }

        public Revista()
        {
            Articulos = new HashSet<Articulo>();
        }
    }

}

