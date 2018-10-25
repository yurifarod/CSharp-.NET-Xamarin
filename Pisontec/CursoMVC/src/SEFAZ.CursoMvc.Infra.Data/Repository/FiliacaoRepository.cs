using SEFAZ.CursoMvc.Domain.Entities;
using SEFAZ.CursoMvc.Domain.Interfaces.Repository;
using SEFAZ.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMvc.Infra.Data.Repository
{
    public class FiliacaoRepository : Repository<Cliente>, IFiliacaoRepository
    {
        public FiliacaoRepository(CursoMvcContext contexto) : base(contexto)
        {

        }
        public IEnumerable<Cliente> ObterAtivos()
        {
            return Buscar(c => c.Ativo);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();

        }

        public Cliente ObterPorNome(string nome)
        {
            return Buscar(c => c.Nome == nome).FirstOrDefault();
        }
    }
}
