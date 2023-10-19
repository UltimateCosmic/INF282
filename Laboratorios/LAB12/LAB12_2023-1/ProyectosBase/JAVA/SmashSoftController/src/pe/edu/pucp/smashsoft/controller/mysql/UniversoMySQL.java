
package pe.edu.pucp.smashsoft.controller.mysql;

import com.mysql.cj.jdbc.CallableStatement;
import com.mysql.cj.xdevapi.Statement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.config.DBManager;
import pe.edu.pucp.smashsoft.controller.dao.UniversoDAO;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 * 
 * @author Johan Carlo Amador Egoavil
 */
public class UniversoMySQL implements UniversoDAO {

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;  
    
    @Override
    public ArrayList<Universo> listarPorNombre(String nombre) {
        ArrayList<Universo> universos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = (CallableStatement) con.prepareCall("{call LISTAR_UNIVERSOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Universo universo = new Universo();
                universo.setIdUniverso(rs.getInt("id_universo"));
                universo.setNombre(rs.getString("nombre"));
                universo.setActivo(true);
                universos.add(universo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return universos;
    }

}
