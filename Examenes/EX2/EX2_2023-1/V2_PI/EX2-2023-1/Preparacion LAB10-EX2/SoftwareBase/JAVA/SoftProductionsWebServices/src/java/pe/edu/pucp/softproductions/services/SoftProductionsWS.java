/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.softproductions.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.softproductions.dao.CapituloDAO;
import pe.edu.pucp.softproductions.dao.DirectorDAO;
import pe.edu.pucp.softproductions.dao.ProductoraDAO;
import pe.edu.pucp.softproductions.dao.SerieDAO;
import pe.edu.pucp.softproductions.model.Capitulo;
import pe.edu.pucp.softproductions.model.Director;
import pe.edu.pucp.softproductions.model.Productora;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author piero
 */
@WebService(serviceName = "SoftProductionsWS")
public class SoftProductionsWS {

    private String IPServidor = "127.0.0.1";
    private String puerto = "1235";
    private ProductoraDAO daoProductora = null;
    private DirectorDAO daoDirector = null;
    private SerieDAO daoSerie = null;
    private CapituloDAO daoCapitulo = null;
    
    @WebMethod(operationName = "listarTodasProductoras")
    public ArrayList<Productora> listarTodasProductoras(){
        ArrayList<Productora> productoras = new ArrayList<>();
        try{
        daoProductora = (ProductoraDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoProductora");
        productoras = daoProductora.listarTodas();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productoras;      
    }
    
    @WebMethod(operationName = "listarTodosDirectores")
    public ArrayList<Director> listarTodosDirectores
                        (@WebParam(name = "nombre")String nombre){
        ArrayList<Director> directores = new ArrayList<>();
        try{
        daoDirector = (DirectorDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoDirector");
        directores = daoDirector.listarTodos(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return directores;      
    }
    
    @WebMethod(operationName = "insertarSerieTV")
    public int insertarSerieTV (@WebParam(name = "serie")SerieTelevision serie){
        int resultado = 0;
        try{
            daoSerie = (SerieDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoSerie");
            
            resultado = daoSerie.insertar(serie);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;  
     }
    
    
    @WebMethod(operationName = "listarSeriesXNombre")
    public ArrayList<SerieTelevision> listarSeriesXNombre
                        (@WebParam(name = "nombre")String nombre){
        ArrayList<SerieTelevision> series = new ArrayList<>();
        try{
        daoSerie = (SerieDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoSerie");
        series = daoSerie.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return series;      
    }
                        
    @WebMethod(operationName = "listarCapitulosXID")
    public ArrayList<Capitulo> listarCapitulosXID
                        (@WebParam(name = "idSerie")int idSerie){
        ArrayList<Capitulo> capitulos = new ArrayList<>();
        try{
        daoCapitulo = (CapituloDAO) Naming.lookup
        ("//"+ IPServidor + ":" + puerto +"/" + "daoCapitulo");
        capitulos = daoCapitulo.listarPorIdSerieTelevision(idSerie);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return capitulos;      
    }
    
}
