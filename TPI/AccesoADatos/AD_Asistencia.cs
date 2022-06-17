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
    public class AD_Asistencia
    {
        public static DataTable ObtenerTurnoEstacion(string cuitEstacion)
        {

            
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    bool resultado = false;

                    SqlCommand cmd = new SqlCommand();


                    string consulta = "SELECT * FROM Turno where cuitEstacion like @cuitEstacion";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
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



        public static DataTable ObtenerNroDoc(string cuitEstacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Empleado WHERE idCiudad = (SELECT e.idCiudad FROM Estacion e WHERE cuitEstacion LIKE @cuitEstacion)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("cuitEstacion", cuitEstacion);
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


        public static DataTable ObtenerEmpleado(string nroDoc, int tipoDoc)
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT e.nroDoc, e.tipoDoc, e.nombre, e.apellido FROM Empleado e WHERE e.nroDoc LIKE @nroDoc AND e.tipoDoc LIKE @tipoDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
                cmd.Parameters.AddWithValue("@tipoDoc", tipoDoc);
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


        public static DataTable ObtenerTipoDoc(string nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tipo_De_Documento WHERE tipoDoc = (SELECT e.tipoDoc FROM Empleado e WHERE e.nroDoc = @nroDoc) ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nroDoc", nroDoc);
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

        public static bool GenerarAsistencia(string cuitEstacion, string nombreTurno, string fecha, List<string> listaDocumentos, List<int> listaTipoDocumentos)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cn.Open();
                cmd.Connection = cn;
                objTransaccion = cn.BeginTransaction("GenerarAsistencia");

                cmd.Transaction = objTransaccion;



                for (int i = 0; i < listaDocumentos.Count; i++)
                {
                    string consultaEmpleadoXTurno = "INSERT INTO Asistencia values(@cuitEstacion, @nombreTurno, @nroDoc, @tipoDoc, @fecha)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
                    cmd.Parameters.AddWithValue("@nombreTurno", nombreTurno);
                    cmd.Parameters.AddWithValue("@nroDoc", listaDocumentos.ElementAt(i));
                    cmd.Parameters.AddWithValue("@tipoDoc", listaTipoDocumentos.ElementAt(i));
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    cmd.CommandText = consultaEmpleadoXTurno;

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


        public static DataTable ObtenerListadoDeAsistencias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Asistencia";

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


        public static DataTable ObtenerListadoDeEmpleadoMasTurnos(int top, string fechaDesde, string fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetMaxTurno";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@top", top);
                cmd.Parameters.AddWithValue("@desde", fechaDesde);
                cmd.Parameters.AddWithValue("@hasta", fechaHasta);
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








