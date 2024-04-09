package pe.edu.pucp.gamesoft.model;
import java.util.Date;
public class Videojuego {
    private int idVideojuego;
    private Desarrolladora desarrolladora;
    private Genero genero;
    private char clasificacionESRB;
    private String nombre;
    private Date fechaLanzamiento;
    private double costoDesarrollo;
    private boolean versionPlaystation5;
    private boolean versionNintendoSwitch;
    private boolean versionXboxSeries;
    private boolean versionPC;
    private boolean versionSmartphone;
    private byte[] materialPromocionalPDF;
    private byte[] portada;
    private boolean activo;

    public int getIdVideojuego() {
        return idVideojuego;
    }

    public void setIdVideojuego(int idVideojuego) {
        this.idVideojuego = idVideojuego;
    }

    public Desarrolladora getDesarrolladora() {
        return desarrolladora;
    }

    public void setDesarrolladora(Desarrolladora desarrolladora) {
        this.desarrolladora = desarrolladora;
    }

    public Genero getGenero() {
        return genero;
    }

    public void setGenero(Genero genero) {
        this.genero = genero;
    }

    public char getClasificacionESRB() {
        return clasificacionESRB;
    }

    public void setClasificacionESRB(char clasificacionESRB) {
        this.clasificacionESRB = clasificacionESRB;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Date getFechaLanzamiento() {
        return fechaLanzamiento;
    }

    public void setFechaLanzamiento(Date fechaLanzamiento) {
        this.fechaLanzamiento = fechaLanzamiento;
    }

    public double getCostoDesarrollo() {
        return costoDesarrollo;
    }

    public void setCostoDesarrollo(double costoDesarrollo) {
        this.costoDesarrollo = costoDesarrollo;
    }

    public boolean isVersionPlaystation5() {
        return versionPlaystation5;
    }

    public void setVersionPlaystation5(boolean versionPlaystation5) {
        this.versionPlaystation5 = versionPlaystation5;
    }

    public boolean isVersionNintendoSwitch() {
        return versionNintendoSwitch;
    }

    public void setVersionNintendoSwitch(boolean versionNintendoSwitch) {
        this.versionNintendoSwitch = versionNintendoSwitch;
    }

    public boolean isVersionXboxSeries() {
        return versionXboxSeries;
    }

    public void setVersionXboxSeries(boolean versionXboxSeries) {
        this.versionXboxSeries = versionXboxSeries;
    }

    public boolean isVersionPC() {
        return versionPC;
    }

    public void setVersionPC(boolean versionPC) {
        this.versionPC = versionPC;
    }

    public boolean isVersionSmartphone() {
        return versionSmartphone;
    }

    public void setVersionSmartphone(boolean versionSmartphone) {
        this.versionSmartphone = versionSmartphone;
    }

    public byte[] getMaterialPromocionalPDF() {
        return materialPromocionalPDF;
    }

    public void setMaterialPromocionalPDF(byte[] materialPromocionalPDF) {
        this.materialPromocionalPDF = materialPromocionalPDF;
    }

    public byte[] getPortada() {
        return portada;
    }

    public void setPortada(byte[] portada) {
        this.portada = portada;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}