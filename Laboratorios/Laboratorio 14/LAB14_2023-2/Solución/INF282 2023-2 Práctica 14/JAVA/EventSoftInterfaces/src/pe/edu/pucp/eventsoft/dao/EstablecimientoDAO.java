package pe.edu.pucp.eventsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.model.Establecimiento;

public interface EstablecimientoDAO {
    ArrayList<Establecimiento> listarPorNombre(String nombre) throws RemoteException;
}
