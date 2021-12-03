using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo2.Vista
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        ClienteView vistaCliente;
        ProductoView vistaProducto;
        FacturaView vistaFactura;

        public string EmailUsuario { get; internal set; }

        private void ClienteToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaCliente == null)
            {
                vistaCliente = new ClienteView();
                vistaCliente.MdiParent = this;
                vistaCliente.FormClosed += Vista_FormClosed;
                vistaCliente.Show();
            }
           
        }

        private void ProductoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaProducto == null)
            {
                vistaProducto = new ProductoView();
                vistaProducto.MdiParent = this;
                vistaProducto.FormClosed += Vista_FormClosed1;
                vistaProducto.Show();
            }
        }

        private void FacturaToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaFactura == null)
            {
                vistaFactura = new FacturaView();
                vistaFactura.MdiParent = this;
                vistaFactura.FormClosed += Vista_FormClosed2;
                vistaFactura.EmailUsuario = EmailUsuario;
                vistaFactura.Show();
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaCliente = null;
        }

        private void Vista_FormClosed1(object sender, FormClosedEventArgs e)
        {
            vistaProducto = null;
        }

        private void Vista_FormClosed2(object sender, FormClosedEventArgs e)
        {
            vistaFactura = null;
        }


    }
}
