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
import pe.edu.pucp.gamesoft.dao.BlancoDAO;
import pe.edu.pucp.gamesoft.model.Blanco;

/**
 *
 * @author alulab14
 */
public class BlancoMySQL extends UnicastRemoteObject implements BlancoDAO {
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    public BlancoMySQL(int puerto) throws RemoteException {
        super(puerto);
    }
    
    @Override
    public ArrayList<Blanco> listarPorNombre(String nombre) throws RemoteException {
        ArrayList<Blanco> blancos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BLANCOS_MOVIMIENTO_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){                
                Blanco blanco = new Blanco();                
                blanco.setIdBlanco(rs.getInt("id_blanco_movimiento"));
                blanco.setBlancoMovimiento(rs.getString("blanco_movimiento"));
                blanco.setDescripcion(rs.getString("descripcion_blanco_movimiento"));
                blanco.setActivo(true);
                blancos.add(blanco);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return blancos;
    }
    
}
