using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEFAZ.CursoMvc.Domain.Entities;
using SEFAZ.CursoMvc.Domain.Interfaces.Repository;

namespace SEFAZ.CursoMvc.Domain.Services
{
    class FiliacaoService : IFiliacaoServices
    {
        private readonly IFiliacaoRepository _filiacaoRepository;

        public FiliacaoService(IFiliacaoRepository filiacaoRepository)
        {
            _filiacaoRepository = filiacaoRepository;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            return _filiacaoRepository.Adicionar(cliente);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            return _filiacaoRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _filiacaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _filiacaoRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorId(Guid Id)
        {
            return _filiacaoRepository.ObterPorId(Id);
        }

        public Cliente ObterPorNome(string nome)
        {
            return _filiacaoRepository.ObterPorNome(nome);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _filiacaoRepository.ObterTodos();
        }

        public void Remover(Guid Id)
        {
            _filiacaoRepository.Remover(Id);
        }
    }
}
