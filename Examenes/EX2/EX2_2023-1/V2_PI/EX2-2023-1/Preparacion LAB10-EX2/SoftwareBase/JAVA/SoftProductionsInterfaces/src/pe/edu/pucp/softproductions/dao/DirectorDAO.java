/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.softproductions.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.model.Director;

/**
 *
 * @author piero
 */
public interface DirectorDAO extends Remote{
    ArrayList<Director> listarTodos(String nombre) throws RemoteException;
}
