using EventSoftController.DAO;
using EventSoftDBManager;
using EventSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

namespace EventSoftController.MySQL
{
    public class EstiloArquitectonicoMySQL : EstiloArquitectonicoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<EstiloArquitectonico> lista()
        {
            BindingList<EstiloArquitectonico> estilosArquitectonicos = new BindingList<EstiloArquitectonico>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_ESTILOS_ARQUITECTONICOS_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    EstiloArquitectonico estiloArquitectonico = new EstiloArquitectonico();
                    estiloArquitectonico.IdEstiloArquitectonico = lector.GetInt32("id_estilo_arquitectonico");
                    estiloArquitectonico.Nombre = lector.GetString("nombre");
                    estiloArquitectonico.Activo = lector.GetBoolean("activo");
                    estilosArquitectonicos.Add(estiloArquitectonico);
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
            return estilosArquitectonicos;
        }
    }
}
