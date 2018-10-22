namespace MinhaPrimeiraAppMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MinhaPrimeiraAppMVC.Models.TarefaContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MinhaPrimeiraAppMVC.Models.TarefaContexto";
        }

        protected override void Seed(MinhaPrimeiraAppMVC.Models.TarefaContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
