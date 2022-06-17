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
    class AD_Combustible
    {

        public static DataTable ObtenerTipoCombustible()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetTipoDeCombustible";

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

        public static DataTable ObtenerListadoCombustibles()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

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

        public static bool AgregarCombustibleABD(Combustible com)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreComb", com.NombreDeCombustible);
                cmd.Parameters.AddWithValue("@codTipoComb", com.CodTipoDeCombustible);
                cmd.Parameters.AddWithValue("@precioUni", com.PrecioUnitarioDeCombustible);
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

        public static DataTable ObtenerListadoCombustiblesReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoCombustiblesReporte";
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

        public static DataTable ObtenerListadoCombustiblesReporteMax(string max)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
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

        public static DataTable ObtenerListadoCombustiblesReporteMin(string min)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario > @min";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@min", min);
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

        public static DataTable ObtenerListadoCombustiblesReporteCmb(string cmb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.codTipoCombustible = @cmb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cmb", cmb);
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

        public static DataTable ObtenerListadoCombustiblesReporteNom(string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.nombre LIKE @nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteMinMax(string min, string max)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND @min < c.precioUnitario AND c.precioUnitario < @max";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxCmb(string max, string cmb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.codTipoCombustible = @cmb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@cmb", cmb);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxNom(string max, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.nombre = @nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteMinCmb(string min, string cmb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND @min < c.precioUnitario AND c.codTipoCombustible = @cmb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@cmb", cmb);
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

        public static DataTable ObtenerListadoCombustiblesReporteMinNom(string min, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND @min < c.precioUnitario AND c.nombre = @nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteCmbNom(string cmb, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.codTipoCombustible = @cmb AND c.nombre LIKE @nom ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cmb", cmb);
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxMinNom(string max, string min, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.precioUnitario > @min AND c.nombre = @nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxMinCmb(string max, string min, string cmb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.precioUnitario > @min AND c.codTipoCombustible = @cmb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@cmb", cmb);
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

        public static DataTable ObtenerListadoCombustiblesReporteMinCmbNom(string min, string cmb, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.nombre = @nom AND c.precioUnitario > @min AND c.codTipoCombustible = @cmb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@cmb", cmb);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxCmbNom(string max, string cmb, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.codTipoCombustible = @cmb AND c.nombre = @nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@cmb", cmb);
                cmd.Parameters.AddWithValue("@nom", nom);
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

        public static DataTable ObtenerListadoCombustiblesReporteMaxMinCmbNom(string max, string min, string cmb, string nom)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.idCombustible AS 'ID', tc.nombre AS 'TipoCombustible', c.nombre AS 'NombreCombustible', c.precioUnitario AS 'PrecioUnitario' " +
                    "FROM Combustible c, Tipo_De_Combustible tc WHERE c.codTipoCombustible = tc.codTipoCombustible AND c.precioUnitario < @max AND c.codTipoCombustible = @cmb AND c.nombre = @nom AND c.precioUnitario > @min";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@max", max);
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@cmb", cmb);
                cmd.Parameters.AddWithValue("@nom", nom);
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
