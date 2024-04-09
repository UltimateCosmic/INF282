/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.ClaseDAO;
import pe.edu.pucp.gamesoft.model.Clase;

/**
 *
 * @author alulab14
 */
public class ClaseMySQL extends UnicastRemoteObject implements ClaseDAO {
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    public ClaseMySQL(int puerto) throws RemoteException {
        super(puerto);
    }
    
    @Override
    public ArrayList<Clase> listarTodas() throws RemoteException {
        ArrayList<Clase> clases = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CLASES_MOVIMIENTO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Clase clase = new Clase();
                clase.setActivo(true);
                clase.setIdClase(rs.getInt("id_clase_movimiento"));
                clase.setClaseMovimiento(rs.getString("clase_movimiento"));
                clase.setFoto(rs.getBytes("foto_clase_movimiento"));
                clases.add(clase);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return clases;
    }
}
