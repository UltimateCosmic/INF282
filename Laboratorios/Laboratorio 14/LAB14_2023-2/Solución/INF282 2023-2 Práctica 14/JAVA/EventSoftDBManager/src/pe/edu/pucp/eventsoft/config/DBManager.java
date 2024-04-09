package pe.edu.pucp.eventsoft.config;
import java.sql.Connection;
import java.sql.DriverManager;
public class DBManager {
    private Connection con;
    private static DBManager dbManager;
    private String url = "jdbc:mysql://"+
            "db-lp2.cbjkpgavmonw.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "inf282?useSSL=false";;
    private String username = "cosmodev";
    private String password = "inf282lp2binarysynergy";
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url, username, password);     
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
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
}