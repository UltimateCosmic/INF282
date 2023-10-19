package pe.edu.pucp.smashsoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.smashsoft.controller.dao.PersonajeDAO;
import pe.edu.pucp.smashsoft.controller.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.controller.dao.UniversoDAO;
import pe.edu.pucp.smashsoft.controller.mysql.PersonajeMySQL;
import pe.edu.pucp.smashsoft.controller.mysql.PlataformaMySQL;
import pe.edu.pucp.smashsoft.controller.mysql.UniversoMySQL;
import pe.edu.pucp.smashsoft.model.Personaje;
import pe.edu.pucp.smashsoft.model.Plataforma;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 *
 * @author Johan Carlo Amador Egoavil
 */
@WebService(serviceName = "ServicioWS")
public class ServicioWS {

    private PlataformaDAO daoPlataforma = new PlataformaMySQL();
    private UniversoDAO daoUniverso = new UniversoMySQL();
    private PersonajeDAO daoPersonaje = new PersonajeMySQL();
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarTodas")
    public ArrayList<Plataforma> listarTodas() {
        ArrayList<Plataforma> plataformas = new ArrayList<>();
        try{
            plataformas = daoPlataforma.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return plataformas;
    }
    
    @WebMethod(operationName = "listarPorNombre")
    public ArrayList<Universo> listarPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Universo> universos = new ArrayList<>();
        try{
            universos = daoUniverso.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return universos;
    }
    
    @WebMethod(operationName = "insertar")
    public int insertar(@WebParam(name = "personaje") Personaje personaje) {       
        int resultado = 0;
        try{
            resultado = daoPersonaje.insertar(personaje);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
