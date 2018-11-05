using EP.CursoMvc.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Interfaces.Repository
{
    public interface IFiliacaoRepository : IReposity<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        IEnumerable<Cliente> ObterAtivos();
    }
}
