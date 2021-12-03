using ProyectoFinal_Grupo2.Modelos.DAO;
using ProyectoFinal_Grupo2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo2.Vista
{
    public partial class BuscarClienteView : Form
    {
        public BuscarClienteView()
        {
            InitializeComponent();
        }
        ClienteDAO clienteDAO = new ClienteDAO();
        public Cliente _cliente = new Cliente();
        private void BuscarClienteView_Load(object sender, EventArgs e)
        {
            ClientedataGridView.DataSource = clienteDAO.GetClientes();
        }

        private void NombreClienteTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ClientedataGridView.DataSource = clienteDAO.GetClientesPorNombre(NombreClienteTextBox.Text);
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if(ClientedataGridView.RowCount> 0)
            {
                if (ClientedataGridView.SelectedRows.Count > 0)
                {
                    _cliente.IdCliente = (int)ClientedataGridView.CurrentRow.Cells["ID"].Value;
                    _cliente.Identidad = ClientedataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                    _cliente.Nombre = ClientedataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    this.Close();
                }
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
