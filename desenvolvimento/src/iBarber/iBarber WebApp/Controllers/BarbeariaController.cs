using iBarber.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iBarber.Dados.EntityFramework;

namespace iBarber_WebApp.Controllers
{
    public class BarbeariaController : Controller
    {
        /*public static List<Barbearia> listaDeBarbearia = new List<Barbearia>
        {
            new Barbearia { CNPJ = "12345678910123", Nome = "Gustavo", Local = "Av, 1"},
            new Barbearia { CNPJ = "12345678910124", Nome = "Agnaldo", Local = "Av, 2"},
            new Barbearia { CNPJ = "12345678910125", Nome = "Bigodon", Local = "Av, 3"}


        };*/

        public IActionResult Index(string cnpj, string barbearia, string logradouro)
        {
            var objeto = new Barbearia();
            objeto.CNPJ = cnpj;
            objeto.Nome = barbearia;
            objeto.Logradouro = logradouro;

            return View(objeto);
        }

        [HttpGet]

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Barbearia barbearia)
        {
            var db = new Contexto();

            var obj = db.Barbearia.FirstOrDefault(c => c.CNPJ == barbearia.CNPJ);

            if (obj == null)
            {
                db.Barbearia.Add(barbearia);
            }
            else
            {
                obj.CNPJ = barbearia.CNPJ;
                db.Barbearia.Update(barbearia);
            }


            db.Barbearia.Add(barbearia);
            db.SaveChanges();



            return RedirectToAction("Listar");
        }

        [HttpGet]

        public IActionResult Editar(string cnpj)
        {
            var db = new Contexto();
            var barbearia = db.Barbearia.First(item => item.CNPJ == cnpj);
            return View("Adicionar", barbearia);
        }

        public IActionResult Listar()
        {
            //SELECT * FROM Estado
            var listaDeBarbearias = new Contexto().Barbearia.ToList();

            return View(listaDeBarbearias);
        }

        public IActionResult Excluir(string cnpj)
        {
            var db = new Contexto();
            var barbearia = db.Barbearia.First(f => f.CNPJ == cnpj);
            db.Barbearia.Remove(barbearia);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }

    }
}
