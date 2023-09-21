using EventSoftController.DAO;
using EventSoftModel;
using System;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using EventSoftDBManager;

namespace EventSoftController.MySQL
{
    public class LocalMySQL : LocalDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int insertar(Local local)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "INSERTAR_LOCAL";
                comando.Parameters.Add("_id_local", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fid_estilo_arquitectonico", local.EstiloArquitectonico.IdEstiloArquitectonico);
                comando.Parameters.AddWithValue("_nombre", local.Nombre);
                comando.Parameters.AddWithValue("_direccion", local.Direccion);
                comando.Parameters.AddWithValue("_fecha_construccion", local.FechaConstruccion);
                comando.Parameters.AddWithValue("_aforo", local.Aforo);
                comando.Parameters.AddWithValue("_tiene_palco", local.TienePalco);
                comando.Parameters.AddWithValue("_tiene_proyector", local.TieneProyector);
                comando.Parameters.AddWithValue("_tiene_vestibulo", local.TieneVestibulo);
                comando.Parameters.AddWithValue("_resenha", local.Resenha);
                comando.Parameters.AddWithValue("_foto", local.Foto);
                comando.Parameters.AddWithValue("_plano", local.Plano);
                resultado = comando.ExecuteNonQuery();
                local.IdLocal = Int32.Parse(comando.Parameters["_id_local"].Value.ToString());
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

        public BindingList<Local> lista(String nombre)
        {
            BindingList<Local> locales = new BindingList<Local>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_LOCALES_X_NOMBRE";
                comando.Parameters.AddWithValue("_nombre", nombre);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Local local = new Local();
                    local.IdLocal = lector.GetInt32("id_local");
                    local.EstiloArquitectonico = new EstiloArquitectonico();
                    local.EstiloArquitectonico.IdEstiloArquitectonico = lector.GetInt32("id_estilo_arquitectonico");
                    local.Nombre = lector.GetString("nombre_local");
                    local.Direccion = lector.GetString("direccion");
                    local.FechaConstruccion = lector.GetDateTime("fecha_construccion");
                    local.Aforo = lector.GetInt32("aforo");
                    local.TienePalco = lector.GetBoolean("tiene_palco");
                    local.TieneProyector = lector.GetBoolean("tiene_proyector");
                    local.TieneVestibulo = lector.GetBoolean("tiene_vestibulo");
                    local.Resenha = lector.GetString("resenha");
                    local.Resenha = lector.GetString("resenha");
                    if (!lector.IsDBNull(lector.GetOrdinal("foto"))) local.Foto = (byte[])lector["foto"];
                    if (!lector.IsDBNull(lector.GetOrdinal("plano"))) local.Plano = (byte[])lector["plano"];
                    local.EstiloArquitectonico.Nombre = lector.GetString("nombre_estilo_arquitectonico");
                    local.Activo = true;
                    locales.Add(local);
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
            return locales;
        }
    }
}
