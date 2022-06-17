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
    public class AD_Estacion
    {
        public static DataTable ObtenerCiudad()
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
        public static DataTable ObtenerTipoDoc()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
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

        public static DataTable ObtenerListadoEstacion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetEstacion";

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

        public static bool AgregarEstacionABD(Estacion es)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Estacion(cuitEstacion, numSucursal, nombre, calle, calleNro, idCiudad, nroDocGerente, tipoDocGerente)  VALUES(@cuitEstacion, @numSuc, @nombre, @calle, @calleNro, @idCiudad, @nroDocGer, @tipoDocGer)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", es.NroCuitSuc);
                cmd.Parameters.AddWithValue("@numSuc", es.NumSucursal);
                cmd.Parameters.AddWithValue("@nombre", es.NombreSucursal);
                cmd.Parameters.AddWithValue("@calle", es.CalleSucursal);
                cmd.Parameters.AddWithValue("@calleNro", es.NumeroCalleSucursal);
                cmd.Parameters.AddWithValue("@idCiudad", es.CiudadSucursal);
                cmd.Parameters.AddWithValue("@nroDocGer", es.NroDocGerenteEstacion);
                cmd.Parameters.AddWithValue("@tipoDocGer", es.TipoDocGerenteEstacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                MessageBox.Show("La Estacion ya esta registrada en el sistema.");
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarEstacionABD(Estacion e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEstacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", e.NroCuitSuc);
                cmd.Parameters.AddWithValue("@numSucursal", e.NumSucursal);
                cmd.Parameters.AddWithValue("@nombre", e.NombreSucursal);
                cmd.Parameters.AddWithValue("@calle", e.CalleSucursal);
                cmd.Parameters.AddWithValue("@calleNro", e.NumeroCalleSucursal);
                cmd.Parameters.AddWithValue("@idCiudad", e.CiudadSucursal);
                cmd.Parameters.AddWithValue("@nroDocGerente", e.NroDocGerenteEstacion);
                cmd.Parameters.AddWithValue("@tipoDocGerente", e.TipoDocGerenteEstacion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }


        public static Estacion ObtenerEstacion(string cuit)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Estacion es = new Estacion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCuitEstacionCargar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion",cuit );

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    es.NroCuitSuc = dr["cuitEstacion"].ToString();
                    es.NumSucursal = int.Parse(dr["numSucursal"].ToString());
                    es.NombreSucursal = dr["nombre"].ToString();
                    es.CalleSucursal = dr["calle"].ToString();
                    es.NumeroCalleSucursal = dr["calleNro"].ToString();
                    es.CiudadSucursal = int.Parse(dr["idCiudad"].ToString());
                    es.NroDocGerenteEstacion = dr["nroDocGerente"].ToString();
                    es.TipoDocGerenteEstacion = int.Parse(dr["tipoDocGerente"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }

            return es;
        }

        public static bool EliminarEstacionABD(Estacion es)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarEstacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", es.NroCuitSuc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
               
                resultado = true;
            }
            catch (Exception )
            {
                
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        
        }

        public static bool VerificarExistenciaEstacion(Estacion e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "VerificarExistenciaEstacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuitEstacion", e.NroCuitSuc);
                cmd.Parameters.AddWithValue("@numSucursal", e.NumSucursal);
                cmd.Parameters.AddWithValue("@nombre", e.NombreSucursal);
                cmd.Parameters.AddWithValue("@calleNro", e.NumeroCalleSucursal);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
            return resultado;
        }

        public static bool consultarExistenciaEmpleado(string nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existeGerente = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consultar = "GetGerenteNroDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
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
                    existeGerente = true;
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
            return existeGerente;
        }

        public static DataTable ObtenerEstacionesFiltradas(string cuit,string nroSucursal,int ciudad,string calle,string nroCalle) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                
                if (ciudad != -1)
                {
                    string consulta = "EstacionesFiltradas";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuitEstacion", cuit);
                    cmd.Parameters.AddWithValue("@numSucursal", nroSucursal);
                    cmd.Parameters.AddWithValue("@calle", calle);
                    cmd.Parameters.AddWithValue("@idCiudad", ciudad);
                    cmd.Parameters.AddWithValue("@calleNro", nroCalle);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    return tabla;
                }
                else
                {
                    string consulta = "EstacionesFiltradasSinCiudad";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuitEstacion", cuit);
                    cmd.Parameters.AddWithValue("@numSucursal", nroSucursal);
                    cmd.Parameters.AddWithValue("@calle", calle);
                    cmd.Parameters.AddWithValue("@calleNro", nroCalle);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    return tabla;
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
        }
    }
}
