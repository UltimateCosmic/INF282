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
    public class EmpresaComercialMySQL : EmpresaComercialDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<EmpresaComercial> listarPorNombreCallsign(string nombreCallsign)
        {
            BindingList<EmpresaComercial> empresas = new BindingList<EmpresaComercial>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_EMPRESAS_COMERCIALES_X_NOMBRE_CALLSIGN";
                comando.Parameters.AddWithValue("_nombre_callsign", nombreCallsign);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {                    
                    if (lector.GetChar("fid_tipo_empresa_comercial")=='A')
                    {
                        Aerolinea aerolinea = new Aerolinea();
                        aerolinea.IdEmpresa = lector.GetInt32("id_empresa");
                        aerolinea.Nombre = lector.GetString("nombre");
                        aerolinea.Callsign = lector.GetString("callsign");
                        aerolinea.NumeroAviones = lector.GetInt32("numero_aviones");
                        aerolinea.Activa = true;
                        empresas.Add(aerolinea);
                    }
                    else if (lector.GetChar("fid_tipo_empresa_comercial") == 'R')
                    {
                        TiendaRetail tiendaRetail = new TiendaRetail();
                        tiendaRetail.IdEmpresa = lector.GetInt32("id_empresa");
                        tiendaRetail.Nombre = lector.GetString("nombre");                        
                        tiendaRetail.Callsign = lector.GetString("callsign");
                        tiendaRetail.CantidadEmpleados = lector.GetInt32("cantidad_empleados");
                        tiendaRetail.Activa = true;
                        empresas.Add(tiendaRetail); 
                    }
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
            return empresas;
        }

        public BindingList<EmpresaComercial> listarPorIdAeropuerto(int idAeropuerto)
        {
            BindingList<EmpresaComercial> empresas = new BindingList<EmpresaComercial>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_EMPRESAS_COMERCIALES_X_ID_AEROPUERTO";
                comando.Parameters.AddWithValue("_id_aeropuerto", idAeropuerto);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetChar("fid_tipo_empresa_comercial") == 'A')
                    {
                        Aerolinea aerolinea = new Aerolinea();
                        aerolinea.IdEmpresa = lector.GetInt32("id_empresa");
                        aerolinea.Nombre = lector.GetString("nombre");
                        aerolinea.Callsign = lector.GetString("callsign");
                        aerolinea.NumeroAviones = lector.GetInt32("numero_aviones");
                        aerolinea.Activa = true;
                        empresas.Add(aerolinea);
                    }
                    else if (lector.GetChar("fid_tipo_empresa_comercial") == 'R')
                    {
                        TiendaRetail tiendaRetail = new TiendaRetail();
                        tiendaRetail.IdEmpresa = lector.GetInt32("id_empresa");
                        tiendaRetail.Nombre = lector.GetString("nombre");
                        tiendaRetail.Callsign = lector.GetString("callsign");
                        tiendaRetail.CantidadEmpleados = lector.GetInt32("cantidad_empleados");
                        tiendaRetail.Activa = true;
                        empresas.Add(tiendaRetail);
                    }
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
            return empresas;
        }
    }
}
