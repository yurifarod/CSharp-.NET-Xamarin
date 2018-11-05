using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Campus.Application.Interfaces;
using Campus.Application.ViewModels;
using Campus.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Campus.UI.Site.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly IPedidoAppService _pedidoAppService;
        private readonly IClienteAppService _clienteAppService;
        public PedidoController(IPedidoAppService pedidoAppService, IClienteAppService clienteAppService,
            INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _pedidoAppService = pedidoAppService;
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_pedidoAppService.GetAll());
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoViewModel = _pedidoAppService.GetById(id.Value);

            if (pedidoViewModel == null)
            {
                return NotFound();
            }

            return View(pedidoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Cliente = new SelectList
            (
                _clienteAppService.GetAll(), "Id", "Nome"
            );

            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Create(PedidoViewModel pedidoViewModel)
        {


            if (!ModelState.IsValid) return View(pedidoViewModel);
            _pedidoAppService.Register(pedidoViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Pedido Adicionado!";

            //return View(pedidoViewModel);
            return Json(new { Resultado = pedidoViewModel.Id });
        }

        [HttpGet]

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoViewModel = _pedidoAppService.GetById(id.Value);

            if (pedidoViewModel == null)
            {
                return NotFound();
            }

            return View(pedidoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PedidoViewModel pedidoViewModel)
        {
            if (!ModelState.IsValid) return View(pedidoViewModel);

            _pedidoAppService.Update(pedidoViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Pedido Atualizado!";

            return View(pedidoViewModel);
        }

        [HttpGet]

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoViewModel = _pedidoAppService.GetById(id.Value);

            if (pedidoViewModel == null)
            {
                return NotFound();
            }

            return View(pedidoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _pedidoAppService.Remove(id);

            if (!IsValidOperation()) return View(_pedidoAppService.GetById(id));

            ViewBag.Sucesso = "Pedido Removido!";
            return RedirectToAction("Index");
        }
    }
}