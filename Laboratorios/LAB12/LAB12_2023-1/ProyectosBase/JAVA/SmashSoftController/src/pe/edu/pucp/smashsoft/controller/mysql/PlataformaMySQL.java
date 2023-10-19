
package pe.edu.pucp.smashsoft.controller.mysql;

import com.mysql.cj.jdbc.CallableStatement;
import com.mysql.cj.xdevapi.Statement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.config.DBManager;
import pe.edu.pucp.smashsoft.controller.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.model.Plataforma;

/**
 * 
 * @author Johan Carlo Amador Egoavil
 */
public class PlataformaMySQL implements PlataformaDAO {
    
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;    
    
    @Override
    public ArrayList<Plataforma> listarTodas() {
        ArrayList<Plataforma> plataformas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = (CallableStatement) con.prepareCall("{call LISTAR_PLATAFORMAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Plataforma plataforma = new Plataforma();
                plataforma.setIdPlataforma(rs.getInt("id_plataforma"));
                plataforma.setNombre(rs.getString("nombre"));
                plataforma.setActivo(true);
                plataformas.add(plataforma);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return plataformas;
    }
}
