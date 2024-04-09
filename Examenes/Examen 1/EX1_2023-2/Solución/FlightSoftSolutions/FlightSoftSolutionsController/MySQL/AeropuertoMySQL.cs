using FlightSoftSolutionsController.DAO;
using FlightSoftSolutionsDBManager;
using FlightSoftSolutionsModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsController.MySQL
{
    public class AeropuertoMySQL : AeropuertoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlCommand comando2;
        private MySqlDataReader lector;
        public int insertar(Aeropuerto aeropuerto)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "INSERTAR_AEROPUERTO";
                comando.Parameters.Add("_id_aeropuerto", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fid_ciudad", aeropuerto.Ciudad.IdCiudad);
                comando.Parameters.AddWithValue("_fid_operadora", aeropuerto.Operadora.IdEmpresa);
                comando.Parameters.AddWithValue("_nombre", aeropuerto.Nombre);
                comando.Parameters.AddWithValue("_direccion", aeropuerto.Direccion);
                comando.Parameters.AddWithValue("_anho_fundacion", aeropuerto.AnhoFundacion);
                comando.Parameters.AddWithValue("_costo_construccion", aeropuerto.CostoConstruccion);
                comando.Parameters.AddWithValue("_tipo_aeropuerto", aeropuerto.TipoAeropuerto.ToString());
                comando.Parameters.AddWithValue("_tiene_sala_vip", aeropuerto.TieneSalaVIP);
                comando.Parameters.AddWithValue("_tiene_wifi", aeropuerto.TieneWiFi);
                comando.Parameters.AddWithValue("_tiene_sistema_gestion_equipaje", aeropuerto.TieneSistemaGestionEquipaje);
                comando.Parameters.AddWithValue("_foto", aeropuerto.Foto);
                resultado = comando.ExecuteNonQuery();
                aeropuerto.IdAeropuerto = Int32.Parse(comando.Parameters["_id_aeropuerto"].Value.ToString());
                foreach (EmpresaComercial ec in aeropuerto.EmpresasComerciales)
                {
                    comando = new MySqlCommand();
                    comando.Connection = con;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "INSERTAR_AEROPUERTO_EMPRESA_COMERCIAL";
                    comando.Parameters.Add("_id_aeropuerto_empresa_comercial", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                    comando.Parameters.AddWithValue("_fid_aeropuerto", aeropuerto.IdAeropuerto);
                    comando.Parameters.AddWithValue("_fid_empresa_comercial", ec.IdEmpresa);
                    resultado = comando.ExecuteNonQuery();
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
            return resultado;
        }

        public BindingList<Aeropuerto> listarPorNombre(string nombre)
        {
            BindingList<Aeropuerto> aeropuertos = new BindingList<Aeropuerto>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_AEROPUERTOS_X_NOMBRE";
                comando.Parameters.AddWithValue("_nombre", nombre);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Aeropuerto aeropuerto = new Aeropuerto();
                    aeropuerto.IdAeropuerto = lector.GetInt32("id_aeropuerto");
                    aeropuerto.Ciudad = new Ciudad();
                    aeropuerto.Ciudad.IdCiudad = lector.GetInt32("id_ciudad");
                    aeropuerto.Ciudad.Siglas = lector.GetString("siglas_ciudad");
                    aeropuerto.Ciudad.Nombre = lector.GetString("nombre_ciudad");
                    aeropuerto.Operadora = new Operadora();
                    aeropuerto.Operadora.IdEmpresa = lector.GetInt32("id_operadora");
                    aeropuerto.Operadora.Nombre = lector.GetString("nombre_operadora");
                    aeropuerto.Operadora.OfreceSoporteLogistico = lector.GetBoolean("ofrece_soporte_logistico");
                    aeropuerto.Operadora.OfreceAsistenciaNavegacion = lector.GetBoolean("ofrece_soporte_logistico");
                    aeropuerto.Operadora.OfreceSoporteLogistico = lector.GetBoolean("ofrece_asistencia_navegacion");
                    aeropuerto.Nombre = lector.GetString("nombre_aeropuerto");
                    aeropuerto.Direccion = lector.GetString("direccion");
                    aeropuerto.AnhoFundacion = lector.GetInt32("anho_fundacion");
                    aeropuerto.CostoConstruccion = lector.GetDouble("costo_construccion");
                    aeropuerto.TipoAeropuerto = (TipoAeropuerto)Enum.Parse(typeof(TipoAeropuerto), lector.GetString("tipo_aeropuerto"));
                    aeropuerto.TieneSalaVIP = lector.GetBoolean("tiene_sala_vip");
                    aeropuerto.TieneWiFi = lector.GetBoolean("tiene_wifi");
                    aeropuerto.TieneSistemaGestionEquipaje = lector.GetBoolean("tiene_sistema_gestion_equipaje");
                    if (!lector.IsDBNull(lector.GetOrdinal("foto"))) aeropuerto.Foto = (byte[])lector["foto"];
                    aeropuertos.Add(aeropuerto);
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
            return aeropuertos;
        }
    }
}
