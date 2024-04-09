package pe.edu.pucp.eventsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.model.Evento;

public interface EventoDAO {
    int insertar(Evento evento) ;
    ArrayList<Evento> listarPorNombre(String nombre) throws RemoteException;
}
