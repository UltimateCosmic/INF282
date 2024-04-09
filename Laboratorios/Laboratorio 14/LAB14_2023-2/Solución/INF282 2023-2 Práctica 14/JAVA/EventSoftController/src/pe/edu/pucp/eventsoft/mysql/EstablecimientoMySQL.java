/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.eventsoft.mysql;

import java.beans.Statement;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.config.DBManager;
import pe.edu.pucp.eventsoft.dao.EstablecimientoDAO;
import pe.edu.pucp.eventsoft.model.Establecimiento;

/**
 *
 * @author alulab14
 */
public class EstablecimientoMySQL extends UnicastRemoteObject implements EstablecimientoDAO{

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    public EstablecimientoMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public ArrayList<Establecimiento> listarPorNombre(String nombre) {
        ArrayList<Establecimiento> establecimientos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESTABLECIMIENTOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Establecimiento establecimiento = new Establecimiento();                
                establecimiento.setIdEstablecimiento(rs.getInt("id_establecimiento"));
                establecimiento.setNombre(rs.getString("nombre_establecimiento"));
                establecimiento.setCapacidadAsientos(rs.getInt("capacidad_asientos"));
                establecimiento.setTieneEstacionamiento(rs.getBoolean("tiene_estacionamiento"));
                establecimientos.add(establecimiento);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return establecimientos;
    }
}
