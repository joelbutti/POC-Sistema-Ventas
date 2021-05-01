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
    }
}
