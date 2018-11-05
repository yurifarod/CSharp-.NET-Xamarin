using EPCursoMvc.Application.Interfaces;
using System;
using System.Collections.Generic;
using EPCursoMvc.Application.ViewModels;
using AutoMapper;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Services;
using EP.CursoMvc.Infra.Data.UnitOfWork;

namespace EPCursoMvc.Application.Services
{
    public class FiliacaoAppService : AppService, IFiliacaoAppService
    {
        private readonly IFiliacaoService _filiacaoService;

        public FiliacaoAppService(IFiliacaoService filiacaoService, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _filiacaoService = filiacaoService;
        }

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteEnderecoViewModel.ClienteViewModel);
            var endereco = Mapper.Map<Endereco>(clienteEnderecoViewModel.EnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            var clienteReturn = _filiacaoService.Adicionar(cliente);

            if (clienteReturn.ValidationResult.IsValid) Commit();

            clienteEnderecoViewModel.ClienteViewModel = Mapper.Map<ClienteViewModel>(clienteReturn);

            return clienteEnderecoViewModel;
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteViewModel);
            var clienteReturn = _filiacaoService.Atualizar(cliente);

            return Mapper.Map<ClienteViewModel>(clienteReturn);
        }

        public void Dispose()
        {
            _filiacaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorCpf(cpf));                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorEmail(email));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ClienteViewModel>>(_filiacaoService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _filiacaoService.Remover(id);            
        }
    }
}
