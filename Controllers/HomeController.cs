using Microsoft.AspNetCore.Mvc;
using NdihmesTagLaborator.Data;
using NdihmesTagLaborator.Models;
using System.Diagnostics;

namespace NdihmesTagLaborator.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pershendetje()
        {
            int ora = DateTime.Now.Hour;
            string rezultat = ora < 12 ? "Miremengjes Perdorues" : "Miredita Perdorues";
            return View("Pershendetje", rezultat);
        }

        public IActionResult FormaKonference()
        {
            return View();
        }
        

        public IActionResult AfishoListe()
        {
            var objekte = _db.Eventet.Where(e => e.Konfirmim == true);

                return View(objekte.ToList());
            

        }
    [HttpPost]
    public IActionResult FormaKonference(Evente ev)

        {
            if (ModelState.IsValid)
            {
                 _db.Add(ev);
                 _db.SaveChanges();
                return View("Rezultat", ev);
            }
            return View();
        }
        public IActionResult Rezultat()
        {
            return View();
        }

    }
}