package org.pucp.airsoft.engines.model;

import org.pucp.airsoft.companies.model.Aerolinea;

public class Remolque extends Vehiculo{
	private double capacidadCarga;
	public Remolque(Aerolinea aerolinea, String modelo, double velocidadMaxima, double capacidadCarga){
		super(aerolinea,modelo,velocidadMaxima);
		this.capacidadCarga = capacidadCarga;
	}
	@Override
	public String consultarDatos(){
		return "Remolque: " + getModelo() + " - Capacidad de Carga:" + capacidadCarga + "Kg." + "\n"; 
	}
}