/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.eventsoft.rmi;

import java.rmi.Naming;
import java.rmi.Remote;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.eventsoft.dao.ArtistaDAO;
import pe.edu.pucp.eventsoft.dao.EstablecimientoDAO;
import pe.edu.pucp.eventsoft.dao.EventoDAO;
import pe.edu.pucp.eventsoft.mysql.ArtistaMySQL;
import pe.edu.pucp.eventsoft.mysql.EstablecimientoMySQL;
import pe.edu.pucp.eventsoft.mysql.EventoMySQL;

/**
 *
 * @author alulab14
 */
public class RMIServer {
    private static String IP = "127.0.0.1";
    private static String puerto = "1234";
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname",IP);
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            ArtistaDAO daoArtista = new ArtistaMySQL(Integer.parseInt(puerto));
            EstablecimientoDAO daoEstablecimiento = new EstablecimientoMySQL(Integer.parseInt(puerto));
            EventoDAO daoEvento = new EventoMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoArtista", (Remote) daoArtista);
            Naming.rebind("//"+IP+":"+puerto+"/daoEstablecimiento", (Remote) daoEstablecimiento);
            Naming.rebind("//"+IP+":"+puerto+"/daoEvento", (Remote) daoEvento);
            System.out.println("Se ha desplegado el servidor...");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
