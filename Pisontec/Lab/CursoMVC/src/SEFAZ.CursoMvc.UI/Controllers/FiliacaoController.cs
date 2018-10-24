using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEFAZ.CursoMvc.Application.Interfaces;
using SEFAZ.CursoMvc.Application.ViewModels;
using SEFAZ.CursoMvc.UI.Models;

/*A classe foi alterada para usar os contextos de banco de dados criados na nosas camada de aplicação (ViewModel)*/
namespace SEFAZ.CursoMvc.UI.Controllers
{
    public class FiliacaoController : Controller
    {
        private readonly IFiliacaoAppService _filiacaoAppService;

        public FiliacaoController(IFiliacaoAppService filiacaoAppService)
        {
            _filiacaoAppService = filiacaoAppService;
        }

        // GET: Filiacao
        public ActionResult Index()
        {
            return View(_filiacaoAppService.ObterTodos().ToList());
        }

        // GET: Filiacao/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = _filiacaoAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // GET: Filiacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filiacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                var clienteReturn = _filiacaoAppService.Adicionar(clienteEnderecoViewModel).ClienteViewModel;
                return RedirectToAction("Index");
            }

            return View(clienteEnderecoViewModel);
        }

        // GET: Filiacao/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = _filiacaoAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // POST: Filiacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _filiacaoAppService.Atualizar(clienteViewModel);
                
                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }

        // GET: Filiacao/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = _filiacaoAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // POST: Filiacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _filiacaoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _filiacaoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
