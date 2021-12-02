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
    public partial class FacturaView : Form
    {
        internal object UsuarioTextBo;

        public FacturaView()
        {
            InitializeComponent();
            FacturaController controlador = new FacturaController(this);
        }

        public object IdentidadMaskedTextBox { get; internal set; }
        public object UsuarioTextBox { get; internal set; }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
