package pe.edu.pucp.eventsoft.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.eventsoft.dao.ArtistaDAO;
import pe.edu.pucp.eventsoft.dao.EstablecimientoDAO;
import pe.edu.pucp.eventsoft.dao.EventoDAO;
import pe.edu.pucp.eventsoft.model.Artista;
import pe.edu.pucp.eventsoft.model.Establecimiento;
import pe.edu.pucp.eventsoft.model.Evento;

@WebService(serviceName = "ServicioWeb")
public class ServicioWeb {

    /* Coloque su nombre y código
    ----------------------------------------------------------------
    Nombre Completo: Johan Carlo Amador Egoavil
    Código PUCP: 20203350
    */
    
    private String IPServidor = "127.0.0.1";
    private String puerto = "1234";
    private ArtistaDAO daoArtista = null;
    private EstablecimientoDAO daoEstablecimiento = null;
    private EventoDAO daoEvento = null;
    
    @WebMethod(operationName = "listarArtistasPorNombre")
    public ArrayList<Artista> listarArtistasPorNombre(@WebParam(name = "nombre") 
            String nombre) {
        ArrayList<Artista> artistas = new ArrayList<>();
        try{
            daoArtista = (ArtistaDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoArtista");
            artistas = daoArtista.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return artistas;
    }    
    
    @WebMethod(operationName = "listarEstablecimientosPorNombre")
    public ArrayList<Establecimiento> listarEstablecimientosPorNombre(@WebParam
            (name = "nombre") String nombre) {
        ArrayList<Establecimiento> establecimientos = new ArrayList<>();
        try{
            daoEstablecimiento = (EstablecimientoDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoEstablecimiento");
            establecimientos = daoEstablecimiento.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return establecimientos;
    }    
    
    @WebMethod(operationName = "insertarEvento")
    public int insertarEvento(@WebParam (name = "evento") Evento evento) {
        int resultado = 0;
        try{
            daoEvento = (EventoDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoEvento");
            resultado = daoEvento.insertar(evento);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }    

    @WebMethod(operationName = "listarEventosPorNombre")
    public ArrayList<Evento> listarEventosPorNombre(@WebParam
            (name = "nombre") String nombre) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            daoEvento = (EventoDAO) Naming.lookup
                ("//"+ IPServidor + ":" + puerto +"/" + "daoEvento");
            eventos = daoEvento.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return eventos;
    }        
}
