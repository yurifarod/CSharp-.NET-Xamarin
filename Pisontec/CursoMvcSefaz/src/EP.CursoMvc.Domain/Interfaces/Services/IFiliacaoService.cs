using EP.CursoMvc.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Interfaces.Services
{
    public interface IFiliacaoService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        IEnumerable<Cliente> ObterAtivos();
        Cliente Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}
