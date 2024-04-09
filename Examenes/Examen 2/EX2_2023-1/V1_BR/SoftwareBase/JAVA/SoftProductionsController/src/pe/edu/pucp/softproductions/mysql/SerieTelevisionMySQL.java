/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.softproductions.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.model.Capitulo;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author adalb
 */
public class SerieTelevisionMySQL extends UnicastRemoteObject implements SerieTelevisionDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    public SerieTelevisionMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public int insertar(SerieTelevision serieTelevision) throws RemoteException{
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_SERIE_TELEVISION(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_serie_television", java.sql.Types.INTEGER);
            cs.setInt("_fid_productora", serieTelevision.getProductora().getIdProductora());
            cs.setString("_fid_idioma_original", String.valueOf(serieTelevision.getIdioma()));
            cs.setString("_nombre_serie", serieTelevision.getNombreSerie());
            cs.setInt("_temporada", serieTelevision.getTemporada());
            cs.setDate("_fecha_emision", 
                    new java.sql.Date(serieTelevision.getFechaEmision().getTime()));
            cs.setDouble("_costo_produccion", serieTelevision.getCostoProduccion());
            cs.setString("_sipnosis", serieTelevision.getSipnosis());
            cs.setBytes("_portada", serieTelevision.getPortada());
            cs.executeUpdate();
            serieTelevision.setIdSerieTelevision(cs.getInt("_id_serie_television"));
            for(Capitulo cap : serieTelevision.getCapitulos()){
                con = DBManager.getInstance().getConnection();
                cs = con.prepareCall("{call INSERTAR_CAPITULO(?,?,?,?,?,?)}");
                cs.registerOutParameter("_id_capitulo", java.sql.Types.INTEGER);
                cs.setInt("_fid_serie_television", serieTelevision.getIdSerieTelevision());
                cs.setInt("_fid_director", cap.getDirector().getIdDirector());
                cs.setInt("_numero_capitulo", cap.getNumeroCapitulo());
                cs.setString("_nombre_capitulo", cap.getNombreCapitulo());
                cs.setTime("_duracion", cap.getDuracion());
                cs.executeUpdate();
                cap.setIdCapitulo(cs.getInt("_id_capitulo"));
            }
            resultado = serieTelevision.getIdSerieTelevision();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public ArrayList<SerieTelevision> listarPorNombre(String nombre) throws RemoteException{
        ArrayList<SerieTelevision> seriesTelevision = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SERIES_TELEVISION_X_NOMBRE(?)}");
            cs.setString("_nombre_serie", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                SerieTelevision serieTelevision = new SerieTelevision();
                serieTelevision.setIdSerieTelevision(rs.getInt("id_serie_television"));
                serieTelevision.setProductora(new Productora());
                serieTelevision.getProductora().setIdProductora(rs.getInt("id_productora"));
                serieTelevision.getProductora().setNombreProductora(rs.getString("nombre_productora"));
                serieTelevision.getProductora().setLogo(rs.getBytes("logo"));
                serieTelevision.getProductora().setR(rs.getInt("R"));
                serieTelevision.getProductora().setG(rs.getInt("G"));
                serieTelevision.getProductora().setB(rs.getInt("B"));
                String caracter = rs.getString("id_idioma");
                serieTelevision.setIdioma(caracter.charAt(0));
                serieTelevision.setNombreSerie(rs.getString("nombre_serie"));
                serieTelevision.setTemporada(rs.getInt("temporada"));
                serieTelevision.setFechaEmision(rs.getDate("fecha_emision"));
                serieTelevision.setCostoProduccion(rs.getDouble("costo_produccion"));
                serieTelevision.setSipnosis(rs.getString("sipnosis"));
                serieTelevision.setPortada(rs.getBytes("portada"));
                seriesTelevision.add(serieTelevision);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return seriesTelevision;
    }
}
