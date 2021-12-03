using ProyectoFinal_Grupo2.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_Grupo2.Modelos.DAO;
using ProyectoFinal_Grupo2.Modelos.Entidades;


namespace ProyectoFinal_Grupo2.Controladores
{
    public class FacturaController
    {
        FacturaView vista;
        Factura_DAO factura_DAO = new Factura_DAO();
        Factura factura = new Factura();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        Producto producto = new Producto();
        ProductoDAO productoDAO = new ProductoDAO();
        public string _EmailUsuario;
        Usuario user = new Usuario();


        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalPagar = 0;

        public FacturaController(FacturaView view)
        {
            vista = view;
            
             vista.Load += new EventHandler(Load);
            vista.IdentidadmaskedTextBox.KeyPress += IdentidadmaskedTextBox_KeyPress;



        }

        private void IdentidadmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter);
            {
                cliente = clienteDAO.GetClientePorIdentidad(vista.IdentidadmaskedTextBox.Text);
                vista.NombreTextBox.Text = cliente.Nombre;
            }

            else
            {
                cliente = null;
                vista.NombreTextBox.Clear();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.UsuariotextBox.Text = user.Nombre;
        }
       














    }
}
        





