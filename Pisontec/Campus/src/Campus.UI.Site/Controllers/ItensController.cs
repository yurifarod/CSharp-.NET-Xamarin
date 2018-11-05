using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Campus.Application.Interfaces;
using Campus.Application.Services;
using Campus.Application.ViewModels;
using Campus.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Campus.UI.Site.Controllers
{
    public class ItensController : BaseController
    {
       
        private readonly IItensAppService _itensAppService;

        public ItensController(IItensAppService itensAppService,
            INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _itensAppService = itensAppService;
        }

        public IActionResult ListarItens(Guid id)
        {
            var lista = _itensAppService.GetItensPedido(id);
            ViewBag.Pedido = id;
            return PartialView(lista);
        }


        public IActionResult SalvarItens(int quantidade
            , string produto
            , int valorunitario
            , Guid idPedido)
        {

            var item = new ItensViewModel()
            {

                Quantidade = quantidade
                ,
                Produto = produto
                ,
                ValorUnitario = valorunitario
                ,
                PedidoId = idPedido
            };

            _itensAppService.Register(item);
            

            return Json(new { Resultado = item.Id });
        }
    }
}