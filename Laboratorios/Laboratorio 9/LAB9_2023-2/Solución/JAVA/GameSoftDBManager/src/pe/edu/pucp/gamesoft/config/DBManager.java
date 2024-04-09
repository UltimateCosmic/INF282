/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.config;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author alulab14
 */
public class DBManager {
    private static DBManager dbManager;
    //Colocar datos de conexion
    private String url = "jdbc:mysql://db-lp2.cbjkpgavmonw.us-east-1.rds.amazonaws.com:3306/inf282?useSSL=false";
    private String user = "cosmodev";
    private String password = "inf282lp2binarysynergy";
    private Connection con;
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
    
    public Connection getConnection(){
        try{
            //Registrar el driver JDBC
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Realizar la conexión
            con = DriverManager.getConnection(url,user,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
}
