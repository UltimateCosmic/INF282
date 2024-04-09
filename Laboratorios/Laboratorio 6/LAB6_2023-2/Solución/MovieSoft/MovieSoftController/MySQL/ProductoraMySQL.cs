using MovieSoftController.DAO;
using MovieSoftDBManager;
using MovieSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftController.MySQL
{
    public class ProductoraMySQL : ProductoraDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<Productora> lista()
        {
            BindingList<Productora> productoras = new BindingList<Productora>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_PRODUCTORAS_TODAS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Productora productora = new Productora();
                    productora.IdProductora = lector.GetInt32("id_productora");
                    productora.Nombre = lector.GetString("nombre");
                    if (!lector.IsDBNull(lector.GetOrdinal("logo"))) productora.Logo = (byte[])lector["logo"];
                    productora.R = lector.GetInt32("R");
                    productora.G = lector.GetInt32("G");
                    productora.B = lector.GetInt32("B");
                    productoras.Add(productora);
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
            return productoras;
        }
    }
}
