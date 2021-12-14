using iBarber.Dados.EntityFramework;
using iBarber.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBarber_WebApp.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index(int agendamentoID, DateTime datahoraInicio, DateTime datahoraFinal)
        {
            var objeto = new Agendamento();
            objeto.AgendamentoID = agendamentoID;
            objeto.DataHoraInicio = datahoraInicio;
            objeto.DataHoraFinal = datahoraFinal;

            return View(objeto);
        }

        [HttpGet]

        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Barbeiro = db.Barbeiro.ToList();
            ViewBag.Barbearia = db.Barbearia.ToList();
            ViewBag.Cliente = db.Cliente.ToList();
            return View();

        }

        public IActionResult AdicionarConfirmacao(Agendamento agendamento)
        {
            var db = new Contexto();

            var obj = db.Agendamento.FirstOrDefault(id => id.AgendamentoID == agendamento.AgendamentoID);

            if (obj == null)
            {
                db.Agendamento.Add(agendamento);
            }
            else
            {
                obj.AgendamentoID = agendamento.AgendamentoID;
                db.Agendamento.Update(agendamento);
            }


            db.Agendamento.Add(agendamento);
            db.SaveChanges();



            return RedirectToAction("Listar");
        }

        [HttpGet]

        public IActionResult Editar(int agendamentoID)
        {
            var db = new Contexto();
            var agendamento = db.Agendamento.First(item => item.AgendamentoID == agendamentoID);
            return View("Adicionar", agendamentoID);
        }

        public IActionResult Listar()
        {
            //SELECT * FROM Barbearias
            var listaDeAgendamentos = new Contexto().Agendamento.ToList();

            return View(listaDeAgendamentos);
        }

        public IActionResult Excluir(int agendamentoID)
        {
            var db = new Contexto();
            var agendamento = db.Agendamento.First(id => id.AgendamentoID == agendamentoID);
            db.Agendamento.Remove(agendamento);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
