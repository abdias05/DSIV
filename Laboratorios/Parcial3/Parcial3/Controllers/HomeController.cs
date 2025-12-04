using System.Linq;
using System.Web.Mvc;
using Parcial3.Models;
using System.Data.Entity;

namespace Parcial3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // =========================================
        // INDEX
        // =========================================
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArticulosIndex()
        {
            var articulos = db.Articulos
                              .Include(a => a.Revista)
                              .ToList();
            return View(articulos);
        }


        public ActionResult ArticulosCreate()
        {
            ViewBag.Revistas = new SelectList(db.Revistas, "RevistaId", "NombreRevista");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ArticulosCreate(Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Articulos.Add(articulo);
                db.SaveChanges();
                return RedirectToAction("ArticulosIndex");
            }

            ViewBag.Revistas = new SelectList(db.Revistas, "RevistaId", "NombreRevista", articulo.RevistaId);
            return View(articulo);
        }

        // =========================================
        // AUTORES
        // =========================================
        public ActionResult AutoresIndex()
        {
            var autores = db.Autores.ToList();
            return View(autores);
        }

        public ActionResult AutoresCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AutoresCreate(Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Autores.Add(autor);
                db.SaveChanges();
                return RedirectToAction("AutoresIndex");
            }
            return View(autor);
        }

        // =========================================
        // REVISTAS
        // =========================================
        public ActionResult RevistasIndex()
        {
            var revistas = db.Revistas.ToList();
            return View(revistas);
        }

        public ActionResult RevistasCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RevistasCreate(Revista revista)
        {
            if (ModelState.IsValid)
            {
                db.Revistas.Add(revista);
                db.SaveChanges();
                return RedirectToAction("RevistasIndex");
            }
            return View(revista);
        }

        public ActionResult ArticulosEdit(int id)
        {
            var articulo = db.Articulos.Find(id);
            if (articulo == null) return HttpNotFound();

            ViewBag.Revistas = new SelectList(db.Revistas, "RevistaId", "NombreRevista", articulo.RevistaId);
            return View(articulo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ArticulosEdit(Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ArticulosIndex");
            }
            ViewBag.Revistas = new SelectList(db.Revistas, "RevistaId", "NombreRevista", articulo.RevistaId);
            return View(articulo);
        }

        // Eliminar Artículo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ArticulosDelete(int id)
        {
            var articulo = db.Articulos.Find(id);
            if (articulo != null)
            {
                db.Articulos.Remove(articulo);
                db.SaveChanges();
            }
            return RedirectToAction("ArticulosIndex");
        }

        public ActionResult AutoresEdit(int id)
        {
            var autor = db.Autores.Find(id);
            if (autor == null) return HttpNotFound();
            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AutoresEdit(Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AutoresIndex");
            }
            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AutoresDelete(int id)
        {
            var autor = db.Autores.Find(id);
            if (autor != null)
            {
                db.Autores.Remove(autor);
                db.SaveChanges();
            }
            return RedirectToAction("AutoresIndex");
        }

        public ActionResult RevistasEdit(int id)
        {
            var revista = db.Revistas.Find(id);
            if (revista == null) return HttpNotFound();
            return View(revista);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RevistasEdit(Revista revista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(revista).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("RevistasIndex");
            }
            return View(revista);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RevistasDelete(int id)
        {
            var revista = db.Revistas.Find(id);
            if (revista != null)
            {
                db.Revistas.Remove(revista);
                db.SaveChanges();
            }
            return RedirectToAction("RevistasIndex");
        }
        public ActionResult Consulta(string titulo, int? autorId, int? revistaId)
        {
            // Consulta con include para cargar revistas y autores
            var query = db.Articulos
               .Include(a => a.Revista)
               .Include(a => a.ArticulosAutores.Select(aa => aa.Autor))
               .AsQueryable();


            if (!string.IsNullOrEmpty(titulo))
            {
                query = query.Where(a => a.Titulo.Contains(titulo));
            }

            if (autorId.HasValue && autorId.Value > 0)
            {
                query = query.Where(a => a.ArticulosAutores.Any(aa => aa.AutorId == autorId.Value));
            }

            if (revistaId.HasValue && revistaId.Value > 0)
            {
                query = query.Where(a => a.RevistaId == revistaId.Value);
            }

            ViewBag.Autores = db.Autores.ToList();
            ViewBag.Revistas = db.Revistas.ToList();

            return View(query.ToList());
        }
    }
}