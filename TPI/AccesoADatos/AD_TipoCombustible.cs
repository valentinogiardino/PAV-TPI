using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.AccesoADatos
{
    class AD_TipoCombustible
    {
        public static DataTable ObtenerListadoTipoCombustible()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Tipo_De_Combustible";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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

        public static bool InsertarTipoCombustible(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertTipoCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
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

        public static bool ActualizarTipoCombustible(TipoCombustible tc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTipoCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tc.NombreTipoDeCombustible);
                cmd.Parameters.AddWithValue("@tipoCombustible", tc.IdTipoDeCombustible);

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

        public static TipoCombustible ObtenerTipoCombustibleABD(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoCombustible tc = new TipoCombustible();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT codTipoCombustible,nombre from Tipo_De_Combustible WHERE codTipoCombustible LIKE @codTipoCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTipoCombustible", id);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    tc.IdTipoDeCombustible = int.Parse(dr["codTipoCombustible"].ToString());
                    tc.NombreTipoDeCombustible = dr["nombre"].ToString();
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


            return tc;
        }

        public static bool BorrarTipoCombustible(TipoCombustible tc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarTipoCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoCombustible", tc.IdTipoDeCombustible);

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
    }
}
