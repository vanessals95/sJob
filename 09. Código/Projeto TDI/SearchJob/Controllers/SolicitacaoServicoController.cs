﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SearchJobWeb.Controllers
{
    public class SolicitacaoServicoController : Controller
    {
        // GET: SolicitacaoServico
        public ActionResult Index()
        {
            return View();
        }

        // GET: SolicitacaoServico/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: SolicitacaoServico/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: SolicitacaoServico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SolicitacaoServico/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: SolicitacaoServico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SolicitacaoServico/Delete/5
        public ActionResult Remover(int id)
        {
            return View();
        }

        // POST: SolicitacaoServico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remover(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}