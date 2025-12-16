using System;
using System.Collections.Generic;

namespace ProyectoSemestral.Models
{
    public class Usuarios
    {
        public int ID_usuario { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        
        // Fecha de registro del usuario
        public DateTime FechaRegistro { get; set; } = DateTime.Now; // Inicializa automáticamente
        public virtual ICollection<Predicciones> Predicciones { get; set; }

    }
}
