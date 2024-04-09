/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.controller.dao.VideojuegoDAO;
import pe.edu.pucp.gamesoft.model.Desarrolladora;
import pe.edu.pucp.gamesoft.model.Genero;
import pe.edu.pucp.gamesoft.model.Videojuego;

/**
 *
 * @author alulab14
 */
public class VideojuegoMySQL implements VideojuegoDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;    
    
    @Override
    public int insertar(Videojuego videojuego) {        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_VIDEOJUEGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_videojuego", INTEGER);
            cs.setInt("_fid_desarrolladora", videojuego.getDesarrolladora().getIdDesarrolladora());
            cs.setInt("_fid_genero", videojuego.getGenero().getIdGenero());
            cs.setInt("_fid_clasificacion_ESRB", videojuego.getClasificacionESRB());
            cs.setString("_nombre", videojuego.getNombre());
            cs.setDate("_fecha_lanzamiento", new java.sql.Date(videojuego.getFechaLanzamiento().getTime()));
            cs.setDouble("_costo_desarrollo", videojuego.getCostoDesarrollo());
            cs.setBoolean("_version_playstation5", videojuego.isVersionPlaystation5());
            cs.setBoolean("_version_nintendo_switch", videojuego.isVersionNintendoSwitch());
            cs.setBoolean("_version_xbox_series", videojuego.isVersionXboxSeries());
            cs.setBoolean("_version_PC", videojuego.isVersionPC());
            cs.setBoolean("_version_smartphone", videojuego.isVersionSmartphone());
            cs.setBytes("_material_promocional_PDF", videojuego.getMaterialPromocionalPDF());
            cs.setBytes("_portada", videojuego.getPortada());            
            cs.executeUpdate();
            videojuego.setIdVideojuego(cs.getInt("_id_videojuego"));   
            resultado = videojuego.getIdVideojuego();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Videojuego> listarPorNombre(String nombre) {
        ArrayList<Videojuego> videojuegos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = (CallableStatement) con.prepareCall("{call LISTAR_VIDEOJUEGOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Videojuego videojuego = new Videojuego();
                videojuego.setIdVideojuego(rs.getInt("id_videojuego"));
                videojuego.setDesarrolladora(new Desarrolladora());
                videojuego.getDesarrolladora().setIdDesarrolladora(rs.getInt("id_desarrolladora"));
                videojuego.getDesarrolladora().setNombre(rs.getString("nombre_desarrolladora"));
                videojuego.getDesarrolladora().getPais().setIdPais(rs.getInt("id_pais_desarrolladora"));
                videojuego.setGenero(new Genero());  
                videojuego.getGenero().setIdGenero(rs.getInt("id_genero"));
                videojuego.getGenero().setNombre(rs.getString("nombre_genero"));
                videojuego.setClasificacionESRB((char) rs.getInt("id_clasificacion_ESRB"));
                videojuego.setNombre(rs.getString("nombre_videojuego"));
                videojuego.setFechaLanzamiento(rs.getDate("fecha_lanzamiento"));
                videojuego.setCostoDesarrollo(rs.getDouble("costo_desarrollo"));
                videojuego.setVersionPlaystation5(rs.getBoolean("version_playstation5"));
                videojuego.setVersionNintendoSwitch(rs.getBoolean("version_nintendo_switch"));
                videojuego.setVersionXboxSeries(rs.getBoolean("version_xbox_series"));
                videojuego.setVersionPC(rs.getBoolean("version_PC"));
                videojuego.setVersionSmartphone(rs.getBoolean("version_smartphone"));
                videojuego.setPortada(rs.getBytes("portada"));
                videojuego.setMaterialPromocionalPDF(rs.getBytes("material_promocional_PDF"));
                videojuegos.add(videojuego);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return videojuegos;
    }
}
