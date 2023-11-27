/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.softproductions.mysql;

import java.beans.Statement;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.model.Director;

/**
 *
 * @author piero
 */
public class DirectorMySQL extends UnicastRemoteObject implements DirectorDAO{

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
        
    public DirectorMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public ArrayList<Director> listarTodos(String nombre) throws RemoteException {
        ArrayList<Director> directores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DIRECTOR_X_NOMBRE(?)}");
            cs.setString("_nombre_apellido", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Director director = new Director();
                director.setIdDirector(rs.getInt("id_director"));
                director.setNombreDirector(rs.getString("nombre_director"));
                director.setApellidoDirector(rs.getString("apellido_director"));
                director.setNacionalidad(rs.getString("nacionalidad"));
                director.setActivo(true);
                directores.add(director);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return directores;
    }
          
}
