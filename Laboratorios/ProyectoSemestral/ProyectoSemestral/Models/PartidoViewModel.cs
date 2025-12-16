using System;

namespace ProyectoSemestral.Models
{
    public class PartidoViewModel
    {
        public int ID_partido { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime FechaPartido { get; set; }
    }
}
