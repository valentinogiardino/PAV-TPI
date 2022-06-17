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
    class AD_TipoDoc
    {
        public static DataTable ObtenerListadoTipoDoc()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Tipo_De_Documento";

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

        public static bool InsertarTipoDoc(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertTipoDoc";
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

        public static TipoDoc ObtenerTipoDocABD(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoDoc td = new TipoDoc();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT tipoDoc,nombre from Tipo_De_Documento WHERE tipoDoc LIKE @tipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", id);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    td.IdTipoDeDoc = int.Parse(dr["tipoDoc"].ToString());
                    td.NombreTipoDeDoc = dr["nombre"].ToString();
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


            return td;
        }

        public static bool ActualizarTipoDoc(TipoDoc td)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", td.NombreTipoDeDoc);
                cmd.Parameters.AddWithValue("@tipoDoc", td.IdTipoDeDoc);

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
        

            public static bool BorrarTipoDoc(TipoDoc td)
            {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", td.IdTipoDeDoc);

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
