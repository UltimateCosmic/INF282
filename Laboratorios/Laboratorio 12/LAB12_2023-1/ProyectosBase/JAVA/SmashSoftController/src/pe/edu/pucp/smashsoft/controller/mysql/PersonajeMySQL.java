
package pe.edu.pucp.smashsoft.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import pe.edu.pucp.smashsoft.config.DBManager;
import pe.edu.pucp.smashsoft.controller.dao.PersonajeDAO;
import pe.edu.pucp.smashsoft.model.Personaje;

/**
 * 
 * @author Johan Carlo Amador Egoavil
 */
public class PersonajeMySQL implements PersonajeDAO {
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override    
    public int insertar(Personaje personaje) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PERSONAJE(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_personaje", java.sql.Types.INTEGER);
            cs.setInt("_fid_universo", personaje.getUniverso().getIdUniverso());
            cs.setInt("_fid_plataforma_origen", personaje.getPlataforma().getIdPlataforma());
            cs.setString("_nombre", personaje.getNombre());
            cs.setDate("_fecha_aparicion", new java.sql.Date(personaje.getFechaAparicion().getTime()));
            cs.setDouble("_peso", personaje.getPeso());
            cs.setDouble("_velocidad_caminar", personaje.getVelocidadAlCaminar());
            cs.setDouble("_velocidad_correr", personaje.getVelocidadAlCorrer());
            cs.setInt("_cantidad_max_saltos", personaje.getCantidadMaxSaltos());
            cs.setBoolean("_salto_pared", personaje.isSaltoPared());
            cs.setBoolean("_adhesion_paredes", personaje.isAdhesionParedes());
            cs.setBoolean("_arrastre", personaje.isArrastre());
            cs.setString("_descripcion", personaje.getDescripcion());
            cs.setBytes("_foto", personaje.getFoto());  
            cs.executeUpdate();
            personaje.setIdPersonaje(cs.getInt("_id_personaje"));   
            resultado = personaje.getIdPersonaje();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
}
