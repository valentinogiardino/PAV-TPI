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
    class AD_Camion
    {
       
        public static DataTable ObtenerMarca()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetMarca";

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

        public static DataTable ObtenerListadoModelo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoModelo";

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

        public static bool AgregarModeloABD(Modelo mod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", mod.NombreDelModelo);
                cmd.Parameters.AddWithValue("@idMarca", mod.IdDeMarca);

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

        public static DataTable ObtenerListadoModelocmb(int valor)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoModelocmb";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", valor);
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

        public static DataTable ObtenerListadoModelotxt(string valor)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoModelotxt";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", "%"+valor+"%");
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

        public static DataTable ObtenerListadoModeloMixto(int nro,string valor)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoModeloMixto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", "%" + valor + "%");
                cmd.Parameters.AddWithValue("@idMarca", nro);
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

        public static bool ActualizarModelo(Modelo mod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idModelo", mod.IdDeModelo);
                cmd.Parameters.AddWithValue("@nombreModelo", mod.NombreDelModelo);
                cmd.Parameters.AddWithValue("@idMarca", mod.IdDeMarca);
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

        public static Modelo ObtenerModelo(string nombre, string Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Modelo mod = new Modelo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", nombre);
                cmd.Parameters.AddWithValue("@nombreMarca", Id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    mod.IdDeModelo = int.Parse(dr["idModelo"].ToString());
                    mod.NombreDelModelo = dr["nombreModelo"].ToString();
                    mod.IdDeMarca = int.Parse(dr["idMarca"].ToString());                   
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

            return mod;

        }

        public static bool EliminarModeloABD(Modelo mod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idModelo", mod.IdDeModelo);
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

        public static DataTable ObtenerListadoMarcatxt(string valor)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListadoMarcatxt";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMarca", "%" + valor + "%");
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

        public static bool AgregarMarcaABD(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertMarca";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMarca", mar.NombreDeMarca);               

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

        public static Marca ObtenerMarca(string Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Marca mar = new Marca();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetMarcaReducido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", Id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    mar.IdDeMarca = int.Parse(dr["idMarca"].ToString());
                    mar.NombreDeMarca = dr["nombreMarca"].ToString();
                   
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

            return mar;

        }

        public static bool ActualizarMarca(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarMarca";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMarca", mar.NombreDeMarca);
                cmd.Parameters.AddWithValue("@idMarca", mar.IdDeMarca);
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

        public static bool EliminarMarcaABD(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarMarca";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", mar.IdDeMarca);
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

