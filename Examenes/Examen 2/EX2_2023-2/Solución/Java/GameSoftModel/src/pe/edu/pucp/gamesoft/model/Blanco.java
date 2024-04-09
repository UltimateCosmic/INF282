package pe.edu.pucp.gamesoft.model;
public class Blanco {
    private int idBlanco;
    private String blancoMovimiento;
    private String descripcion;
    private boolean activo;

    public int getIdBlanco() {
        return idBlanco;
    }

    public void setIdBlanco(int idBlanco) {
        this.idBlanco = idBlanco;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getBlancoMovimiento() {
        return blancoMovimiento;
    }

    public void setBlancoMovimiento(String blancoMovimiento) {
        this.blancoMovimiento = blancoMovimiento;
    }

}