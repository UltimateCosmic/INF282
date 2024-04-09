using MovieSoftController.DAO;
using MovieSoftDBManager;
using MovieSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftController.MySQL
{
    public class PeliculaMySQL : PeliculaDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int insertar(Pelicula pelicula)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "INSERTAR_PELICULA";
                comando.Parameters.Add("_id_pelicula", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fid_genero", pelicula.Genero.IdGenero);
                comando.Parameters.AddWithValue("_fid_productora", pelicula.Productora.IdProductora);
                comando.Parameters.AddWithValue("_nombre", pelicula.Nombre);
                comando.Parameters.AddWithValue("_fecha_estreno", pelicula.FechaEstreno);
                comando.Parameters.AddWithValue("_formato_doblada", pelicula.FormatoDoblada);
                comando.Parameters.AddWithValue("_formato_subtitulada", pelicula.FormatoSubtitulada);
                comando.Parameters.AddWithValue("_formato_xtreme", pelicula.FormatoXtreme);
                comando.Parameters.AddWithValue("_formato_3D", pelicula.Formato3D);
                comando.Parameters.AddWithValue("_costo_produccion", pelicula.CostoProduccion);
                comando.Parameters.AddWithValue("_sinopsis", pelicula.Sinopsis);
                comando.Parameters.AddWithValue("_portada", pelicula.Portada);
                resultado = comando.ExecuteNonQuery();
                pelicula.IdPelicula = Int32.Parse(comando.Parameters["_id_pelicula"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return resultado;            
        }

        public BindingList<Pelicula> lista()
        {
            BindingList<Pelicula> peliculas = new BindingList<Pelicula>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_PELICULAS_TODAS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.IdPelicula = lector.GetInt32("id_pelicula");
                    pelicula.Genero = new Genero();
                    pelicula.Genero.IdGenero = lector.GetInt32("id_genero");
                    pelicula.Genero.Nombre = lector.GetString("nombre_genero");
                    pelicula.Productora = new Productora();
                    pelicula.Productora.IdProductora = lector.GetInt32("id_productora");
                    pelicula.Productora.Nombre = lector.GetString("nombre_productora");
                    if (!lector.IsDBNull(lector.GetOrdinal("logo"))) pelicula.Productora.Logo = (byte[])lector["logo"];
                    pelicula.Productora.R = lector.GetInt32("R");
                    pelicula.Productora.G = lector.GetInt32("G");
                    pelicula.Productora.B = lector.GetInt32("B");
                    pelicula.Nombre = lector.GetString("nombre_pelicula");
                    pelicula.FechaEstreno = lector.GetDateTime("fecha_estreno");
                    pelicula.FormatoDoblada = lector.GetBoolean("formato_doblada");
                    pelicula.FormatoSubtitulada = lector.GetBoolean("formato_subtitulada");
                    pelicula.FormatoXtreme = lector.GetBoolean("formato_xtreme");
                    pelicula.Formato3D = lector.GetBoolean("formato_3D");
                    pelicula.CostoProduccion = lector.GetDouble("costo_produccion");
                    pelicula.Sinopsis = lector.GetString("sinopsis");
                    if (!lector.IsDBNull(lector.GetOrdinal("portada"))) pelicula.Portada = (byte[])lector["portada"];
                    peliculas.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return peliculas;
        }
    }
}
