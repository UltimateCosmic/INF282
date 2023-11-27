/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.softproductions.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.model.SerieTelevision;

/**
 *
 * @author adalb
 */
public interface SerieTelevisionDAO extends Remote{
    int insertar(SerieTelevision serieTelevision) throws RemoteException;
    ArrayList<SerieTelevision> listarPorNombre(String nombre) throws RemoteException;
}
