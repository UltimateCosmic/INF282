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
    public class OperadoraMySQL : OperadoraDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<Operadora> listarPorNombre(string nombre)
        {
            BindingList<Operadora> operadoras = new BindingList<Operadora>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_OPERADORAS_X_NOMBRE";
                comando.Parameters.AddWithValue("_nombre", nombre);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Operadora operadora = new Operadora();
                    operadora.IdEmpresa = lector.GetInt32("id_empresa");
                    operadora.Nombre = lector.GetString("nombre");
                    operadora.OfreceSoporteLogistico = lector.GetBoolean("ofrece_soporte_logistico");
                    operadora.OfreceAsistenciaNavegacion = lector.GetBoolean("ofrece_asistencia_navegacion");
                    operadoras.Add(operadora);
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
            return operadoras;
        }
    }
}
