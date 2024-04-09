package pe.edu.pucp.gamesoft.model;
public class MovimientoNivel {
    private int idMovimientoNivel;
    private TipoElemental tipo;
    private Clase clase;
    private Blanco blanco;
    private int nivelAprendizaje;
    private String nombreMovimiento;
    private int poder;
    private int exactitud;
    private int puntosPoder;
    private boolean activo;

    public int getIdMovimientoNivel() {
        return idMovimientoNivel;
    }

    public void setIdMovimientoNivel(int idMovimientoNivel) {
        this.idMovimientoNivel = idMovimientoNivel;
    }

    public TipoElemental getTipo() {
        return tipo;
    }

    public void setTipo(TipoElemental tipo) {
        this.tipo = tipo;
    }

    public Clase getClase() {
        return clase;
    }

    public void setClase(Clase clase) {
        this.clase = clase;
    }

    public Blanco getBlanco() {
        return blanco;
    }

    public void setBlanco(Blanco blanco) {
        this.blanco = blanco;
    }

    public int getNivelAprendizaje() {
        return nivelAprendizaje;
    }

    public void setNivelAprendizaje(int nivelAprendizaje) {
        this.nivelAprendizaje = nivelAprendizaje;
    }

    public String getNombreMovimiento() {
        return nombreMovimiento;
    }

    public void setNombreMovimiento(String nombreMovimiento) {
        this.nombreMovimiento = nombreMovimiento;
    }

    public int getPoder() {
        return poder;
    }

    public void setPoder(int poder) {
        this.poder = poder;
    }

    public int getExactitud() {
        return exactitud;
    }

    public void setExactitud(int exactitud) {
        this.exactitud = exactitud;
    }

    public int getPuntosPoder() {
        return puntosPoder;
    }

    public void setPuntosPoder(int puntosPoder) {
        this.puntosPoder = puntosPoder;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}