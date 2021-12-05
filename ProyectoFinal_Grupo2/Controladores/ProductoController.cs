using ProyectoFinal_Grupo2.Vista;
using ProyectoFinal_Grupo2.Modelos.DAO;
using ProyectoFinal_Grupo2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo2.Controladores
{
    public class ProductoController
    {
        ProductoView vista;
        ProductoDAO productoDAO = new ProductoDAO();
        Producto producto = new Producto();
        string operacion = string.Empty;


        public ProductoController(ProductoView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.ImagenButton.Click += new EventHandler(Imagen);
            vista.ModificarButton.Click += new EventHandler(Modificar);
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
            vista.CancelarButton.Click += new EventHandler(Cancelar);

        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
            producto = null;
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.ProductosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = productoDAO.EliminarUsuario(Convert.ToInt32(vista.ProductosDataGridView.CurrentRow.Cells["IDPRODUCTO"].Value));
                if (elimino)
                {
                    MessageBox.Show("Producto eliminado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no se pudo eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            vista.ProductosDataGridView.DataSource = productoDAO.GetProductos();
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (vista.ProductosDataGridView.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();

                vista.IdTextBox.Text = vista.ProductosDataGridView.CurrentRow.Cells["IDPRODUCTO"].Value.ToString();
                vista.CodigoProductoTextBox.Text = vista.ProductosDataGridView.CurrentRow.Cells["CODIGO"].Value.ToString();
                vista.DescripcionTextBox.Text = vista.ProductosDataGridView.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                vista.ExistenciaTextBox.Text = vista.ProductosDataGridView.CurrentRow.Cells["EXISTENCIA"].Value.ToString();
                vista.PrecioTextBox.Text = vista.ProductosDataGridView.CurrentRow.Cells["PRECIO"].Value.ToString();


                byte[] img = productoDAO.SeleccionarImagenProducto(Convert.ToInt32(vista.ProductosDataGridView.CurrentRow.Cells["IDPRODUCTO"].Value));

                if (img.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    vista.ImagenPictureBox.Image = Bitmap.FromStream(ms);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }

        }


        private void Imagen(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                vista.ImagenPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";

        }

        private void Guardar(object sender, EventArgs e)
        {

            //if (vista.CodigoProductoTextBox.Text == "")
            //{
            //    vista.errorProvider1.SetError(vista.CodigoProductoTextBox, "Ingrese una Codigo");
            //    vista.CodigoProductoTextBox.Focus();
            //    return;              
            //}  
            //if (vista.DescripcionTextBox.Text == "")
            //{
            //    vista.errorProvider1.SetError(vista.DescripcionTextBox, "Ingrese una descripcion");
            //    vista.DescripcionTextBox.Focus();
            //    return;               
            //}
            //if (vista.PrecioTextBox.Text == "")
            //{
            //    vista.errorProvider1.SetError(vista.PrecioTextBox, "Ingrese un precio");
            //    vista.PrecioTextBox.Focus();
            //    return;
            //} 

            
            try
            {
                producto.IdProducto = Convert.ToInt32(vista.IdTextBox.Text);
                producto.Codigo = vista.CodigoProductoTextBox.Text;
                producto.Descripcion = vista.DescripcionTextBox.Text;
                producto.Existencia = Convert.ToInt32(vista.ExistenciaTextBox.Text);
                producto.Precio = Convert.ToDecimal(vista.PrecioTextBox.Text);

                if (vista.ImagenPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    vista.ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    producto.Foto = ms.GetBuffer();
                }


                if (operacion == "Nuevo")
                {
                    bool inserto = productoDAO.InsertarNuevoProducto(producto);
                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Producto agregado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProductos();
                    }
                    else
                    {
                        MessageBox.Show("El producto no se pudo insertar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacion == "Modificar")
                {
                    producto.IdProducto = Convert.ToInt32(vista.IdTextBox.Text);
                    bool modifico = productoDAO.ActualizarProducto(producto);
                    if (modifico)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Producto modificado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProductos();

                    }
                    else
                    {
                        MessageBox.Show("El producto no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
            }

        }
        private void HabilitarControles()
        {
            vista.CodigoProductoTextBox.Enabled = true;
            vista.DescripcionTextBox.Enabled = true;
            vista.ExistenciaTextBox.Enabled = true;
            vista.PrecioTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ImagenButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.CodigoProductoTextBox.Enabled = false;
            vista.DescripcionTextBox.Enabled = false;
            vista.ExistenciaTextBox.Enabled = false;
            vista.PrecioTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ImagenButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.CodigoProductoTextBox.Clear();
            vista.DescripcionTextBox.Clear();
            vista.ExistenciaTextBox.Clear();
            vista.PrecioTextBox.Clear();
            vista.ImagenPictureBox.Image = null;
        }


    }
}
