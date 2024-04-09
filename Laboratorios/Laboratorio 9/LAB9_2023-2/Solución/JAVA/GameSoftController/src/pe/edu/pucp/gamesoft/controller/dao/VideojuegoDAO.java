/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Videojuego;

/**
 *
 * @author alulab14
 */
public interface VideojuegoDAO {
    int insertar(Videojuego videojuego);
    ArrayList<Videojuego> listarPorNombre(String nombre);
}
