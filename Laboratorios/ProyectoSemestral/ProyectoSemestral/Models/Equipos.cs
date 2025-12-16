using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoSemestral.Models
{
    [Table("Equipos")]
    public class Equipos
    {
        [Key]
        public int ID_equipo { get; set; }

        public string Nombre { get; set; }
    }
}

