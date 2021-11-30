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
        Producto producto = new Producto();
        ProductoDAO productoDAO = new ProductoDAO();

        public FacturaController(FacturaView view)
        {
            vista = view;
            vista.CodigoProductoTextBox_KeyPress;
        }
        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = productoDAO.GetProductoPorCodigo(vista.CodigoProductoTextBox.Text);

                vista.DescripcionProductoTextBox.Text = producto.Descripcion;
            }
            else
            {
                producto = null;
                vista.DescripcionProductoTextBox.Clear();
            }
        }


    }
}
