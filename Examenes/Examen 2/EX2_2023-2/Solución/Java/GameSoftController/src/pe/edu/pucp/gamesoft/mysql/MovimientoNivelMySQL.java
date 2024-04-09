/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.MovimientoNivelDAO;
import pe.edu.pucp.gamesoft.model.Blanco;
import pe.edu.pucp.gamesoft.model.Clase;
import pe.edu.pucp.gamesoft.model.MovimientoNivel;
import pe.edu.pucp.gamesoft.model.TipoElemental;

/**
 *
 * @author alulab14
 */
public class MovimientoNivelMySQL extends UnicastRemoteObject implements MovimientoNivelDAO {
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    public MovimientoNivelMySQL(int puerto) throws RemoteException {
        super(puerto);
    }

    @Override
    public ArrayList<MovimientoNivel> listarPorIdPokemon(int idPokemon) {
        ArrayList<MovimientoNivel> movimientosNivel = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MOVIMIENTO_NIVEL_X_ID_POKEMON(?)}");
            cs.setInt("_id_pokemon", idPokemon);
            rs = cs.executeQuery();
            while(rs.next()){                
                MovimientoNivel movimientoNivel = new MovimientoNivel();                
                movimientoNivel.setIdMovimientoNivel(rs.getInt("id_movimiento_nivel"));
                movimientoNivel.setTipo(new TipoElemental());
                movimientoNivel.getTipo().setIdTipoElemental(rs.getInt("fid_tipo"));
                movimientoNivel.getTipo().setNombre(rs.getString("nombre_tipo"));
                movimientoNivel.getTipo().setValorRojo(rs.getInt("valor_rojo"));
                movimientoNivel.getTipo().setValorVerde(rs.getInt("valor_verde"));
                movimientoNivel.getTipo().setValorAzul(rs.getInt("valor_azul"));
                movimientoNivel.getTipo().setFoto(rs.getBytes("foto_tipo"));
                movimientoNivel.setClase(new Clase());
                movimientoNivel.getClase().setIdClase(rs.getInt("fid_clase"));
                movimientoNivel.getClase().setClaseMovimiento(rs.getString("clase_movimiento"));
                movimientoNivel.getClase().setFoto(rs.getBytes("foto_clase_movimiento"));
                movimientoNivel.setBlanco(new Blanco());
                movimientoNivel.getBlanco().setIdBlanco(rs.getInt("fid_blanco"));
                movimientoNivel.getBlanco().setBlancoMovimiento(rs.getString("blanco_movimiento"));
                movimientoNivel.getBlanco().setDescripcion(rs.getString("descripcion_blanco_movimiento"));
                movimientoNivel.setNivelAprendizaje(rs.getInt("nivel_aprendizaje"));
                movimientoNivel.setNombreMovimiento(rs.getString("nombre_movimiento"));
                movimientoNivel.setPoder(rs.getInt("poder"));
                movimientoNivel.setExactitud(rs.getInt("exactitud"));
                movimientoNivel.setPuntosPoder(rs.getInt("puntos_poder"));                
                movimientoNivel.setActivo(true);
                movimientoNivel.getTipo().setActivo(true);
                movimientoNivel.getClase().setActivo(true);
                movimientoNivel.getBlanco().setActivo(true);                
                movimientosNivel.add(movimientoNivel);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return movimientosNivel;
    }
    
}
