using System.Linq;
using System.Web.Http;
using ProyectoSemestral.Data;
using ProyectoSemestral.Models;

namespace ProyectoSemestral.Controllers
{
    [RoutePrefix("api/partidos")]
    public class PartidosController : ApiController
    {
        private readonly PrediccionesDbContext db = new PrediccionesDbContext();

        // Obtener los partidos disponibles para un usuario
        [HttpGet]
        [Route("disponibles/{idUsuario:int}")]
        public IHttpActionResult ObtenerPartidosDisponibles(int idUsuario)
        {
            var partidos = db.Partidos
                .Where(p =>
                    p.GolesLocal == null &&
                    p.GolesVisitante == null &&
                    !db.Predicciones.Any(pr =>
                        pr.ID_partido == p.ID_partido &&
                        pr.ID_usuario == idUsuario
                    )
                )
                .Select(p => new
                {
                    p.ID_partido,
                    EquipoLocal = p.EquipoLocal.Nombre,
                    EquipoVisitante = p.EquipoVisitante.Nombre,
                    Fecha = p.FechaPartido
                })
                .OrderBy(p => p.Fecha)
                .ToList();

            return Ok(partidos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
