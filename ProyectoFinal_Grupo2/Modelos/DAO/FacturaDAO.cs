using ProyectoFinal_Grupo2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo2.Modelos.DAO
{
     public class Factura_DAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();

        

        public bool InsertarNuevaFactura(Factura factura)
        {
            bool inserto = false;
            MiConexion.Close();
            comando.Connection = MiConexion;
            MiConexion.Open();

            SqlTransaction transaction = MiConexion.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO FACTURA ");
                sql.Append(" VALUES (@Fecha, @IdCliente, @SubTotal, @ISV, @Descuento, @Total, @IdUsuario); ");
                sql.Append(" SELECT SCOPE_IDENTITY() ");

              
                comando.Transaction = transaction;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = factura.Fecha;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = factura.IdCliente;
                comando.Parameters.Add("@SubTotal", SqlDbType.Decimal).Value = factura.SubTotal;
                comando.Parameters.Add("@ISV", SqlDbType.Decimal).Value = factura.ISV;
                comando.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = factura.Descuento;
                comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = factura.Total;
                comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = factura.IdUsuario;

                int IdFactura = Convert.ToInt32(comando.ExecuteScalar());

               
                transaction.Commit();
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                inserto = false;
                transaction.Rollback();
            }
            return inserto;
        }
    }
}
