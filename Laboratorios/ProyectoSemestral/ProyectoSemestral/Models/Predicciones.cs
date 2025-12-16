using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoSemestral.Models
{
    [Table("Predicciones")]
    public class Predicciones
    {
        [Key]
        public int ID_prediccion { get; set; }

        public int ID_usuario { get; set; }
        public int ID_partido { get; set; }

        public int GolLocalPred { get; set; }
        public int GolVisitantePred { get; set; }
        public int? PuntosObtenidos { get; set; }

        // 🔗 Relaciones
        [ForeignKey("ID_usuario")]
        public Usuarios Usuario { get; set; }

        [ForeignKey("ID_partido")]
        public Partidos Partido { get; set; }
    }
}
