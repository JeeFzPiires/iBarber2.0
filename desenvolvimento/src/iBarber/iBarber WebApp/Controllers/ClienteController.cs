using iBarber.Dados.EntityFramework;
using iBarber.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBarber_WebApp.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Adicionar()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarConfirmacao(Cliente cliente)
        {
            return RedirectToAction("Listar");
        }
    }
}
