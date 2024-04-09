package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.TipoElemental;
public interface TipoElementalDAO extends Remote {
    ArrayList<TipoElemental> listarTodos() throws RemoteException;
}
