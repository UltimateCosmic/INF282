using FlightSoftSolutionsController.DAO;
using FlightSoftSolutionsDBManager;
using FlightSoftSolutionsModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsController.MySQL
{
    public class CiudadMySQL : CiudadDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<Ciudad> listarTodas()
        {
            BindingList<Ciudad> ciudades = new BindingList<Ciudad>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_CIUDADES_TODAS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Ciudad ciudad = new Ciudad();
                    ciudad.IdCiudad = lector.GetInt32("id_ciudad");
                    ciudad.Siglas = lector.GetString("siglas");
                    ciudad.Nombre = lector.GetString("nombre");                    
                    ciudades.Add(ciudad);
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
            return ciudades;
        }
    }
}
