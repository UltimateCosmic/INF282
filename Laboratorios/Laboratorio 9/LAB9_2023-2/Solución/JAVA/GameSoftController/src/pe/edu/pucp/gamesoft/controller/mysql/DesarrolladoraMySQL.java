/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.controller.dao.DesarrolladoraDAO;
import pe.edu.pucp.gamesoft.model.Desarrolladora;
import pe.edu.pucp.gamesoft.model.Pais;

/**
 *
 * @author alulab14
 */
public class DesarrolladoraMySQL implements DesarrolladoraDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<Desarrolladora> listarPorNombre(String nombre) {
        ArrayList<Desarrolladora> desarrolladoras = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = (CallableStatement) con.prepareCall("{call LISTAR_DESARROLLADORAS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Desarrolladora desarrolladora = new Desarrolladora();
                desarrolladora.setIdDesarrolladora(rs.getInt("id_desarrolladora"));
                desarrolladora.setPais(new Pais());
                desarrolladora.getPais().setIdPais(rs.getInt("id_pais"));
                desarrolladora.setNombre(rs.getString("nombre_desarrolladora"));
                desarrolladoras.add(desarrolladora);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return desarrolladoras;
    }
    
}
