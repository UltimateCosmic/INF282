package pe.edu.pucp.softproductions.mysql;

import java.beans.Statement;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.config.DBManager;
import pe.edu.pucp.softproductions.model.Productora;


public class ProductoraMySQL extends UnicastRemoteObject implements ProductoraDAO{

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    
    public ProductoraMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    @Override
    public ArrayList<Productora> listarTodas() throws RemoteException{
        ArrayList<Productora> productoras = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTORAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Productora productora = new Productora();
                productora.setIdProductora(rs.getInt("id_productora"));
                productora.setActiva(true);
                productora.setR(rs.getInt("R"));
                productora.setG(rs.getInt("G"));
                productora.setB(rs.getInt("B"));
                productora.setLogo(rs.getBytes("logo"));
                productora.setNombreProductora(rs.getString("nombre_productora"));
                productoras.add(productora);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return productoras;
    }
    
    
    
    
    
    
}
