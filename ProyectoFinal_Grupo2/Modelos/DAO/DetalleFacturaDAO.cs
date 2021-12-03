using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo2.Modelos.DAO
{
    public class DetalleFacturaDAO
    {
        public object Cantidad { get; internal set; }
        public object IdProducto { get; internal set; }
        public object Precio { get; internal set; }
        public object Total { get; internal set; }
    }
}
