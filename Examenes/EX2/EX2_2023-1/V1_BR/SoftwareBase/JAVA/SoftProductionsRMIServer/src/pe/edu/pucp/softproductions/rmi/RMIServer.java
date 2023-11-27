/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.softproductions.rmi;

import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.softproductions.dao.CapituloDAO;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.mysql.CapituloMySQL;
import pe.edu.pucp.softproductions.mysql.DirectorMySQL;
import pe.edu.pucp.softproductions.mysql.ProductoraMySQL;
import pe.edu.pucp.softproductions.mysql.SerieTelevisionMySQL;

/**
 *
 * @author adalb
 */
public class RMIServer {
    private static String IP = "localhost";
    private static String puerto = "1234";
    
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname",IP);
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            
            ProductoraDAO daoProductora = new ProductoraMySQL(Integer.parseInt(puerto));
            Naming.rebind("//" + IP + ":" + puerto + "/daoProductora", daoProductora);
            
            DirectorDAO daoDirector = new DirectorMySQL(Integer.parseInt(puerto));
            Naming.rebind("//" + IP + ":" + puerto + "/daoDirector", daoDirector);
            
            SerieTelevisionDAO daoSerieTelevision = new SerieTelevisionMySQL(Integer.parseInt(puerto));
            Naming.rebind("//" + IP + ":" + puerto + "/daoSerieTelevision", daoSerieTelevision);
            
            CapituloDAO daoCapitulo = new CapituloMySQL(Integer.parseInt(puerto));
            Naming.rebind("//" + IP + ":" + puerto + "/daoCapitulo", daoCapitulo);
            
            System.out.println("Se ha desplegado el servidor...");
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
