package pe.edu.pucp.softproductions.config;
import java.sql.Connection;
import java.sql.DriverManager;
public class DBManager {
    
    private static DBManager dbManager;
    private String url = "jdbc:mysql://"+
            "lp2-labs-inf282-2023-2.cixu5c91ndpr.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "PreparacionFinal?useSSL=false";
    private String user = "master";
    private String password = "lp2labsinf282";
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
