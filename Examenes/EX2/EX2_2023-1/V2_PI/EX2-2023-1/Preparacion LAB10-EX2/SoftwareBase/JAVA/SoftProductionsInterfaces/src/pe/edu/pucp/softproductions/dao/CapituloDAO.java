/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.softproductions.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.softproductions.model.Capitulo;

/**
 *
 * @author piero
 */
public interface CapituloDAO extends Remote{
    ArrayList<Capitulo> listarPorIdSerieTelevision(int idSerieTelevision)
            throws RemoteException;
}
