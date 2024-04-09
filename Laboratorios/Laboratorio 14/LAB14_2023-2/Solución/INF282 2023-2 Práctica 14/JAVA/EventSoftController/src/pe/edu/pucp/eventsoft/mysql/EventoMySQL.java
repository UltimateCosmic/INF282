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
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.config.DBManager;
import pe.edu.pucp.eventsoft.dao.EventoDAO;
import pe.edu.pucp.eventsoft.model.Artista;
import pe.edu.pucp.eventsoft.model.Establecimiento;
import pe.edu.pucp.eventsoft.model.Evento;
import pe.edu.pucp.eventsoft.model.TipoEvento;

/**
 *
 * @author alulab14
 */
public class EventoMySQL extends UnicastRemoteObject implements EventoDAO {

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    public EventoMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public int insertar(Evento evento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_EVENTO(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_evento", INTEGER);            
            cs.setInt("_fid_establecimiento", evento.getEstablecimiento().getIdEstablecimiento());
            cs.setInt("_fid_artista", evento.getArtista().getIdArtista());
            cs.setString("_nombre_evento", evento.getNombre());
            cs.setString("_tipo_evento", evento.getTipoEvento().toString());
            cs.setDate("_fecha_evento", new java.sql.Date(evento.getFechaEvento().getTime()));
            cs.setTime("_hora_evento", evento.getHoraEvento());
            cs.setDouble("_costo_realizacion",evento.getCostoRealizacion());
            cs.setInt("_cantidad_entradas_disponibles", evento.getCantidadEntradasDisponibles());
            cs.setString("_descripcion_evento", evento.getDescripcion());
            cs.setBytes("_foto", evento.getFoto());
            cs.executeUpdate();
            evento.setIdEvento(cs.getInt("_id_evento"));   
            resultado = evento.getIdEvento();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Evento> listarPorNombre(String nombre) throws RemoteException {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVENTOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();                
                evento.setIdEvento(rs.getInt("ev.id_evento"));
                evento.setEstablecimiento(new Establecimiento());
                evento.getEstablecimiento().setIdEstablecimiento(rs.getInt("est.id_establecimiento"));
                evento.getEstablecimiento().setNombre(rs.getString("est.nombre_establecimiento"));
                evento.getEstablecimiento().setCapacidadAsientos(rs.getInt("est.capacidad_asientos"));
                evento.getEstablecimiento().setTieneEstacionamiento(rs.getBoolean("est.tiene_estacionamiento"));
                evento.setArtista(new Artista());
                evento.getArtista().setIdArtista(rs.getInt("art.id_artista"));
                evento.getArtista().setNombre(rs.getString("art.nombre_artista"));
                evento.getArtista().setNacionalidad(rs.getString("art.nacionalidad_artista"));
                evento.setNombre(rs.getString("ev.nombre_evento"));               
                evento.setTipoEvento(TipoEvento.valueOf(rs.getString("ev.tipo_evento")));
                evento.setFechaEvento(rs.getDate("ev.fecha_evento"));
                evento.setHoraEvento(rs.getTime("ev.hora_evento")); 
                evento.setCostoRealizacion(rs.getDouble("ev.costo_realizacion"));
                evento.setCantidadEntradasDisponibles(rs.getInt("ev.cantidad_entradas_disponibles"));
                evento.setDescripcion(rs.getString("ev.descripcion_evento"));
                evento.setFoto(rs.getBytes("foto"));                        
                eventos.add(evento);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return eventos;
    }
}
