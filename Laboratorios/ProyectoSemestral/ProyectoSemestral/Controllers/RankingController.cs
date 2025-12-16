using System.Linq;
using System.Web.Http;
using ProyectoSemestral.Data;

namespace ProyectoSemestral.Controllers.Api
{
    [RoutePrefix("api/ranking")]
    public class RankingController : ApiController
    {
        private readonly PrediccionesDbContext _context = new PrediccionesDbContext();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetRanking()
        {
            var ranking = _context.Usuarios
                .Select(u => new
                {
                    u.ID_usuario,
                    u.Usuario,
                    TotalPuntos = u.Predicciones.Sum(p => (int?)p.PuntosObtenidos) ?? 0
                })
                .OrderByDescending(u => u.TotalPuntos)
                .ToList();

            return Ok(ranking);
        }
    }
}
