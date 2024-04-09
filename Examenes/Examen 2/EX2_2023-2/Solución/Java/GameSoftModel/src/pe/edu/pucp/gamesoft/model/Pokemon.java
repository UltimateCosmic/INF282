package pe.edu.pucp.gamesoft.model;
import java.util.ArrayList;
public class Pokemon {
    private int idPokemon;
    private ArrayList<MovimientoNivel> movimientosNivel;
    private TipoElemental tipo1;
    private TipoElemental tipo2;
    private String numeroPokedexNacional;
    private String nombre;
    private Generacion generacion;
    private double peso;
    private double altura;
    private String descripcion;
    private byte[] foto;
    private boolean activo;

    public int getIdPokemon() {
        return idPokemon;
    }

    public void setIdPokemon(int idPokemon) {
        this.idPokemon = idPokemon;
    }

    public ArrayList<MovimientoNivel> getMovimientosNivel() {
        return movimientosNivel;
    }

    public void setMovimientosNivel(ArrayList<MovimientoNivel> movimientosNivel) {
        this.movimientosNivel = movimientosNivel;
    }

    public TipoElemental getTipo1() {
        return tipo1;
    }

    public void setTipo1(TipoElemental tipo1) {
        this.tipo1 = tipo1;
    }

    public TipoElemental getTipo2() {
        return tipo2;
    }

    public void setTipo2(TipoElemental tipo2) {
        this.tipo2 = tipo2;
    }

    public String getNumeroPokedexNacional() {
        return numeroPokedexNacional;
    }

    public void setNumeroPokedexNacional(String numeroPokedexNacional) {
        this.numeroPokedexNacional = numeroPokedexNacional;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Generacion getGeneracion() {
        return generacion;
    }

    public void setGeneracion(Generacion generacion) {
        this.generacion = generacion;
    }
    
}