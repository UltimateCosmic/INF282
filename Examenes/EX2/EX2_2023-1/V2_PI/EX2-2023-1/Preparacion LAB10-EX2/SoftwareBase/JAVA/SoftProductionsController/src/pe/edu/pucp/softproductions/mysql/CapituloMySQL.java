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
import pe.edu.pucp.softproductions.dao.CapituloDAO;
import pe.edu.pucp.softproductions.model.Capitulo;
import pe.edu.pucp.softproductions.model.Director;

/**
 *
 * @author piero
 */
public class CapituloMySQL extends UnicastRemoteObject implements CapituloDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
        
    public CapituloMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    @Override
    public ArrayList<Capitulo> listarPorIdSerieTelevision(int idSerieTelevision) throws RemoteException {
       ArrayList<Capitulo> capitulos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CAPITULOS_X_ID_SERIE_TELEVISION(?)}");
            cs.setInt("_id_serie_television", idSerieTelevision);
            rs = cs.executeQuery();
            while(rs.next()){
                Capitulo capitulo = new Capitulo();
                capitulo.setIdCapitulo(rs.getInt("id_capitulo"));
                capitulo.setNumeroCapitulo(rs.getInt("numero_capitulo"));
                capitulo.setNombreCapitulo(rs.getString("nombre_capitulo"));
                capitulo.setDuracion(rs.getTime("duracion"));
                capitulo.setDirector(new Director());
                capitulo.getDirector().setIdDirector(rs.getInt("id_director"));
                capitulo.getDirector().setNombreDirector(rs.getString("nombre_director"));
                capitulo.getDirector().setApellidoDirector(rs.getString("apellido_director"));
                capitulo.getDirector().setNacionalidad(rs.getString("nacionalidad"));
                capitulo.getDirector().setActivo(true);
                capitulo.setActivo(true);
                capitulos.add(capitulo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return capitulos;
    }
    
}
