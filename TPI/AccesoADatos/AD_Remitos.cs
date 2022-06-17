using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI.AccesoADatos
{
    public class AD_Remitos
    {
        public static DataTable ObtenerCuitEstacion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetCuitEstacion";

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


        public static DataTable ObtenerPatente()
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


        public static DataTable ObtenerNombreComb()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoCombustibles";

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


        public static int ObtenerUltimoNumRemito()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(numRemito) FROM Remito";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = int.Parse(cmd.ExecuteScalar().ToString());
                return resultado;

            }
            catch (Exception ex)
            {               
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool AltaRemito(string numRemito, string cuitEstacion, string fecha,string patente, List<int> listaCombustible, List<float> listaCantidad, List<float> listaPrecio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Remito VALUES(@numRemito,@cuitEstacion,@fecha,@patente)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numRemito",numRemito );
                cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                objTransaccion = cn.BeginTransaction("GenerarRemito");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                for (int i = 0; i < listaCombustible.Count ; i++)
                {            
                    string consultaRemitoXCombustible = "INSERT INTO Detalle_Remito values(@numRemito, @cuitEstacion, @idCombustible, @cantLitrosCombustible, @precioXLitro)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numRemito",numRemito );
                    cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
                    cmd.Parameters.AddWithValue("@idCombustible",listaCombustible.ElementAt(i));                    
                    cmd.Parameters.AddWithValue("@cantLitrosCombustible", listaCantidad.ElementAt(i));
                    cmd.Parameters.AddWithValue("@precioXLitro", listaPrecio.ElementAt(i));
                    
                    cmd.CommandText = consultaRemitoXCombustible;
                    cmd.ExecuteNonQuery();

                }

                objTransaccion.Commit();
                return true;

            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable ObtenerListadoRemitos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetRemito";

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


        public static DataTable ObtenerListadoDetalleRemitoEspecial(string numRemito, string cuitEstacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetDetalleRemito";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numRemito", numRemito);
                cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
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
