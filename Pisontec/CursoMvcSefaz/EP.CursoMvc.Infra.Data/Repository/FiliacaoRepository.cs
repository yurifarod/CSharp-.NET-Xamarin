using Dapper;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class FiliacaoRepository : Repository<Cliente>, IFiliacaoRepository
    {
        public FiliacaoRepository(CursoMvcContext contexto) : base(contexto) { }

        public IEnumerable<Cliente> ObterAtivos()
        {
            return Buscar(c => c.Ativo);
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF.Numero == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email.Endereco == email).FirstOrDefault();
        }

        public override void Remover(Guid Id)
        {
            var cliente = ObterPorId(Id);
            cliente.Ativo = false;
            Atualizar(cliente);
        }

        //public override IEnumerable<Cliente> ObterTodos()
        //{
        //    var cn = db.Database.Connection;

        //    var sql = "select * from Sistema.Clientes";

        //    return cn.Query<Cliente>(sql);
        //}

        //public override Cliente ObterPorId(Guid id)
        //{
        //    var cn = db.Database.Connection;

        //    var sql = @"select * from Sistema.Clientes c " +
        //               "left join Sistema.Enderecos e " +
        //               "on c.ClienteId = e.ClienteId " +
        //               "where c.ClienteId = @sid";

        //    var cliente = cn.Query<Cliente, Endereco, Cliente>(sql, (c, e) =>
        //    {
        //        c.Enderecos.Add(e);
        //        return c;
        //    }, new { sid = id }, splitOn: "ClienteId, EnderecoId");

        //    return cliente.FirstOrDefault();
        //}
    }
}
