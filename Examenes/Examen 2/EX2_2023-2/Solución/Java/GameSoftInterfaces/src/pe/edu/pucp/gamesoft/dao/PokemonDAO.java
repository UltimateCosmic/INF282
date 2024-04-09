package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Pokemon;
public interface PokemonDAO extends Remote {
    int insertar(Pokemon pokemon) throws RemoteException;
    ArrayList<Pokemon> listarPorNombre(String nombre) throws RemoteException;
}
