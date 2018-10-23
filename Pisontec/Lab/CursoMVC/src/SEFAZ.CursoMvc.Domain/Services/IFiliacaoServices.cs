using SEFAZ.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Domain.Services
{
    public interface IFiliacaoServices : IDisposable
    {
        Cliente Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid Id);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorNome(string nome);
        Cliente Atualizar(Cliente cliente);
        void Remover(Guid Id);
    }
}
