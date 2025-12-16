using ProyectoSemestral.Data;
using ProyectoSemestral.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoSemestral.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public ActionResult CrearSesion(int idUsuario, string usuario)
        {
            Session["UserId"] = idUsuario;
            Session["Usuario"] = usuario;
            return Json(new { ok = true });
        }

        public ActionResult Logout()
        {
            // Eliminar sesión
            Session.Clear();
            Session.Abandon();

            // Evitar cache del navegador
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            return RedirectToAction("Index"); // Acceso
        }

        public ActionResult Partidos()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        private readonly PrediccionesDbContext _context = new PrediccionesDbContext();


      public ActionResult Prediccion(int idUsuario)

    {

        var prediccionesUsuario = _context.Predicciones
            .Where(pr => pr.ID_usuario == idUsuario)
            .Select(pr => pr.ID_partido)
            .ToList();

        var partidos = _context.Partidos
            .Where(p => p.GolesLocal == null && p.GolesVisitante == null)
            .Where(p => !prediccionesUsuario.Contains(p.ID_partido))
            .Select(p => new PartidoViewModel
            {
                ID_partido = p.ID_partido,
                EquipoLocal = p.EquipoLocal.Nombre,
                EquipoVisitante = p.EquipoVisitante.Nombre,
                FechaPartido = p.FechaPartido
            })
            .ToList();

        return View(partidos);
    }

        public ActionResult Ranking()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}