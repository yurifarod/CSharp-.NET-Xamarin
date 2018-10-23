using SEFAZ.CursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Application.Interfaces
{
    public interface IFiliacaoAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid Id);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel ObterPorCPF(string cpf);
        ClienteViewModel ObterPorNome(string nome);
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid Id);
    }
}
