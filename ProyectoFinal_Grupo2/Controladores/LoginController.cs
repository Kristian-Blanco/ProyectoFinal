using ProyectoFinal_Grupo2.Modelos.DAO;
using ProyectoFinal_Grupo2.Modelos.Entidades;
using ProyectoFinal_Grupo2.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo2.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;

            vista.Aceptarbutton.Click += new EventHandler(ValidarUsuario);
            vista.Cancelarbutton.Click += new EventHandler(Cerrar);
        }

        private void Cerrar(object serder, EventArgs e)
        {
            vista.Close();
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Email = vista.EmailTextbox.Text;
            user.Clave = EncriptarClave(vista.ContraseniatextBox.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");

                //MenuView menu = new MenuView();
                //vista.Hide();

                //menu.EmailUsuario = user.Email;

                //menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}

