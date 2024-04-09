using MovieSoftController.DAO;
using MovieSoftDBManager;
using MovieSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftController.MySQL
{
    public class GeneroMySQL : GeneroDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<Genero> lista()
        {
            BindingList<Genero> generos = new BindingList<Genero>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_GENEROS_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Genero genero = new Genero();
                    genero.IdGenero = lector.GetInt32("id_genero");
                    genero.Nombre = lector.GetString("nombre");
                    generos.Add(genero);
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
            return generos;
        }
    }
}
