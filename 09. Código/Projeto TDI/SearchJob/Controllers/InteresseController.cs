using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Model.Models;
using SearchJob.Controllers;

namespace SearchJobWeb.Controllers
{
    public class InteresseController : Controller
    {
        private GerenciadorInteresse gi;
        public InteresseController() => gi = new GerenciadorInteresse();

        // GET: Interesse
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarInteresses()
        {
            List<Interesse> model = gi.ObterTodosInteresses();
            if (model.Count == 0)
                model = null;
            return View(model);

        }

        // GET: Interesse/Details/5
        public IActionResult Detalhes(int? id)
        {
            if (id.HasValue)
            {
                Interesse interesse = gi.ObterInteressePorId(id);
                if (interesse != null)
                    return View(interesse);
            }
            return RedirectToAction(nameof(ListarInteresses), nameof(Usuario));
        }

        // GET: Interesse/Create
        public IActionResult CadastrarInteresse()
        {
            return View();
        }

        // POST: Interesse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarInteresse(Interesse interesse)
        {
            if (ModelState.IsValid && isDisponibilidade == true)
                gi.CadastrarInteresse(interesse);

            return RedirectToAction("Index", "Home");
        } 

        // GET: Interesse/Delete/5
        public IActionResult Remover(int? id)
        {
            if (id.HasValue)
            {
                Interesse u = gi.ObterInteressePorId(id);
                if (u != null)
                    return View(u);
            }
            return RedirectToAction(nameof(ListarInteresses), nameof(Interesse));
        }

        // POST: Interesse/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(int id)
        {
            if (ModelState.IsValid)
            {
                gi.Remover(id);
            }
            return RedirectToAction(nameof(ListarInteresses), nameof(Interesse));
        }


        //[HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult VerificarInteressesAceitar(int status)
        {
            //valor dos status: 0-Aguardando Resposta, 1-Aceito, 2-Recusado            
            status = 1;
            return View(status);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult VerificarInteressesRecusar(int status)
        {
            //valor dos status: 0-Aguardando Resposta, 1-Aceito, 2-Recusado
            status = 2;
            return View(status);
        }
    }
}
