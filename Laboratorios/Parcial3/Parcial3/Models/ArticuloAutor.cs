/// Models/ArticuloAutor.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    [Table("AR_ArticulosAutores")]
    public class ArticuloAutor
    {
        [Key, Column(Order = 0)]
        public int ArticuloId { get; set; }

        [Key, Column(Order = 1)]
        public int AutorId { get; set; }

        public virtual Articulo Articulo { get; set; }
        public virtual Autor Autor { get; set; }
    }

}