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
import pe.edu.pucp.gamesoft.controller.dao.GeneroDAO;
import pe.edu.pucp.gamesoft.model.Genero;

/**
 *
 * @author alulab14
 */
public class GeneroMySQL implements GeneroDAO {
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<Genero> listarTodos() {
        ArrayList<Genero> generos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = (CallableStatement) con.prepareCall("{call LISTAR_GENEROS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Genero genero = new Genero();
                genero.setIdGenero(rs.getInt("id_genero"));
                genero.setNombre(rs.getString("nombre"));
                generos.add(genero);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return generos;
    }
    
}
