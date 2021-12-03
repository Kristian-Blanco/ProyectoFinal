using ProyectoFinal_Grupo2.Controladores;
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
    public partial class LoginView : Form
    {
        internal object EmailextBox;

        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
        }

        public object EmailtextBox { get; internal set; }
    }
}
