/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.softproductions;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.softproductions.dao.CapituloDAO;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.dao.SerieTelevisionDAO;
import pe.edu.pucp.softproductions.model.Capitulo;
import pe.edu.pucp.softproductions.model.Director;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author adalb
 */
@WebService(serviceName = "ProductoraWS")
public class ProductoraWS {
    private static String IP = "localhost";
    private static String puerto = "1234";
    
    private ProductoraDAO daoProductora;
    private DirectorDAO daoDirector;
    private SerieTelevisionDAO daoSerieTelevision;
    private CapituloDAO daoCapitulo;
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarProductorasTodas")
    public ArrayList<Productora> listarProductorasTodas() {
        ArrayList<Productora> productoras = null;
        try{
            daoProductora = (ProductoraDAO) Naming.lookup("//" + IP + ":" + 
                    puerto + "/daoProductora");
            productoras = daoProductora.listarProductoras();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productoras;
    }
    
    @WebMethod(operationName = "listarDirectorPorNombre")
    public ArrayList<Director> listarDirectorPorNombre(@WebParam(name = "nombre")
            String nombre) {
        ArrayList<Director> directores = null;
        try{
            daoDirector = (DirectorDAO) Naming.lookup("//" + IP + ":" + 
                    puerto + "/daoDirector");
            directores = daoDirector.listarDirectorPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return directores;
    }
    
    @WebMethod(operationName = "insertarSerieTelevision")
    public int insertarSerieTelevision(@WebParam(name = "serieTelevision")
            SerieTelevision serieTelevision) {
        int resultado = 0;
        try{
            daoSerieTelevision = (SerieTelevisionDAO) Naming.lookup("//" + IP + ":" + 
                    puerto + "/daoSerieTelevision");
            resultado = daoSerieTelevision.insertar(serieTelevision);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPorNombre")
    public ArrayList<SerieTelevision> listarPorNombre(@WebParam(name = "nombre")
            String nombre) {
        ArrayList<SerieTelevision> seriesTelevision = null;
        try{
            daoSerieTelevision = (SerieTelevisionDAO) Naming.lookup("//" + IP + ":" + 
                    puerto + "/daoSerieTelevision");
            seriesTelevision = daoSerieTelevision.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return seriesTelevision;
    }
    
    @WebMethod(operationName = "listarPorIdSerie")
    public ArrayList<Capitulo> listarPorIdSerie(@WebParam(name = "idSerie")
            int idSerie) {
        ArrayList<Capitulo> capitulos = null;
        try{
            daoCapitulo = (CapituloDAO) Naming.lookup("//" + IP + ":" + 
                    puerto + "/daoCapitulo");
            capitulos = daoCapitulo.listarPorIdSerie(idSerie);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return capitulos;
    }
}
