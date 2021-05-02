using POC_Sistema_Ventas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Sistema_Ventas
{
    public class SisVentasRepositorio
    {

        private SistemaVentasContext context = new SistemaVentasContext();

        public DbSet<Producto> ListarProductos()
        {



            DbSet<Producto> listaProductos = context.Productos;

            return listaProductos;

        }

        public DbSet<Categoria> ListarCategorias()
        {



            DbSet<Categoria> listaCategorias = context.Categorias;

            return listaCategorias;

        }

        public Categoria BuscarCategoria(int id)
        {
            return context.Categorias.Find(id);
        }

        public void AgregarProductos(Producto prod)
        {
            context.Productos.Add(prod);
            context.SaveChanges();
        }

        public void ModificarProductos(Producto prod)
        {

            context.Entry(prod).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void EliminarProductos(Producto prod)
        {

            Producto eliminar = context.Productos.Find(prod.Id);
            //context.Entry(prod).State = EntityState.Deleted;
            context.Productos.Remove(eliminar);
            context.SaveChanges();
        }
    }
}
