using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoSemestral.Models
{
    [Table("Partidos")]
    public class Partidos
    {
        [Key]
        public int ID_partido { get; set; }

        public int ID_equipoLocal { get; set; }
        public int ID_equipoVisitante { get; set; }

        public DateTime FechaPartido { get; set; }

        public int? GolesLocal { get; set; }
        public int? GolesVisitante { get; set; }

        // 🔗 PROPIEDADES DE NAVEGACIÓN
        [ForeignKey("ID_equipoLocal")]
        public Equipos EquipoLocal { get; set; }

        [ForeignKey("ID_equipoVisitante")]
        public Equipos EquipoVisitante { get; set; }
    }
}
