using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorDB
    {
        private static string cadenaConexion;

        static GestorDB()
        {
            GestorDB.cadenaConexion = "Server=.;Database=ServiciosAgropecuarios;Trusted_Connection=True;";

        }
        /// <summary>
        /// Se lee una lista de transportistas desde una base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Transportista> LeerDatos()
        {
            List<Transportista> datos = new List<Transportista>();
            try
            {
                string query = "SELECT * FROM Transportistas";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string cuit = reader.GetString(2);
                        string patente = reader.GetString(3);
                        long toneladas = reader.GetInt64(4);
                        Enumerados.Granos.Grano tipoGrano = (Enumerados.Granos.Grano)reader.GetInt32(5);
                        DateTime fechaIngreso = reader.GetDateTime(6);
                        DateTime fechaDescarga = reader.GetDateTime(7);
                        Transportista transportista = new Transportista(cuit, nombre, patente, toneladas, tipoGrano, fechaIngreso, fechaDescarga, id);
                        datos.Add(transportista);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return datos;
        }
        /// <summary>
        /// Se da de alta un transportista en una base de datos
        /// </summary>
        /// <param name="transportista"></param>
        public static void Alta(Transportista transportista)
        {
            string query = "insert into Transportistas (nombre, cuit, patente, toneladas, tipoGrano, fechaIngreso, fechaDescarga) values (@nombre, @cuit, @patente, @toneladas, @tipoGrano, @fechaIngreso, @fechaDescarga)";
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection(GestorDB.cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("nombre", transportista.Nombre);
                cmd.Parameters.AddWithValue("cuit", transportista.Cuit);
                cmd.Parameters.AddWithValue("patente", transportista.Patente);
                cmd.Parameters.AddWithValue("toneladas", transportista.Toneladas);
                cmd.Parameters.AddWithValue("tipoGrano", transportista.TipoGrano);
                cmd.Parameters.AddWithValue("fechaIngreso", transportista.FechaIngreso);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        /// <summary>
        /// Se actualiza la cantidad de toneladas y la fecha de descarga
        /// </summary>
        /// <param name="tr"> transportista a descargar</param>
        /// <param name="id"> id del transportista</param>
        public static void ActualizarDatosDescarga(Transportista tr, int id)
        {
            string query = "update Transportistas set toneladas=@toneladas, fechaDescarga=@fechaDescarga where id = @id";
            try
            {
                using(SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("toneladas", tr.Toneladas);
                    cmd.Parameters.AddWithValue("fechaDescarga", tr.FechaDescarga);
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
    
}
