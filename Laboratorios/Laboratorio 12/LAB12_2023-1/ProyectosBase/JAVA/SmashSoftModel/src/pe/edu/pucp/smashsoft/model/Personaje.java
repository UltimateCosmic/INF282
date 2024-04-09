package pe.edu.pucp.smashsoft.model;

import java.util.Date;

public class Personaje {
    private int idPersonaje;
    private Universo universo;
    private Plataforma plataforma;
    private String nombre;
    private Date fechaAparicion;
    private double peso;
    private double velocidadAlCaminar;
    private double velocidadAlCorrer;
    private int cantidadMaxSaltos;
    private boolean saltoPared;
    private boolean adhesionParedes;
    private boolean arrastre;
    private String descripcion;
    private byte[] foto;

    public int getIdPersonaje() {
        return idPersonaje;
    }

    public void setIdPersonaje(int idPersonaje) {
        this.idPersonaje = idPersonaje;
    }

    public Universo getUniverso() {
        return universo;
    }

    public void setUniverso(Universo universo) {
        this.universo = universo;
    }

    public Plataforma getPlataforma() {
        return plataforma;
    }

    public void setPlataforma(Plataforma plataforma) {
        this.plataforma = plataforma;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Date getFechaAparicion() {
        return fechaAparicion;
    }

    public void setFechaAparicion(Date fechaAparicion) {
        this.fechaAparicion = fechaAparicion;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public double getVelocidadAlCaminar() {
        return velocidadAlCaminar;
    }

    public void setVelocidadAlCaminar(double velocidadAlCaminar) {
        this.velocidadAlCaminar = velocidadAlCaminar;
    }

    public double getVelocidadAlCorrer() {
        return velocidadAlCorrer;
    }

    public void setVelocidadAlCorrer(double velocidadAlCorrer) {
        this.velocidadAlCorrer = velocidadAlCorrer;
    }

    public int getCantidadMaxSaltos() {
        return cantidadMaxSaltos;
    }

    public void setCantidadMaxSaltos(int cantidadMaxSaltos) {
        this.cantidadMaxSaltos = cantidadMaxSaltos;
    }

    public boolean isSaltoPared() {
        return saltoPared;
    }

    public void setSaltoPared(boolean saltoPared) {
        this.saltoPared = saltoPared;
    }

    public boolean isAdhesionParedes() {
        return adhesionParedes;
    }

    public void setAdhesionParedes(boolean adhesionParedes) {
        this.adhesionParedes = adhesionParedes;
    }

    public boolean isArrastre() {
        return arrastre;
    }

    public void setArrastre(boolean arrastre) {
        this.arrastre = arrastre;
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
    
}