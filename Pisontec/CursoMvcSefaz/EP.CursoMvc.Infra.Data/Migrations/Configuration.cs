using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EP.CursoMvc.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EP.CursoMvc.Infra.Data.Context.CursoMvcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EP.CursoMvc.Infra.Data.Context.CursoMvcContext context)
        {

        }
    }
}
