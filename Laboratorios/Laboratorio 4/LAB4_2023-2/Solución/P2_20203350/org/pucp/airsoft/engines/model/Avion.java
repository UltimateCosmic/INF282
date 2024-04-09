package org.pucp.airsoft.engines.model;

import org.pucp.airsoft.companies.model.Aerolinea;

public class Avion extends Vehiculo{
	private int capacidadPasajeros;
	public Avion(Aerolinea aerolinea, String modelo, double velocidadMaxima, int capacidadPasajeros){
		super(aerolinea, modelo,velocidadMaxima);
		this.capacidadPasajeros = capacidadPasajeros;
	}
	@Override
	public String consultarDatos(){
		String cadena = "Avion: " + getModelo() + " - Capacidad Max. Pasajeros:" + capacidadPasajeros + "\n";
		cadena+= getAerolinea().consultarDatos() + "\n";
		return cadena;
	}
}