package pe.edu.pucp.eventsoft.model;

import java.sql.Time;
import java.util.Date;

public class Evento {
    private int idEvento;
    private Artista artista;
    private Establecimiento establecimiento;
    private String nombre;
    private TipoEvento tipoEvento;
    private Date fechaEvento;
    private Time horaEvento;
    private double costoRealizacion;
    private int cantidadEntradasDisponibles;
    private String descripcion;
    private byte[] foto;
    private boolean activo;

    public Evento(){}
    
    public int getIdEvento() {
        return idEvento;
    }

    public void setIdEvento(int idEvento) {
        this.idEvento = idEvento;
    }

    public Artista getArtista() {
        return artista;
    }

    public void setArtista(Artista artista) {
        this.artista = artista;
    }

    public Establecimiento getEstablecimiento() {
        return establecimiento;
    }

    public void setEstablecimiento(Establecimiento establecimiento) {
        this.establecimiento = establecimiento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public TipoEvento getTipoEvento() {
        return tipoEvento;
    }

    public void setTipoEvento(TipoEvento tipoEvento) {
        this.tipoEvento = tipoEvento;
    }

    public Date getFechaEvento() {
        return fechaEvento;
    }

    public void setFechaEvento(Date fechaEvento) {
        this.fechaEvento = fechaEvento;
    }

    public Time getHoraEvento() {
        return horaEvento;
    }

    public void setHoraEvento(Time horaEvento) {
        this.horaEvento = horaEvento;
    }

    public double getCostoRealizacion() {
        return costoRealizacion;
    }

    public void setCostoRealizacion(double costoRealizacion) {
        this.costoRealizacion = costoRealizacion;
    }

    public int getCantidadEntradasDisponibles() {
        return cantidadEntradasDisponibles;
    }

    public void setCantidadEntradasDisponibles(int cantidadEntradasDisponibles) {
        this.cantidadEntradasDisponibles = cantidadEntradasDisponibles;
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
    
}