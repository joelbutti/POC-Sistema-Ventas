using POC_Sistema_Ventas.Forms.Productos;
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

namespace POC_Sistema_Ventas
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(0);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(1);
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(2);
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(3);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(4);
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(5);
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            TcPrinc.SelectTab(6);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            SisVentasRepositorio conexion = new SisVentasRepositorio();

            DgvProductos.DataSource = conexion.ListarProductos().ToList();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarProducto ventana = new FrmAgregarEditarProducto();
            ventana.ShowDialog();
            Cargar();
        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = DgvProductos.SelectedRows[0].DataBoundItem as Producto;
            FrmEditarProducto ventana = new FrmEditarProducto(productoSeleccionado);
            ventana.ShowDialog();
            Cargar();
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count > 0)
            {
                Producto productoSeleccionado = DgvProductos.SelectedRows[0].DataBoundItem as Producto;


                DialogResult resultado = MessageBox.Show($"Seguro que quieres eliminar {productoSeleccionado.Nombre} {productoSeleccionado.Descripcion}?", "Eliminar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    Producto nuevo = new Producto();
                    SisVentasRepositorio conexion = new SisVentasRepositorio();

                    conexion.EliminarProductos(productoSeleccionado);

                    Cargar();
                }
            }
        }
    }
}
