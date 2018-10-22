using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MinhaPrimeiraAppMVC.Models
{
    public class TarefasInicializador : DropCreateDatabaseIfModelChanges<TarefaContexto>
    {
        protected override void Seed(TarefaContexto context)
        {
            var listas = new List<Lista>
            {
                new Lista { Id = 1, Nome = "Treinamento SEFAZ", Ativa = 1 }
            };

            listas.ForEach(s => context.Listas.Add(s));

            context.SaveChanges();

            var tarefas = new List<Tarefas>
            {
                new Tarefas { Nome = "Finalizar Material ASP.NET Core + Angular", Ativa = 1, Concluida = 0 },
                new Tarefas { Nome = "Enviar Slides da semana 1 para o apoio", Ativa = 1, Concluida = 0 },
                new Tarefas { Nome = "Carlos deixar de ser intriguento", Ativa = 1, Concluida = 0 }
            };

            tarefas.ForEach(s => context.Tarefas.Add(s));

            context.SaveChanges();

            var usuarios = new List<Usuarios>
            {
                new Usuarios { Nome = "Edson Farias", Email = "edson@edson.com", Senha = "123456", Ativo = 1}
            };

            usuarios.ForEach(s => context.Usuarios.Add(s));

            context.SaveChanges();

        }
    }
}