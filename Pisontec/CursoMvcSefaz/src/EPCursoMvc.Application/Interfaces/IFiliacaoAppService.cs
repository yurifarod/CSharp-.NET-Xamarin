using EPCursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCursoMvc.Application.Interfaces
{
    public interface IFiliacaoAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);
    }
}
