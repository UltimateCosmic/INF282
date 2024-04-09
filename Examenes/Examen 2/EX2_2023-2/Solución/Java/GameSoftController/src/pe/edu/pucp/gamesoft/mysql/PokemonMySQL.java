/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.model.Generacion;
import pe.edu.pucp.gamesoft.model.MovimientoNivel;
import pe.edu.pucp.gamesoft.model.Pokemon;

/**
 *
 * @author alulab14
 */
public class PokemonMySQL extends UnicastRemoteObject implements PokemonDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    public PokemonMySQL(int puerto) throws RemoteException {
        super(puerto);
    }
    
    @Override
    public int insertar(Pokemon pokemon) throws RemoteException {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_POKEMON(?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_pokemon", INTEGER);
            cs.setInt("_fid_tipo_1", pokemon.getTipo1().getIdTipoElemental());
            cs.setInt("_fid_tipo_2", pokemon.getTipo2().getIdTipoElemental());
            cs.setString("_numero_pokedex_nacional", pokemon.getNumeroPokedexNacional());
            cs.setString("_nombre", pokemon.getNombre());
            cs.setString("_generacion", pokemon.getGeneracion().toString());
            cs.setDouble("_peso", pokemon.getPeso());
            cs.setDouble("_altura", pokemon.getAltura());
            cs.setString("_descripcion", pokemon.getDescripcion());
            cs.setBytes("_foto", pokemon.getFoto());
            cs.executeUpdate();
            pokemon.setIdPokemon(cs.getInt("_id_pokemon")); 
            for(MovimientoNivel movimiento : pokemon.getMovimientosNivel()){
                cs = con.prepareCall("{call INSERTAR_MOVIMIENTO_NIVEL(?,?,?,?,?,?,?,?,?,?)}");
                cs.registerOutParameter("_id_movimiento_nivel", INTEGER);
                cs.setInt("_fid_pokemon", pokemon.getIdPokemon());
                cs.setInt("_fid_tipo", movimiento.getTipo().getIdTipoElemental());
                cs.setInt("_fid_clase", movimiento.getClase().getIdClase());
                cs.setInt("_fid_blanco", movimiento.getBlanco().getIdBlanco());
                cs.setInt("_nivel_aprendizaje", movimiento.getNivelAprendizaje());
                cs.setString("_nombre_movimiento", movimiento.getNombreMovimiento());
                cs.setInt("_poder", movimiento.getPoder());
                cs.setInt("_exactitud", movimiento.getExactitud());
                cs.setInt("_puntos_poder", movimiento.getPuntosPoder());
                cs.executeUpdate();
            }
            resultado =  pokemon.getIdPokemon();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Pokemon> listarPorNombre(String nombre) throws RemoteException {
        ArrayList<Pokemon> pokemones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_POKEMON_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){            
                Pokemon pokemon = new Pokemon();                
                pokemon.setIdPokemon(rs.getInt("id_pokemon"));
                pokemon.getTipo1().setIdTipoElemental(rs.getInt("fid_tipo_1"));
                pokemon.getTipo1().setNombre(rs.getString("tipo1_nombre_tipo"));
                pokemon.getTipo1().setValorRojo(rs.getInt("tipo1_valor_rojo"));
                pokemon.getTipo1().setValorVerde(rs.getInt("tipo1_valor_verde"));
                pokemon.getTipo1().setValorAzul(rs.getInt("tipo1_valor_azul"));
                pokemon.getTipo1().setFoto(rs.getBytes("tipo1_foto_tipo"));
                pokemon.getTipo2().setIdTipoElemental(rs.getInt("fid_tipo_2"));
                pokemon.getTipo2().setNombre(rs.getString("tipo2_nombre_tipo"));
                pokemon.getTipo2().setValorRojo(rs.getInt("tipo2_valor_rojo"));
                pokemon.getTipo2().setValorVerde(rs.getInt("tipo2_valor_verde"));
                pokemon.getTipo2().setValorAzul(rs.getInt("tipo2_valor_azul"));
                pokemon.getTipo2().setFoto(rs.getBytes("tipo2_foto_tipo"));
                pokemon.setNumeroPokedexNacional(rs.getString("numero_pokedex_nacional"));
                pokemon.setNombre(rs.getString("nombre"));
                pokemon.setGeneracion(Generacion.valueOf(rs.getString("generacion")));
                pokemon.setPeso(rs.getDouble("peso"));
                pokemon.setAltura(rs.getDouble("altura"));
                pokemon.setDescripcion(rs.getString("descripcion"));
                pokemon.setFoto(rs.getBytes("foto"));                
                pokemon.setActivo(true);
                pokemones.add(pokemon);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pokemones;
    }
}
