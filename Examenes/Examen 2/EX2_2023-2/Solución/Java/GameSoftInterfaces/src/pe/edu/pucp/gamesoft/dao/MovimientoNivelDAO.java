package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.MovimientoNivel;
public interface MovimientoNivelDAO extends Remote {
    ArrayList<MovimientoNivel> listarPorIdPokemon(int idPokemon) throws RemoteException;
}
