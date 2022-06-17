using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.AccesoADatos
{
    class AD_Empleados
    {

        public static bool AgregarEmpleadoABD(Empleado e)
         {
            bool resultado = false;
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc",e.NroDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@tipoDoc",e.TipoDocEmpleado);
                cmd.Parameters.AddWithValue("@legajo",e.LegajoDeEmpleado); 
                cmd.Parameters.AddWithValue("@cuil",e.CuilEmpleado);
                cmd.Parameters.AddWithValue("@apellido",e.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@nombre",e.NombreEmpleado);
                cmd.Parameters.AddWithValue("@calle",e.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroCalle",e.NroCalleEmpleado);
                cmd.Parameters.AddWithValue("@idCiudad",e.IdCiudadEmpleado);
                cmd.Parameters.AddWithValue("@fechaIngreso",e.FechaIngresoEmpleado);
                cmd.Parameters.AddWithValue("@gerente",e.GerenteEmpleado);

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

        public static bool ActualizarEmpleadoABD(Empleado e)
        {
            bool resultado = false;
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", e.NroDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@tipoDoc", e.TipoDocEmpleado);
                cmd.Parameters.AddWithValue("@legajo", e.LegajoDeEmpleado);
                cmd.Parameters.AddWithValue("@cuil", e.CuilEmpleado);
                cmd.Parameters.AddWithValue("@apellido", e.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", e.NombreEmpleado);
                cmd.Parameters.AddWithValue("@calle", e.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroCalle", e.NroCalleEmpleado);
                cmd.Parameters.AddWithValue("@idCiudad", e.IdCiudadEmpleado);
                cmd.Parameters.AddWithValue("@fechaIngreso", e.FechaIngresoEmpleado);
                cmd.Parameters.AddWithValue("@gerente", e.GerenteEmpleado);

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

        public static DataTable ObtenerGrilla()
        {
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEmpleados";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Empleado ObtenerDatosEmpleado(int tipoDocumento, string nroDocumento)
        {
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            Empleado e = new Empleado();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Empleado WHERE nroDoc LIKE @nroDoc AND tipoDoc LIKE @tipoDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", nroDocumento);
                cmd.Parameters.AddWithValue("@tipoDoc", tipoDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    e.NombreEmpleado = dr["nombre"].ToString();
                    e.ApellidoEmpleado = dr["apellido"].ToString();
                    e.FechaIngresoEmpleado = DateTime.Parse(dr["fechaIngreso"].ToString());
                    e.TipoDocEmpleado = int.Parse(dr["tipoDoc"].ToString());
                    e.NroDocumentoEmpleado = dr["nroDoc"].ToString();
                    e.CalleEmpleado = dr["calle"].ToString();
                    e.NroCalleEmpleado = dr["nroCalle"].ToString();
                    e.LegajoDeEmpleado = dr["legajo"].ToString();
                    e.CuilEmpleado = dr["cuil"].ToString();
                    e.IdCiudadEmpleado = int.Parse(dr["idCiudad"].ToString());
                    e.GerenteEmpleado = bool.Parse(dr["gerente"].ToString());
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

            return e;
        }


        public static bool BorrarEmpleadoABD(Empleado e)
        {
            bool resultado = false;
            string cadenaCondexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaCondexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", e.NroDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@tipoDoc", e.TipoDocEmpleado);

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

        public static DataTable ObtenerListadoEmpleadoReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoEmpleadoReporte";
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

        public static DataTable ObtenerListadoEmpleadoReporteRestricciones(string nombre, string apellido, string nroDoc, string cuil, string legajo, int idCiudad, bool gerente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "GetListadoEmpleadoRestricciones";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
                cmd.Parameters.AddWithValue("@cuil", cuil);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.Parameters.AddWithValue("@gerente", gerente);
                cmd.Parameters.AddWithValue("@idCiudad", idCiudad);
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

        public static DataTable ObtenerListadoEmpleadoReporteRestriccionesCiudad(string nombre, string apellido, string nroDoc, string cuil, string legajo, bool gerente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "GetListadoEmpleadoRestriccionesCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
                cmd.Parameters.AddWithValue("@cuil", cuil);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.Parameters.AddWithValue("@gerente", gerente);
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
