/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.mysql;

import java.beans.Statement;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.TipoElementalDAO;
import pe.edu.pucp.gamesoft.model.TipoElemental;

/**
 *
 * @author alulab14
 */
public class TipoElementalMySQL extends UnicastRemoteObject implements TipoElementalDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    public TipoElementalMySQL(int puerto) throws RemoteException {
        super(puerto);
    }
    
    @Override
    public ArrayList<TipoElemental> listarTodos() throws RemoteException {
        ArrayList<TipoElemental> tiposElementales = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TIPOS_ELEMENTALES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoElemental tipoElemental = new TipoElemental();
                tipoElemental.setActivo(true);
                tipoElemental.setIdTipoElemental(rs.getInt("id_tipo"));
                tipoElemental.setNombre(rs.getString("nombre_tipo"));
                tipoElemental.setValorRojo(rs.getInt("valor_rojo"));
                tipoElemental.setValorVerde(rs.getInt("valor_verde"));
                tipoElemental.setValorAzul(rs.getInt("valor_azul"));
                tipoElemental.setFoto(rs.getBytes("foto_tipo"));
                tiposElementales.add(tipoElemental);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return tiposElementales;
    }
}
