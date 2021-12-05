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
    public class ClienteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoCliente(Cliente cliente)
        {
            
            bool inserto = false;
            
            try
            {
                
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE");
                sql.Append(" VALUES (@Identidad, @Nombre, @Email, @Direccion, @Foto); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 70).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = cliente.Direccion;
                if (cliente.Foto != null)
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = cliente.Foto;
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

        public DataTable GetClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT *  FROM CLIENTE ");

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
            }
            return dt;

        }

        public bool ActualizarCliente(Cliente cliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append("SET IDENTIDAD = @Identidad, NOMBRE = @Nombre, EMAIL = @Email, DIRECCION = @Direccion, FOTO = @Foto  ");
                sql.Append(" WHERE IDCLIENTE = @IdCliente ;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                //comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 70).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = cliente.Direccion;
                if (cliente.Foto != null)
                {
                    comando.Parameters.Add("@Foto", SqlDbType.Image).Value = cliente.Foto;
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

        public bool EliminarUsuario(int idCliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
                sql.Append(" WHERE IDCLIENTE = @IdCliente; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
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
        public byte[] SeleccionarImagenCliente(int idCliente)
        {
            byte[] _imagen = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT FOTO FROM CLIENTE ");
                sql.Append(" WHERE IDCLIENTE = @IdCliente; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
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
        public Cliente GetClientePorIdentidad(string identidad)
        {
            Cliente cliente = new Cliente();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT *  FROM CLIENTE ");
                sql.Append("WHERE IDENTIDAD = @Identidad;");

                comando.Connection = MiConexion;
                MiConexion.Open(); 
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = identidad;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    cliente.IdCliente = (int)dr["IDCLIENTE"];
                    cliente.Identidad = (string)dr["IDENTIDAD"];
                    cliente.Nombre = (string)dr["NOMBRE"];
                    cliente.Email = (string)dr["EMAIL"];
                    cliente.Direccion = (string)dr["DIRECCION"];


                }

                MiConexion.Close();

            }
            catch (Exception ex)
            {
                MiConexion.Close();
            }
            return cliente;



        }

        public DataTable GetClientesPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE WHERE NOMBRE LIKE (' % " + nombre + "%')");

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
            }
            return dt;
        }       

    }
}
