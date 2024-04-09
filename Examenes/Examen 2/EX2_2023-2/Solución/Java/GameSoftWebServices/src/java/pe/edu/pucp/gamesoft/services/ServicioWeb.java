package pe.edu.pucp.gamesoft.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gamesoft.dao.BlancoDAO;
import pe.edu.pucp.gamesoft.dao.ClaseDAO;
import pe.edu.pucp.gamesoft.dao.MovimientoNivelDAO;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.dao.TipoElementalDAO;
import pe.edu.pucp.gamesoft.model.Blanco;
import pe.edu.pucp.gamesoft.model.Clase;
import pe.edu.pucp.gamesoft.model.MovimientoNivel;
import pe.edu.pucp.gamesoft.model.Pokemon;
import pe.edu.pucp.gamesoft.model.TipoElemental;

@WebService(serviceName = "ServicioWeb")
public class ServicioWeb {
    
    /*Coloque sus datos
    -------------------------------------------------
    Código PUCP: 20203350 
    Nombre Completo: Johan Carlo Amador Egoavil
    */

    private String IPServidor = "127.0.0.1";
    private String puerto = "1235";
    
    private TipoElementalDAO daoTipoElemental = null;
    private ClaseDAO daoClase = null;
    private BlancoDAO daoBlanco = null;
    private PokemonDAO daoPokemon = null;
    private MovimientoNivelDAO daoMovimientoNivel = null;
    
    @WebMethod(operationName = "listarTodosTiposElementales")
    public ArrayList<TipoElemental> listarTodosTiposElementales(){
        ArrayList<TipoElemental> tiposElementales = new ArrayList<>();
        try{
            daoTipoElemental = (TipoElementalDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoTipoElemental");
            tiposElementales = daoTipoElemental.listarTodos();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return tiposElementales;      
    }
    
    @WebMethod(operationName = "listarTodasClases")
    public ArrayList<Clase> listarTodasClases(){
        ArrayList<Clase> clases = new ArrayList<>();
        try{
            daoClase = (ClaseDAO) Naming.lookup("//"+ IPServidor + ":" + puerto 
                    +"/" + "daoClase");
            clases = daoClase.listarTodas();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return clases;      
    }
    
    @WebMethod(operationName = "listarBlancosPorNombre")
    public ArrayList<Blanco> listarBlancosPorNombre(
            @WebParam(name = "nombre")String nombre){
        ArrayList<Blanco> blancos = new ArrayList<>();
        try{
            daoBlanco = (BlancoDAO) Naming.lookup("//"+ IPServidor + ":" + puerto 
                    +"/" + "daoBlanco");
            blancos = daoBlanco.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return blancos;      
    }
    
    @WebMethod(operationName = "insertarPokemon")
    public int insertarPokemon(@WebParam(name = "pokemon")Pokemon pokemon){
        int resultado = 0;
        try{
            daoPokemon = (PokemonDAO) Naming.lookup("//"+ IPServidor + ":" + puerto 
                    +"/" + "daoPokemon");
            resultado = daoPokemon.insertar(pokemon);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;      
    }
    
    @WebMethod(operationName = "listarPokemonesPorNombre")
    public ArrayList<Pokemon> listarPokemonesPorNombre(
            @WebParam(name = "nombre")String nombre){
        ArrayList<Pokemon> pokemones = new ArrayList<>();
        try{
            daoPokemon = (PokemonDAO) Naming.lookup("//"+ IPServidor + ":" + puerto 
                    +"/" + "daoPokemon");
            pokemones = daoPokemon.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return pokemones;      
    }
    
    @WebMethod(operationName = "listarMovimientosNivelPorID")
    public ArrayList<MovimientoNivel> listarMovimientosNivelPorID(
            @WebParam(name = "idPokemon")int idPokemon){
        ArrayList<MovimientoNivel> movimientosNivel = new ArrayList<>();
        try{
            daoMovimientoNivel = (MovimientoNivelDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoMovimientoNivel");
            movimientosNivel = daoMovimientoNivel.listarPorIdPokemon(idPokemon);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return movimientosNivel;      
    }
}
