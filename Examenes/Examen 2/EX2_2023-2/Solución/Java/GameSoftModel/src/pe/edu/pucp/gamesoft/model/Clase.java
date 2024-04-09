package pe.edu.pucp.gamesoft.model;
public class Clase {
    private int idClase;
    private String claseMovimiento;
    private byte[] foto;
    private boolean activo;

    public int getIdClase() {
        return idClase;
    }

    public void setIdClase(int idClase) {
        this.idClase = idClase;
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

    public String getClaseMovimiento() {
        return claseMovimiento;
    }

    public void setClaseMovimiento(String claseMovimiento) {
        this.claseMovimiento = claseMovimiento;
    }
    
}