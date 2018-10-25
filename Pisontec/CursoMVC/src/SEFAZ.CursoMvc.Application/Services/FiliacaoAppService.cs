using AutoMapper;
using SEFAZ.CursoMvc.Application.Interfaces;
using SEFAZ.CursoMvc.Application.ViewModels;
using SEFAZ.CursoMvc.Domain.Entities;
using SEFAZ.CursoMvc.Domain.Services;
using SEFAZ.CursoMvc.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.Services
{
    public class FiliacaoAppService : AppService, IFiliacaoAppService
    {
        private readonly IFiliacaoServices _filiacaoService;

        public FiliacaoAppService(IFiliacaoServices filiacaoService, IunitOfWork unitofWork) : base(unitofWork)
        {
            _filiacaoService = filiacaoService;
        }

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteEnderecoViewModel.ClienteViewModel);
            var endereco = Mapper.Map<Endereco>(clienteEnderecoViewModel.EnderecoViewModel);
            cliente.Enderecos.Add(endereco);

            var clienteReturn = _filiacaoService.Adicionar(cliente);
            clienteEnderecoViewModel.ClienteViewModel = Mapper.Map<ClienteViewModel>(clienteReturn);

            return clienteEnderecoViewModel;
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteViewModel);
            var clienteReturn = _filiacaoService.Adicionar(cliente);
            return Mapper.Map<ClienteViewModel>(clienteReturn);

        }

        public void Dispose()
        {
            _filiacaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorNome(nome));
        }

        public ClienteViewModel ObterPorId(Guid Id)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorId(Id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ClienteViewModel>>(_filiacaoService.ObterTodos());
        }

        public void Remover(Guid Id)
        {
            _filiacaoService.Remover(Id);
        }
    }
}
