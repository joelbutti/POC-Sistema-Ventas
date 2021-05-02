using POC_Sistema_Ventas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POC_Sistema_Ventas.Forms.Productos
{
    public partial class FrmAgregarEditarProducto : Form
    {
        private Categoria categoria = null;
        public FrmAgregarEditarProducto()
        {
            InitializeComponent();
        }

        private void FrmAgregarEditarProducto_Load(object sender, EventArgs e)
        {
            SisVentasRepositorio context = new SisVentasRepositorio();

            List<Categoria> listaCategorias = context.ListarCategorias().ToList();

            foreach (var item in listaCategorias)
            {
                CbCategoria.Items.Add(item.Nombre);
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto();
            SisVentasRepositorio conexion = new SisVentasRepositorio();


            nuevo.Nombre = TbNombre.Text;
            nuevo.Descripcion = TbDescripcion.Text;
            nuevo.Stock = int.Parse(TbStock.Text);
            nuevo.Precio = double.Parse(TbPrecio.Text);

            if (CbCategoria.SelectedItem.Equals("Almacen"))
            {
                nuevo.CategoriaId = 1;
                
            }else if(CbCategoria.SelectedItem.Equals("Ferreteria"))
            {
                nuevo.CategoriaId = 2;
            }
            else if (CbCategoria.SelectedItem.Equals("Limpieza"))
            {
                nuevo.CategoriaId = 3;
            }

            nuevo.Categoria=conexion.BuscarCategoria(nuevo.CategoriaId);
            conexion.AgregarProductos(nuevo);

            Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
