using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Entidades;

namespace TPI.AccesoADatos
{
    class AD_Varios
    {
        public static bool AgregarPaisABD(Pais p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertPais";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePais", p.NombreDelPais);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al Agregar Pais a la BD!");
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static DataTable ObtenerListadoPais()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoPais";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool ActualizarPaisABD(Pais p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarPais";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", p.IdDelPais);
                cmd.Parameters.AddWithValue("@nombre", p.NombreDelPais);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static Pais ObtenerPais(int idPais)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Pais p = new Pais();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPais";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", idPais);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.IdDelPais = dr["IdPais"].ToString();
                    p.NombreDelPais = dr["Nombre"].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del País");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static bool EliminarPaisABD(Pais p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarPais";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", p.IdDelPais);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static DataTable ObtenerListadoProvincia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoProvincia";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerPaises()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoPais";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarProvinciaABD(Provincia p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreProvincia", p.NombreDeLaProvincia);
                cmd.Parameters.AddWithValue("@idPais", p.IdDelPais);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar provincia en la BD.");
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarProvinciaABD(Provincia p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", p.IdDeLaProvincia);
                cmd.Parameters.AddWithValue("@nombre", p.NombreDeLaProvincia);
                cmd.Parameters.AddWithValue("@idPais", p.IdDelPais);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static Provincia ObtenerProvincia(int idProvincia)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Provincia p = new Provincia();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.IdDeLaProvincia = dr["IdProvincia"].ToString();
                    p.NombreDeLaProvincia = dr["Nombre"].ToString();
                    p.IdDelPais = dr["IdPais"].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos de la Provincia");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static bool EliminarProvinciaABD(Provincia p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", p.IdDeLaProvincia);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static DataTable ObtenerTipoDocumentos()
        {
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetTiposDocumento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerCiudades()
        {
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCiudades";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
