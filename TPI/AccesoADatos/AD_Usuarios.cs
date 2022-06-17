using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.AccesoADatos
{
    class AD_Usuarios
    {
        public static bool ValidarUsuario(string legajo, string nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleado WHERE legajo like @legajo AND nroDoc like @nroDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                return resultado;
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

        public static string ObtenerUsuario(string NroDoc, string Legajo )
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT nombre FROM Empleado WHERE @nroDoc = nroDoc AND @legajo = legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", NroDoc);
                cmd.Parameters.AddWithValue("@legajo", Legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                string resultado = (string)cmd.ExecuteScalar();
                return resultado;


            }
            catch (Exception ex)
            {

                return "";
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
