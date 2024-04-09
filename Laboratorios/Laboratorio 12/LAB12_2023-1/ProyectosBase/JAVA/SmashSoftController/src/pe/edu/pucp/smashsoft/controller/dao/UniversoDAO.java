
package pe.edu.pucp.smashsoft.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 * 
 * @author Johan Carlo Amador Egoavil
 */
public interface UniversoDAO {
    ArrayList<Universo> listarPorNombre(String nombre);
}
