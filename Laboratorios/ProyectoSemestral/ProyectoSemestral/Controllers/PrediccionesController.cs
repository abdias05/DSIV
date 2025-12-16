using ProyectoSemestral.Data;
using ProyectoSemestral.Models;
using ProyectoSemestral.Models.DTOs;
using System;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProyectoSemestral.Controllers
{
    [RoutePrefix("api/predicciones")]
    public class PrediccionesController : ApiController
    {
        private readonly PrediccionesDbContext _context = new PrediccionesDbContext();

        // ============================
        // CREAR PREDICCIÓN
        // ============================
        [HttpPost]
        [Route("crear")]
        public IHttpActionResult CrearPrediccion([FromBody] PrediccionDTO modelo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                // Validar si el partido ya tiene resultado
                var partido = _context.Partidos.FirstOrDefault(p => p.ID_partido == modelo.ID_partido);
                if (partido == null)
                    return NotFound();

                if (partido.GolesLocal.HasValue || partido.GolesVisitante.HasValue)
                    return BadRequest("No se puede predecir un partido ya jugado.");

                // Validar que el usuario no haya predicho ese partido
                var existe = _context.Predicciones.Any(pr => pr.ID_usuario == modelo.ID_usuario && pr.ID_partido == modelo.ID_partido);
                if (existe)
                    return BadRequest("Ya realizaste una predicción para este partido.");

                // Crear predicción
                var nueva = new Predicciones
                {
                    ID_usuario = modelo.ID_usuario,
                    ID_partido = modelo.ID_partido,
                    GolLocalPred = modelo.GolLocalPred,
                    GolVisitantePred = modelo.GolVisitantePred
                };

                _context.Predicciones.Add(nueva);
                _context.SaveChanges();

                return Ok(new { mensaje = "Predicción creada exitosamente", idPrediccion = nueva.ID_prediccion });
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error al crear predicción: {ex.Message}"));
            }
        }

        // ============================
        // OBTENER PREDICCIONES DE USUARIO
        // ============================
        [HttpGet]
        [Route("mis-predicciones/{idUsuario:int}")]
        public IHttpActionResult MisPredicciones(int idUsuario)
        {
            try
            {
                var predicciones = _context.Predicciones
                    .Where(pr => pr.ID_usuario == idUsuario)
                    .Select(pr => new
                    {
                        pr.ID_prediccion,
                        pr.ID_partido,
                        EquipoLocal = pr.Partido.EquipoLocal.Nombre,
                        EquipoVisitante = pr.Partido.EquipoVisitante.Nombre,
                        FechaPartido = pr.Partido.FechaPartido,
                        pr.GolLocalPred,
                        pr.GolVisitantePred,
                        pr.PuntosObtenidos
                    })
                    .OrderBy(pr => pr.FechaPartido)
                    .ToList();

                return Ok(predicciones);
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception($"Error al obtener predicciones: {ex.Message}"));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context?.Dispose();

            base.Dispose(disposing);
        }


        [HttpGet]
        [Route("historial/{idUsuario}")]
        public IHttpActionResult GetHistorial(int idUsuario)
        {
            var historial = _context.Predicciones
                .Where(p => p.ID_usuario == idUsuario)
                .Select(p => new
                {
                    p.ID_partido,
                    p.Partido.FechaPartido,
                    EquipoLocal = p.Partido.EquipoLocal.Nombre,
                    EquipoVisitante = p.Partido.EquipoVisitante.Nombre,
                    p.GolLocalPred,
                    p.GolVisitantePred,
                    p.Partido.GolesLocal,
                    p.Partido.GolesVisitante,
                    p.PuntosObtenidos
                })
                .ToList();

            return Ok(historial);
        }
    }
}
