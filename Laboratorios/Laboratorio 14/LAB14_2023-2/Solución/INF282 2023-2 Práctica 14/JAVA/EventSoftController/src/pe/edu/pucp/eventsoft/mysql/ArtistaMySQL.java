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
import pe.edu.pucp.eventsoft.dao.ArtistaDAO;
import pe.edu.pucp.eventsoft.model.Artista;

/**
 *
 * @author alulab14
 */
public class ArtistaMySQL extends UnicastRemoteObject implements ArtistaDAO {
    
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    public ArtistaMySQL(int puerto) throws RemoteException{
        super(puerto);
    }

    @Override
    public ArrayList<Artista> listarPorNombre(String nombre) {
        ArrayList<Artista> artistas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ARTISTAS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Artista artista = new Artista();                
                artista.setIdArtista(rs.getInt("id_artista"));
                artista.setNombre(rs.getString("nombre_artista"));
                artista.setNacionalidad(rs.getString("nacionalidad_artista"));
                artistas.add(artista);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return artistas;
    }
}
