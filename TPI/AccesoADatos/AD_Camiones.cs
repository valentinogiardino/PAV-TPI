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
    public class AD_Camiones
    {
        public static DataTable ObtenerListadoCamiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetCamiones";

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

        public static DataTable ObtenerListadoCamionesConFiltro(string patente, string modelo, float cantidadMin, float cantidadMax)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetCamionesConFiltro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@idModelo", modelo);
                cmd.Parameters.AddWithValue("@cantCombustibleMin", cantidadMin);
                cmd.Parameters.AddWithValue("@cantCombustibleMax", cantidadMax);
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
            };
        }

        public static bool InsertarCamionABD(Camion c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoCamion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", c.PatenteCamion);
                cmd.Parameters.AddWithValue("@idModelo", c.IdModeloCamion);
                cmd.Parameters.AddWithValue("@cantCombustibleMax", c.CantCombustibleMaxCamion);
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
        // INSERTA UN NUEVO OBJETO CAMION EN LA BD


        public static Camion ObtenerCamion(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Camion c = new Camion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCamionPatente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    c.PatenteCamion = dr["patente"].ToString();
                    c.IdModeloCamion = int.Parse(dr["idModelo"].ToString());
                    c.CantCombustibleMaxCamion = float.Parse(dr["cantCombustibleMax"].ToString());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del Camion");
            }
            finally
            {
                cn.Close();
            }
            return c;
        }
        // CREA UN NUEVO OBJETO CAMION CON LOS DATOS RECUPERADOS DE LA BD A PARTIR DE LA PATENTE.

        public static bool ActualizarCamionABD(Camion c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCamion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", c.PatenteCamion);
                cmd.Parameters.AddWithValue("@idModelo", c.IdModeloCamion);
                cmd.Parameters.AddWithValue("@cantCombustibleMax", c.CantCombustibleMaxCamion);
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
        //ACTUALIZA LOS DATOS DE UN CAMION EN LA BD. NO SE PERMITE MODIFICAR LA PATENTE EN UNA ACTUALIZACION, DEBERA BORRARSE Y CREARSE UNA NUEVA.


        public static bool EliminarCamionABD(Camion c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarCamion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", c.PatenteCamion);
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
        }//ELIMINA UN CAMION DE LA BD.

        public static bool ConsultarCamion(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existeCamion = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consultar = "GetCamionPatente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consultar;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    existeCamion = true;
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
            return existeCamion;
        } // EVITA ERROR DE CARGAR CAMION CON PATENTE YA EXISTENTE EN OTRO CAMION

        public static DataTable ObtenerModelo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetModelo2";

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
