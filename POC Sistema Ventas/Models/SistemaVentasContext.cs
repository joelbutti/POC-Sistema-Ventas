using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Sistema_Ventas.Models
{
    public class SistemaVentasContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public SistemaVentasContext()
            :base("SistemaVentasContext")
        {

        }

    }
}
