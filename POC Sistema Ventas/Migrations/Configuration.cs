namespace POC_Sistema_Ventas.Migrations
{
    using POC_Sistema_Ventas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<POC_Sistema_Ventas.Models.SistemaVentasContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(POC_Sistema_Ventas.Models.SistemaVentasContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            IList<Categoria> defaultStandards = new List<Categoria>();

            defaultStandards.Add(new Categoria() { Id = 1, Nombre = "Almacen" });
            defaultStandards.Add(new Categoria() { Id = 2, Nombre = "Ferreteria" });
            defaultStandards.Add(new Categoria() { Id = 3, Nombre = "Limpieza" });

            context.Categorias.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}
