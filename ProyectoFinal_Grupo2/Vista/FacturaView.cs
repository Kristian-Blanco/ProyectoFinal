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
        public FacturaView()
        {
            InitializeComponent();
            FacturaController controlador = new FacturaController(this);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
