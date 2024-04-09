package pe.edu.pucp.gamesoft.model;
public class TipoElemental {
    private int idTipoElemental;
    private String nombre;
    private int valorRojo;
    private int valorVerde;
    private int valorAzul;
    private byte[] foto;
    private boolean activo;

    public int getIdTipoElemental() {
        return idTipoElemental;
    }

    public void setIdTipoElemental(int idTipoElemental) {
        this.idTipoElemental = idTipoElemental;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getValorRojo() {
        return valorRojo;
    }

    public void setValorRojo(int valorRojo) {
        this.valorRojo = valorRojo;
    }

    public int getValorVerde() {
        return valorVerde;
    }

    public void setValorVerde(int valorVerde) {
        this.valorVerde = valorVerde;
    }

    public int getValorAzul() {
        return valorAzul;
    }

    public void setValorAzul(int valorAzul) {
        this.valorAzul = valorAzul;
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
    
}