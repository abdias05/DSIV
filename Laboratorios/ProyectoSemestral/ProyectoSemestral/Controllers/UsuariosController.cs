using ProyectoSemestral.Data;
using ProyectoSemestral.Models;
using ProyectoSemestral.Models.DTOs;
using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using BCrypt.Net;

namespace ProyectoSemestral.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        private readonly PrediccionesDbContext _context = new PrediccionesDbContext();
        [HttpPost]
        [Route("registrar")]
        public IHttpActionResult Registrar([FromBody] UsuarioRegistroDTO modelo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (string.IsNullOrWhiteSpace(modelo.Email) ||
                string.IsNullOrWhiteSpace(modelo.Usuario) ||
                string.IsNullOrWhiteSpace(modelo.Contraseña))
                return BadRequest("Los campos no pueden estar vacíos");

            try
            {
                var existe = _context.Usuarios.Any(u => u.Email == modelo.Email);
                if (existe)
                    return Content(HttpStatusCode.Conflict, "El correo ya está registrado.");

                var nuevo = new Usuarios
                {
                    Usuario = modelo.Usuario,
                    Email = modelo.Email,
                    Contraseña = modelo.Contraseña,
                    FechaRegistro = DateTime.Now
                };

                _context.Usuarios.Add(nuevo);
                _context.SaveChanges();

                return Ok(new { mensaje = "Usuario creado exitosamente", idUsuario = nuevo.ID_usuario });
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error al registrar usuario: {ex.Message}"));
            }
        }

       
        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login([FromBody] UsuarioLoginDTO modelo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (string.IsNullOrWhiteSpace(modelo.Email) ||
                string.IsNullOrWhiteSpace(modelo.Contraseña))
                return BadRequest("Email y contraseña son requeridos");

            try
            {
                var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == modelo.Email);
                if (usuario == null)
                    return Unauthorized();

                if (usuario.Contraseña != modelo.Contraseña)
                    return Unauthorized();


                return Ok(new
                {
                    mensaje = "Inicio de sesión correcto",
                    idUsuario = usuario.ID_usuario,
                    usuario = usuario.Usuario
                });
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error en login: {ex.Message}"));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}