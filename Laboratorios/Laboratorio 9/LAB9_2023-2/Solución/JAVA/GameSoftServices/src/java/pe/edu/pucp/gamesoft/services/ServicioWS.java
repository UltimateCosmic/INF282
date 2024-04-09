/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.services;

import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import pe.edu.pucp.gamesoft.controller.dao.DesarrolladoraDAO;
import pe.edu.pucp.gamesoft.controller.dao.GeneroDAO;
import pe.edu.pucp.gamesoft.controller.dao.VideojuegoDAO;
import pe.edu.pucp.gamesoft.controller.mysql.DesarrolladoraMySQL;
import pe.edu.pucp.gamesoft.controller.mysql.GeneroMySQL;
import pe.edu.pucp.gamesoft.controller.mysql.VideojuegoMySQL;
import pe.edu.pucp.gamesoft.model.Desarrolladora;
import pe.edu.pucp.gamesoft.model.Genero;
import pe.edu.pucp.gamesoft.model.Videojuego;

/**
 *
 * @author alulab14
 */

@WebService(serviceName = "ServicioWS")
public class ServicioWS {
    
    private GeneroDAO daoGenero = new GeneroMySQL();
    private DesarrolladoraDAO daoDesarrolladora = new DesarrolladoraMySQL();
    private VideojuegoDAO daoVideojuego = new VideojuegoMySQL();
    
    @WebMethod(operationName = "listarTodasGeneros")
    public ArrayList<Genero> listarTodasGeneros() {
        ArrayList<Genero> generos = new ArrayList<>();
        try{
            generos = daoGenero.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return generos;
    }
    
    @WebMethod(operationName = "listarDesarrolladorasPorNombre")
    public ArrayList<Desarrolladora> listarDesarrolladorasPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Desarrolladora> desarrolladoras = new ArrayList<>();
        try{
            desarrolladoras = daoDesarrolladora.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return desarrolladoras;
    }
    
    @WebMethod(operationName = "insertarVideojuego")
    public int insertarVideojuego(@WebParam(name = "videojuego") Videojuego videojuego) {
        int resultado = 0;
        try{
            resultado = daoVideojuego.insertar(videojuego);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarVideojuegosPorNombre")
    public ArrayList<Videojuegos> listarVideojuegosPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Videojuegos> videojuegos = new ArrayList<>();
        try{
            videojuegos = daoVideojuego.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return videojuegos;
    }
}
