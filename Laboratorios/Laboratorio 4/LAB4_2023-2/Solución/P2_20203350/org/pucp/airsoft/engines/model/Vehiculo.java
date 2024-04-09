package org.pucp.airsoft.engines.model;

import org.pucp.airsoft.companies.model.Aerolinea;
import org.pucp.airsoft.companies.model.Consultable;

public abstract class Vehiculo implements Consultable{
	private String modelo;
	private double velocidadMaxima;
	private Aerolinea aerolinea;
	public Vehiculo(Aerolinea aerolinea, String modelo, double velocidadMaxima){
		this.aerolinea = aerolinea;
		this.modelo = modelo;
		this.velocidadMaxima = velocidadMaxima;
	}
	public String getModelo(){
		return modelo;
	}
	public Aerolinea getAerolinea(){
		return aerolinea;
	}
	public abstract String consultarDatos();
}