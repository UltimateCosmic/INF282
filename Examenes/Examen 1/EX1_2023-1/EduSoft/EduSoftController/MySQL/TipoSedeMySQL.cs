using EduSoftController.DAO;
using EduSoftDBManager;
using EduSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.MySQL
{
    public class TipoSedeMySQL : TipoSedeDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<TipoSede> listarTodos()
        {
            BindingList<TipoSede> tiposSedes = new BindingList<TipoSede>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_TIPOS_SEDE_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    TipoSede tipoSede = new TipoSede();
                    tipoSede.IdTipoSede = lector.GetInt32("id_tipo_sede");
                    tipoSede.Nombre = lector.GetString("nombre");
                    tipoSede.Activo = true;
                    tiposSedes.Add(tipoSede);
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
            return tiposSedes;
        }
    }
}
