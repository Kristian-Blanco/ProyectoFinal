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

        List<DetalleFactura> ListadetalleFactura = new List<DetalleFactura>();

        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalPagar = 0;

        public FacturaController(FacturaView view)
        {
            vista = view;

            vista.Load += new EventHandler(Load);
            vista.IdentidadmaskedTextBox.KeyPress += IdentidadMaskedTextBox_KeyPress;
            vista.BuscarClienteButton.Click += BuscarClienteButton_Click;
            //vista.NombreTextBox.Text = cliente.Nombre;
            vista.CodigoProductoTextBox.KeyPress += CodigoProductoTexBox_KeyPress;
            vista.CantidadTextBox.KeyPress += CantidadTextBox_KeyPress;
            vista.Guardarbutton.Click += GuardarButton_Click;



        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Fecha = vista.FechadateTimePicker.Value;
            factura.IdCliente = cliente.IdCliente;
            factura.IdUsuario = user.Id;
            factura.SubTotal = subTotal;
            factura.ISV = isv;
            factura.Total = Convert.ToDecimal(vista.TotaltextBox.Text);
            factura.Descuento = Convert.ToDecimal(vista.DescuentotextBox.Text);


            bool inserto = factura_DAO.InsertarNuevaFactura(factura, ListadetalleFactura);
            if (inserto)
            {
                MessageBox.Show("Factura Registrada Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Registrar la Factura");
            }

        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(e.KeyChar==(char)Keys.Enter &&  !string.IsNullOrEmpty(vista.CantidadTextBox.Text))
          {
                DetalleFactura detalleFactura = new DetalleFactura();
                detalleFactura.IdProducto = producto.IdProducto;
                detalleFactura.Cantidad = Convert.ToInt32(vista.CantidadTextBox.Text);
                detalleFactura.Precio = producto.Precio;
                detalleFactura.Total = Convert.ToDecimal(Convert.ToInt32(vista.CantidadTextBox.Text) * producto.Precio);

                subTotal += detalleFactura.Total;
                isv = subTotal * 0.15M;
                totalPagar = subTotal + isv;

                ListadetalleFactura.Add(detalleFactura);
                vista.DetalleDataGridView.DataSource = null;
                vista.DetalleDataGridView.DataSource = ListadetalleFactura;

                vista.SubtotaltextBox.Text = subTotal.ToString("N2");
                vista.ImpuestotextBox.Text = isv.ToString("N2");
                vista.TotaltextBox.Text =totalPagar.ToString("N2");
          }

        }

        private void CodigoProductoTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                producto= productoDAO.GetProductoPorCodigo(vista.CodigoProductoTextBox.Text);
                vista.DescripcionProductoTextBox.Text = producto.Descripcion;
            }



            else
            {
                producto = null;
                vista.DescripcionProductoTextBox.Clear();
            }
        }

        private void IdentidadMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
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

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClienteView form = new BuscarClienteView();
            form.ShowDialog();
            cliente = form._cliente;
            vista.IdentidadmaskedTextBox.Text = cliente.Identidad;
            vista.NombreTextBox.Text = cliente.Nombre;
        }
        private void Load(object sender, EventArgs e)
        {
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.UsuariotextBox.Text = user.Nombre;
        }


    }





}
    

        





