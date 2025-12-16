using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSemestral.Models.DTOs
{
    public class UsuarioLoginDTO
    {
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}