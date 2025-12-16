using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSemestral.Models.DTOs
{
    public class PrediccionDTO
    {
        public int ID_usuario { get; set; }
        public int ID_partido { get; set; }
        public int GolLocalPred { get; set; }
        public int GolVisitantePred { get; set; }
    }
}