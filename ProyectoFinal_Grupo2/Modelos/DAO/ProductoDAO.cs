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
    public class ProductoDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();

        public DataTable GetProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM PRODUCTO ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
                MiConexion.Close();
            }
            return dt;
        }
        public DataTable GetProductosPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM PRODUCTO WHERE NOMBRE LIKE ('%" + codigo + "%') ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
                MiConexion.Close();
            }
            return dt;
        }

        internal bool EliminarUsuario(int v)
        {
            throw new NotImplementedException();
        }

        internal Producto GetProductoPorIdentidad(string text)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoPorCodigo(string codigo)
        {
            Producto producto = new Producto();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM PRODUCTO ");
                sql.Append(" WHERE CODIGO = @Codigo; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = codigo;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    producto.IdProducto = (int)dr["IDPRODUCTO"];
                    producto.Codigo = (string)dr["CODIGO"];
                    producto.Descripcion = (string)dr["DESCRIPCION"];
                    producto.Existencia = (int)dr["EXISTENCIA"];
                    producto.Precio = (decimal)dr["PRECIO"];
                }

                MiConexion.Close();

            }
            catch (Exception ex)
            {
                MiConexion.Close();
            }
            return producto;
        }

        internal byte[] SeleccionarImagenProducto(int v)
        {
            throw new NotImplementedException();
        }

        internal bool ActualizarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        internal bool InsertarNuevoProducto(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}