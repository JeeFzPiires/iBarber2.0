using iBarber.Dados.EntityFramework;
using iBarber.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBarber_WebApp.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Barbeiria = db.Barbearia.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarConfirmacao(Cidade cidade)
        {
            return RedirectToAction("Listar");
        }
    }
}
