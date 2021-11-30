using ProyectoFinal_Grupo2.Modelos.DAO;
using ProyectoFinal_Grupo2.Modelos.Entidades;
using ProyectoFinal_Grupo2.Vista;
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
    public class ClienteController
    {
        ClienteView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;
          

        public ClienteController(ClienteView view)
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
            cliente = null;
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = clienteDAO.EliminarUsuario(Convert.ToInt32(vista.ClientesDataGridView.CurrentRow.Cells["IDCLIENTE"].Value));
                if (elimino)
                {
                    MessageBox.Show("Cliente eliminado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("Cliente no se pudo eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
          
        }

        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ClientesDataGridView.DataSource = clienteDAO.GetClientes();
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();

                vista.IdTextBox.Text = vista.ClientesDataGridView.CurrentRow.Cells["IDCLIENTE"].Value.ToString();
                vista.IdentidadMaskedTextBox.Text = vista.ClientesDataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                vista.NombreTextBox.Text = vista.ClientesDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.EmailTextBox.Text = vista.ClientesDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.DireccionTextBox.Text = vista.ClientesDataGridView.CurrentRow.Cells["DIRECCION"].Value.ToString();

                byte[] img = clienteDAO.SeleccionarImagenCliente(Convert.ToInt32(vista.ClientesDataGridView.CurrentRow.Cells["IDCLIENTE"].Value));

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
            if (vista.IdentidadMaskedTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdentidadMaskedTextBox, "Ingrese una identidad");
                vista.IdentidadMaskedTextBox.Focus();
                return;
            }
            if (vista.NombreTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreTextBox, "Ingrese un nombre");
                vista.NombreTextBox.Focus();
                return;
            }
            if (vista.EmailTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailTextBox, "Ingrese un email");
                vista.EmailTextBox.Focus();
                return;
            }
            if (vista.DireccionTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DireccionTextBox, "Ingrese unu dirección");
                vista.DireccionTextBox.Focus();
                return;
            }
            try
            {
                cliente.Identidad = vista.IdentidadMaskedTextBox.Text;
                cliente.Nombre = vista.NombreTextBox.Text;
                cliente.Email = vista.EmailTextBox.Text;
                cliente.Direccion = vista.DireccionTextBox.Text;

                if (vista.ImagenPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    vista.ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cliente.Foto = ms.GetBuffer();
                }


                if (operacion == "Nuevo")
                {
                    bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Cliente creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no se pudo insertar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacion == "Modificar")
                {
                    cliente.IdCliente = Convert.ToInt32(vista.IdTextBox.Text);
                    bool modifico = clienteDAO.ActualizarCliente(cliente);
                    if (modifico)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Cliente modificado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
            
                    }
                    else
                    {
                        MessageBox.Show("Cliente no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
           
            }
            catch (Exception)
            {
            }

        }
        private void HabilitarControles()
        {
            vista.IdentidadMaskedTextBox.Enabled = true;
            vista.NombreTextBox.Enabled = true;
            vista.DireccionTextBox.Enabled = true;
            vista.EmailTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ImagenButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.IdentidadMaskedTextBox.Enabled = false;
            vista.NombreTextBox.Enabled = false;
            vista.DireccionTextBox.Enabled = false;
            vista.EmailTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ImagenButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.IdentidadMaskedTextBox.Clear();
            vista.NombreTextBox.Clear();
            vista.DireccionTextBox.Clear();
            vista.EmailTextBox.Clear();
            vista.ImagenPictureBox.Image = null;
        }
        
        
    }

}

