using Microsoft.AspNetCore.Mvc;
using Ortiz_FinalCalidad.Models;
using Ortiz_FinalCalidad.Repositorio;

namespace Ortiz_FinalCalidad.Controllers
{
    public class CuentaController : Controller
    {

        private readonly InterfaceCuentaRepositorio repositorio;

        public CuentaController(InterfaceCuentaRepositorio rep)
        {
            this.repositorio = rep;
        }


        // GET: CuentaController
        public ActionResult Index()
        {
            ViewBag.cuentas = repositorio.cuentas();
            return View();
        }

        // GET: CuentaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaController/Create
        public ActionResult Create()
        {
            return View(new Cuenta());
        }

        // POST: CuentaController/Create
        [HttpPost]
        public ActionResult Create(Cuenta cuenta)
        {

            if(cuenta.nombre != null && cuenta.categoria != null)
            {
                repositorio.add(cuenta);
                return RedirectToAction(nameof(Index));
            }
            return View(cuenta);
        }

        // GET: CuentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
