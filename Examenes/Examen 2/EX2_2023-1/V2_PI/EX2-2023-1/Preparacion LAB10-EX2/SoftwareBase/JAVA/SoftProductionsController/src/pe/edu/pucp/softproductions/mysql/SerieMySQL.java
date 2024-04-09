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
import java.sql.Date;
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.dao.SerieDAO;
import pe.edu.pucp.softproductions.model.Capitulo;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author piero
 */
public class SerieMySQL extends UnicastRemoteObject implements SerieDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
        
    public SerieMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    @Override
    public int insertar(SerieTelevision serie) throws RemoteException {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_SERIE_TELEVISION(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_serie_television", INTEGER);
            cs.setInt("_fid_productora",serie.getProductora().getIdProductora());
            cs.setString("_fid_idioma_original", String.valueOf(serie.getIdioma()));
            cs.setString("_nombre_serie", serie.getNombreSerie());
            cs.setInt("_temporada", serie.getTemporada());
            cs.setDate("_fecha_emision", new java.sql.Date(serie.getFechaEmision().getTime()));
            cs.setDouble("_costo_produccion",serie.getCostoProduccion());
            cs.setString("_sipnosis",serie.getSipnosis());
            cs.setBytes("_portada",serie.getPortada());
            cs.executeUpdate();
            serie.setIdSerieTelevision(cs.getInt("_id_serie_television")); 
            
            for(Capitulo capitulo : serie.getCapitulos()){
                cs = con.prepareCall("{call INSERTAR_CAPITULO(?,?,?,?,?,?)}");
                cs.registerOutParameter("_id_capitulo", INTEGER);
                cs.setInt("_fid_serie_television",serie.getIdSerieTelevision());
                cs.setInt("_fid_director", capitulo.getDirector().getIdDirector());
                cs.setInt("_numero_capitulo",capitulo.getNumeroCapitulo() );
                cs.setString("_nombre_capitulo", capitulo.getNombreCapitulo());
                cs.setTime("_duracion", capitulo.getDuracion());
                cs.executeUpdate();
            }
            resultado =  serie.getIdSerieTelevision();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<SerieTelevision> listarPorNombre(String nombre) throws RemoteException {
        ArrayList<SerieTelevision> series = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SERIES_TELEVISION_X_NOMBRE(?)}");
            cs.setString("_nombre_serie", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                SerieTelevision serie = new SerieTelevision();
                serie.setIdSerieTelevision(rs.getInt("id_serie_television"));
                serie.setProductora(new Productora());
                serie.getProductora().setActiva(true);
                serie.getProductora().setIdProductora(rs.getInt("id_productora"));
                serie.getProductora().setNombreProductora(rs.getString("nombre_productora"));
                serie.getProductora().setLogo(rs.getBytes("logo"));
                serie.getProductora().setR(rs.getInt("R"));
                serie.getProductora().setG(rs.getInt("G"));
                serie.getProductora().setB(rs.getInt("B"));
                serie.setIdioma((rs.getString("id_idioma")).charAt(0));
                serie.setNombreSerie(rs.getString("nombre_serie"));
                serie.setTemporada(rs.getInt("temporada"));
                serie.setSipnosis(rs.getString("sipnosis"));
                serie.setPortada(rs.getBytes("portada"));
                serie.setCostoProduccion(rs.getDouble("costo_produccion"));
                serie.setActiva(true);
                series.add(serie);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return series;
    }
    
    
    
}
