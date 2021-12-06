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

        internal bool InsertarNuevoProducto(Producto producto)
        {
            //throw new NotImplementedException();
            bool inserto = false;

            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO PRODUCTO ");
                sql.Append(" VALUES (@Codigo, @Descripcion, @Existencia, @Precio, @Foto); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = producto.Codigo;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 70).Value = producto.Descripcion;
                comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = producto.Existencia;
                comando.Parameters.Add("@Precio", SqlDbType.Int).Value = producto.Precio;

                if (producto.Foto != null)
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = producto.Foto;
                }
                else
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = DBNull.Value;
                }
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }

        internal bool EliminarUsuario(int v)
        {
            throw new NotImplementedException();
        }

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

        public bool ActualizarProducto(Producto producto)
        {
            bool modifico = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE PRODUCTO ");
                sql.Append("SET CODIGO = @Codigo, DESCRIPCION = @Descripcion, EXISTENCIA = @Existencia, PRECIO = @Precio, FOTO = @Foto  ");
                sql.Append(" WHERE IDPRODUCTO = @IdProducto ;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                //comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = cliente.IdCliente;
                comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = producto.Codigo;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 70).Value = producto.Descripcion;
                comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = producto.Existencia;
                comando.Parameters.Add("@Precio", SqlDbType.Int).Value = producto.Precio;
                if (producto.Foto != null)
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = producto.Foto;
                }
                else
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = DBNull.Value;
                }
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }


        public byte[] SeleccionarImagenProducto(int idProducto)
        {
            byte[] _imagen = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT FOTO FROM PRODUCTO ");
                sql.Append(" WHERE IDPRODUCTO = @IdProducto; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    _imagen = (byte[])dr["FOTO"];
                }

                MiConexion.Close();

            }
            catch (Exception)
            {

            }
            return _imagen;
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

  
  

 
    }
}