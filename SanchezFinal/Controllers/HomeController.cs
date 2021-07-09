using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SanchezFinal.Configuration;
using SanchezFinal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SanchezFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinalContext context;
        public HomeController(FinalContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult Cuentas()
        {
            var cuentas = context.Cuentas
                .Where(o => o.IdUser == LoggedUser().Id)
                .ToList();
            ViewBag.MontoTotal = cuentas.Sum(o => o.Saldo);
            return View(cuentas);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Crear()
        {
            ViewBag.Categorias = new List<string> { "Propio", "Credito" };
            return View(new Cuenta());
        }
        [Authorize]
        [HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                cuenta.IdUser = LoggedUser().Id;
                if (cuenta.Categoria == "Credito")
                {
                    cuenta.Limite = cuenta.Saldo;
                    cuenta.Saldo = 0;
                }
                else
                {
                    cuenta.Limite = 0;
                    cuenta.Transaccions = new List<Transaccion>
                    {
                        new Transaccion
                        {
                            Fecha = DateTime.Now,
                            Tipo = "Ingreso",
                            Monto = cuenta.Saldo,
                            Descripcion = "Saldo Inicial"
                        }
                    };
                }
                context.Cuentas.Add(cuenta);
                context.SaveChanges();
                return RedirectToAction("Cuentas");
            }
            ViewBag.Categorias = new List<string> { "Propio", "Credito" };
            return View(cuenta);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Ingresos(int id)
        {
            var transacciones = context.Transaccions.
                Where(o => o.IdCuenta == id && o.Tipo == "Ingreso").ToList();
            ViewBag.Cuenta = context.Cuentas.First(o => o.Id == id);
            return View(transacciones);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Gastos(int id)
        {
            var transacciones = context.Transaccions.
                Where(o => o.IdCuenta == id && o.Tipo == "Gasto").ToList();
            ViewBag.Cuenta = context.Cuentas.First(o => o.Id == id);
            return View(transacciones);
        }
        [Authorize]
        [HttpGet]
        public ActionResult CrearIngreso(int id)
        {
            ViewBag.CuentaId = id;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CrearIngreso(Transaccion transaccion)
        {
            var cuenta = context.Cuentas.First(o => o.Id == transaccion.IdCuenta);
            transaccion.Tipo = "Ingreso";
            transaccion.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.Transaccions.Add(transaccion);
                context.SaveChanges();
                ModificaMontoCuenta(transaccion.IdCuenta);
                return RedirectToAction("Cuentas", new { id = transaccion.IdCuenta });
            }
            ViewBag.CuentaId = transaccion.IdCuenta;
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult CrearGasto(int id)
        {
            ViewBag.CuentaId = id;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CrearGasto(Transaccion transaccion)
        {
            var cuenta = context.Cuentas.First(o => o.Id == transaccion.IdCuenta);
            if ((cuenta.Limite + cuenta.Saldo) <= transaccion.Monto)
                ModelState.AddModelError("Cuenta", "El gasto supera el saldo de la cuenta");
            transaccion.Tipo = "Gasto";
            transaccion.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                transaccion.Monto *= -1;
                context.Transaccions.Add(transaccion);
                context.SaveChanges();
                ModificaMontoCuenta(transaccion.IdCuenta);
                return RedirectToAction("Cuentas", new { id = transaccion.IdCuenta });
            }
            ViewBag.CuentaId = transaccion.IdCuenta;
            return View();
        }

        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void ModificaMontoCuenta(int cuentaId)
        {
            var cuenta = context.Cuentas
                .Include(o => o.Transaccions)
                .FirstOrDefault(o => o.Id == cuentaId);

            var total = cuenta.Transaccions.Sum(o => o.Monto);
            cuenta.Saldo = total;
            context.SaveChanges();
        }
    }
}
