package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Blanco;
public interface BlancoDAO extends Remote {
    ArrayList<Blanco> listarPorNombre(String nombre) throws RemoteException;
}