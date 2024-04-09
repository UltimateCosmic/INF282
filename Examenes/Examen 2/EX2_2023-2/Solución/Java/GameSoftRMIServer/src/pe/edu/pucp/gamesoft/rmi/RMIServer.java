/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.rmi;

import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.gamesoft.dao.BlancoDAO;
import pe.edu.pucp.gamesoft.dao.ClaseDAO;
import pe.edu.pucp.gamesoft.dao.MovimientoNivelDAO;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.dao.TipoElementalDAO;
import pe.edu.pucp.gamesoft.mysql.BlancoMySQL;
import pe.edu.pucp.gamesoft.mysql.ClaseMySQL;
import pe.edu.pucp.gamesoft.mysql.MovimientoNivelMySQL;
import pe.edu.pucp.gamesoft.mysql.PokemonMySQL;
import pe.edu.pucp.gamesoft.mysql.TipoElementalMySQL;

/**
 *
 * @author alulab14
 */
public class RMIServer {
    
    private static String IP = "127.0.0.1";
    private static String puerto = "1235";
    
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname",IP);
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            
            TipoElementalDAO daoTipoElemental = new TipoElementalMySQL(
                    Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoTipoElemental", daoTipoElemental);
            
            ClaseDAO daoClase = new ClaseMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoClase", daoClase);
            
            BlancoDAO daoBlanco = new BlancoMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoBlanco", daoBlanco);
            
            PokemonDAO daoPokemon = new PokemonMySQL(Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoPokemon", daoPokemon);
            
            MovimientoNivelDAO daoMovimientoNivel = new MovimientoNivelMySQL(
                    Integer.parseInt(puerto));
            Naming.rebind("//"+IP+":"+puerto+"/daoMovimientoNivel", daoMovimientoNivel);
            
            System.out.println("Se ha desplegado el servidor...");
        }catch(Exception ex){
            System.out.println(ex.getMessage()); 
        }
    }
}
