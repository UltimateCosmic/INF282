package pe.edu.pucp.softproductions.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Date;

public class SerieTelevision implements Serializable{
    private int idSerieTelevision;
    private ArrayList<Capitulo> capitulos;
    private Productora productora;
    private char idioma;
    private String nombreSerie;
    private int temporada;
    private Date fechaEmision;
    private double costoProduccion;
    private String sipnosis;
    private byte[] portada;
    private boolean activa;

    public int getIdSerieTelevision() {
        return idSerieTelevision;
    }

    public void setIdSerieTelevision(int idSerieTelevision) {
        this.idSerieTelevision = idSerieTelevision;
    }

    public Productora getProductora() {
        return productora;
    }

    public void setProductora(Productora productora) {
        this.productora = productora;
    }

    public char getIdioma() {
        return idioma;
    }

    public void setIdioma(char idioma) {
        this.idioma = idioma;
    }

    public String getNombreSerie() {
        return nombreSerie;
    }

    public void setNombreSerie(String nombreSerie) {
        this.nombreSerie = nombreSerie;
    }

    public int getTemporada() {
        return temporada;
    }

    public void setTemporada(int temporada) {
        this.temporada = temporada;
    }

    public Date getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(Date fechaEmision) {
        this.fechaEmision = fechaEmision;
    }

    public double getCostoProduccion() {
        return costoProduccion;
    }

    public void setCostoProduccion(double costoProduccion) {
        this.costoProduccion = costoProduccion;
    }

    public String getSipnosis() {
        return sipnosis;
    }

    public void setSipnosis(String sipnosis) {
        this.sipnosis = sipnosis;
    }

    public byte[] getPortada() {
        return portada;
    }

    public void setPortada(byte[] portada) {
        this.portada = portada;
    }

    public boolean isActiva() {
        return activa;
    }

    public void setActiva(boolean activa) {
        this.activa = activa;
    }

    public ArrayList<Capitulo> getCapitulos() {
        return capitulos;
    }

    public void setCapitulos(ArrayList<Capitulo> capitulos) {
        this.capitulos = capitulos;
    }
    
}