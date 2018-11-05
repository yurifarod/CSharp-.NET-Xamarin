using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Campus.Application.ViewModels;
using Campus.Infra.CrossCutting.Identity.Data;
using Campus.Application.Interfaces;
using MediatR;
using Campus.Domain.Core.Notifications;

namespace Campus.UI.Site.Controllers
{
    public class PedidosController : BaseController
    {
        private readonly IPedidoAppService _pedidoAppService;

        public PedidosController(IPedidoAppService pedidoAppService,
            INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _pedidoAppService = pedidoAppService;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            return View(_pedidoAppService.GetAll());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var pedidoViewModel = await _context.Pedidos
            //    .SingleOrDefaultAsync(m => m.Id == id);

            var pedidoViewModel =  _pedidoAppService.GetById(id.Value);

            if (pedidoViewModel == null)
            {
                return NotFound();
            }

            return View(pedidoViewModel);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PedidoViewModel pedidoViewModel)
        {
            if (!ModelState.IsValid) return View(pedidoViewModel);
            _pedidoAppService.Register(pedidoViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Pedido Adicionado!";

            return View(pedidoViewModel);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pedidoViewModel = _pedidoAppService.GetById(id.Value);
            //var pedidoViewModel = await _context.Pedidos.SingleOrDefaultAsync(m => m.Id == id);
            if (pedidoViewModel == null)
            {
                return NotFound();
            }
            return View(pedidoViewModel);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id,PedidoViewModel pedidoViewModel)
        {
            if (id != pedidoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _pedidoAppService.Update(pedidoViewModel);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoViewModelExists(pedidoViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pedidoViewModel);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
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

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _pedidoAppService.Remove(id);

            if (!IsValidOperation()) return View(_pedidoAppService.GetById(id));
            return RedirectToAction(nameof(Index));
        }


    }
}
