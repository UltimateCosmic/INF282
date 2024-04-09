package pe.edu.pucp.eventsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.model.Artista;

public interface ArtistaDAO {
    ArrayList<Artista> listarPorNombre(String nombre) throws RemoteException;
}
