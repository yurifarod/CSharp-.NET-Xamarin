using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EP.CursoMvc.UI.Sistema.Models;
using EPCursoMvc.Application.ViewModels;
using EPCursoMvc.Application.Interfaces;
using EPCursoMvc.Application.Services;
using EP.CursoMvc.Infra.CrossCutting.MvcFilters;

namespace EP.CursoMvc.UI.Sistema.Controllers
{
    //Modoulo cliente - CL,CI,CE,CD,CX

    //[Authorize]
    [RoutePrefix("administrativo-filiacao")]

    public class FiliacaoController : Controller
    {
        private readonly IFiliacaoAppService _filiacaoAppService;

        public FiliacaoController(IFiliacaoAppService filiacaoAppService)
        {
            _filiacaoAppService = filiacaoAppService;   
        }
        
        //[ClaimsAuthorize("ModuloCliente", "CL")]
        [Route("listar-clientes")]
        public ActionResult Index()
        {
            return View(_filiacaoAppService.ObterTodos().ToList());
        }

        //[ClaimsAuthorize("ModuloCliente", "CD")]
        [Route("{id:guid}/detalhe-cliente")]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _filiacaoAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        //[ClaimsAuthorize("ModuloCliente", "CI")]
        [Route("novo-cliente")]
        public ActionResult Create()
        {
            return View();
        }

        //[ClaimsAuthorize("ModuloCliente", "CI")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-cliente")]
        public ActionResult Create(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                var clienteReturn = _filiacaoAppService.Adicionar(clienteEnderecoViewModel).ClienteViewModel;
                if (!clienteReturn.ValidationResult.IsValid)
                {
                    foreach(var erro in clienteReturn.ValidationResult.Erros)
                    {
                        ModelState.AddModelError(string.Empty, erro.Message);
                    }
                    return View(clienteEnderecoViewModel);
                }

                return RedirectToAction("Index");
            }

            return View(clienteEnderecoViewModel);
        }

        [ClaimsAuthorize("ModuloCliente", "CE")]
        [Route("{id:guid}/editar-cliente")]
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

        [ClaimsAuthorize("ModuloCliente", "CE")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{id:guid}/editar-cliente")]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _filiacaoAppService.Atualizar(clienteViewModel);

                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }

        [ClaimsAuthorize("ModuloCliente", "CX")]
        [Route("{id:guid}/excluir-cliente")]
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

        [ClaimsAuthorize("ModuloCliente", "CX")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("{id:guid}/excluir-cliente")]
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
