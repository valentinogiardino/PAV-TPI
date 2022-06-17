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
    public class AD_Ciudades
    {
        public static DataTable ObtenerListadoCiudades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
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

        public static bool InsertarCiudadABD(Ciudad c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevaCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", c.NombreCiudad);
                cmd.Parameters.AddWithValue("@idProvincia", c.IdProvinciaCiudad);
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
        // INSERTA UN NUEVO OBJETO CIUDAD EN LA BD

        public static Ciudad ObtenerCiudad(int idCiudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Ciudad c = new Ciudad();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCiudadId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCiudad", idCiudad);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    c.IdCiudad = int.Parse(dr["idCiudad"].ToString());
                    c.NombreCiudad = dr["nombre"].ToString();
                    c.IdProvinciaCiudad = int.Parse(dr["idProvincia"].ToString());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos de la Ciudad");
            }
            finally
            {
                cn.Close();
            }
            return c;
        }
        // CREA UN NUEVO OBJETO CAMION CON LOS DATOS RECUPERADOS DE LA BD A PARTIR DE LA IdCiudad.

        public static int ObtenerListadoPais(int idProvincia)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int IdPais = 0;
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetPaisxProvincia";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    IdPais = int.Parse(dr["idPais"].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return IdPais;


        }

        public static bool ActualizarCiudadABD(Ciudad c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCiudad", c.IdCiudad);
                cmd.Parameters.AddWithValue("@nombre", c.NombreCiudad);
                cmd.Parameters.AddWithValue("@idProvincia", c.IdProvinciaCiudad);
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
        //ACTUALIZA LOS DATOS DE UNA CIUDAD EN LA BD.
        public static bool EliminarCiudadABD(Ciudad c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCiudad", c.IdCiudad);
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
        //ELIMINA UNA CIUDAD DE LA BASE DE DATOS

        public static bool ConsultarCiudad(Ciudad c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existeCiudad = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consultar = "ConsultarCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", c.NombreCiudad);
                cmd.Parameters.AddWithValue("@idProvincia", c.IdProvinciaCiudad);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consultar;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count >= 1)
                {
                    existeCiudad = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return existeCiudad;
        } // EVITA ERROR DE CARGAR CIUDAD YA EXISTENTE


        public static DataTable ObtenerProvincia(int IdPais)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetProvincia2";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", IdPais);
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

        public static DataTable ObtenerPais()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetPais2";

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

        public static DataTable ObtenerCiudad2(int IdProvincia)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetCiudad2";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", IdProvincia);
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
