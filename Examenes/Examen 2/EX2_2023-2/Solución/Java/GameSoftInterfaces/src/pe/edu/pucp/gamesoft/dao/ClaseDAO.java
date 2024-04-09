package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Clase;
public interface ClaseDAO extends Remote {
    ArrayList<Clase> listarTodas() throws RemoteException;
}
