using EduSoftController.DAO;
using EduSoftDBManager;
using EduSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.MySQL
{
    public class EjecutivoMySQL : EjecutivoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        public BindingList<Ejecutivo> listarPorNombreDNI(string nombreDNI)
        {
            BindingList<Ejecutivo> ejecutivos = new BindingList<Ejecutivo>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_EJECUTIVOS_X_NOMBRE_DNI";
                comando.Parameters.AddWithValue("_nombre_DNI", nombreDNI);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Ejecutivo ejecutivo = new Ejecutivo();
                    ejecutivo.IdEjecutivo = lector.GetInt32("id_ejecutivo");
                    ejecutivo.DNI = lector.GetString("DNI");
                    ejecutivo.Nombre = lector.GetString("nombre");
                    ejecutivo.ApellidoPaterno = lector.GetString("apellido_paterno");
                    ejecutivos.Add(ejecutivo);
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
            return ejecutivos;
        }
    }
}
