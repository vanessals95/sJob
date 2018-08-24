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
using SearchJobWeb.Areas.Privada.Util;

namespace SearchJobWeb.Controllers
{
    
    public class UsuarioController : Controller
    {     
        private GerenciadorUsuario gu;
        public UsuarioController() => gu = new GerenciadorUsuario();

        // GET: Usuario
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bool armazena = false, bool abandona = false)
        {
            if (armazena)
                SessionHelper.Set(HttpContext.Session, SessionKeys.NOME, "vanessals");
            if (abandona)
                HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ListarUsuarios()
        {
            List<Usuario> model = gu.ObterTodos();
            if (model.Count == 0)
                model = null;
            return View(model);
            
        }

        // GET: Usuario/Details/5
        public IActionResult Detalhes(int? id)
        {
            if (id.HasValue)
            {
                Usuario usuario = gu.ObterPorId(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction(nameof(ListarUsuarios), nameof(Usuario));
        }

        // GET: Usuario/Create
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
                gu.Cadastrar(usuario);
            return RedirectToAction ("Index", "Home");
        }

        // GET: Usuario/Edit/5
        public IActionResult Editar(int? id)
        {
            if (id.HasValue)
            {
                Usuario usuario = gu.ObterPorId(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction(nameof(ListarUsuarios));
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                ModelState.Remove("Id");
                gu.Editar(usuario);
                return RedirectToAction(nameof(ListarUsuarios));
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public IActionResult Remover(int? id)
        {
            if (id.HasValue)
            {
                Usuario u = gu.ObterPorId(id);
                if (u != null)
                    return View(u);
            }
            return RedirectToAction(nameof(ListarUsuarios), nameof(Usuario));
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(int id)
        {
            if (ModelState.IsValid)
            {
                gu.Remover(id);
            }
            return RedirectToAction(nameof(ListarUsuarios), nameof(Usuario));
        }


        //[HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult PesquisarProfissao(FormPesquisar profissao)
        {
            
            List<Usuario> model = gu.ObterTodosPorProfissao(profissao.CampoPesquisar);
            if (model.Count == 0)
                model = null;
            return View(model);
        }

    }
}