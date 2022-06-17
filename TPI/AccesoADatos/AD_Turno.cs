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
    class AD_Turno
    {
        public static DataTable ObtenerListadoTurno()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoTurno";

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

        public static bool AgregarTurnoABD(Turno t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", t.CuitDeLaEstacion);
                cmd.Parameters.AddWithValue("@nombreTurno", t.NombreDelTurno);
                cmd.Parameters.AddWithValue("@descripcion", t.DescripcionDelTurno);
                cmd.Parameters.AddWithValue("@horaDesde", t.HoraDesdeTurno);
                cmd.Parameters.AddWithValue("@horaHasta", t.HoraHastaTurno);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar turno a la BD");
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static DataTable ObtenerCuitsEstacion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
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

        public static bool ActualizarTurnoABD(Turno t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", t.CuitDeLaEstacion);
                cmd.Parameters.AddWithValue("@nombreTurno", t.NombreDelTurno);
                cmd.Parameters.AddWithValue("@descripcion", t.DescripcionDelTurno);
                cmd.Parameters.AddWithValue("@horaDesde", t.HoraDesdeTurno);
                cmd.Parameters.AddWithValue("@horaHasta", t.HoraHastaTurno);


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

        public static Turno ObtenerTurno(string cuitEstacion, string nombreTurno)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Turno t = new Turno();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
                cmd.Parameters.AddWithValue("@nombreTurno", nombreTurno);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    t.CuitDeLaEstacion = dr["cuitEstacion"].ToString();
                    t.NombreDelTurno = dr["nombreTurno"].ToString();
                    t.DescripcionDelTurno = dr["descripcion"].ToString();
                    t.HoraDesdeTurno = dr["horaDesde"].ToString();
                    t.HoraHastaTurno = dr["horaHasta"].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del Turno");
            }
            finally
            {
                cn.Close();
            }
            return t;
        }

        public static bool EliminarTurnoABD(Turno t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", t.CuitDeLaEstacion);
                cmd.Parameters.AddWithValue("@nombreTurno", t.NombreDelTurno);

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

        public static DataTable ObtenerListadoTurnosReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoTurno";
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

        public static DataTable ObtenerListadoTurnosReporteRestricciones(string cuitEstacion, string nombreTurno, string horaDesde, string horaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "TurnosFiltrados";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);
                cmd.Parameters.AddWithValue("@nombreTurno", nombreTurno);
                cmd.Parameters.AddWithValue("@horaDesde", horaDesde);
                cmd.Parameters.AddWithValue("@horaHasta", horaHasta);
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

        public static DataTable ObtenerNombresTurno()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT DISTINCT t.nombreTurno FROM Turno t";

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

    }
}
