package org.pucp.airsoft.management.model;

import org.pucp.airsoft.management.model.Ciudad;
import org.pucp.airsoft.management.model.TipoAeropuerto;
import org.pucp.airsoft.companies.model.Operadora;
import org.pucp.airsoft.companies.model.Consultable;

public class Aeropuerto implements Consultable{
	private String nombre;
	private String direccion;
	private TipoAeropuerto tipoAeropuerto;
	private Ciudad ciudad;
	private Operadora operadora;
	
	public Aeropuerto(String nombre, String direccion, TipoAeropuerto tipoAeropuerto, Ciudad ciudad, Operadora operadora){
		this.nombre = nombre;
		this.direccion = direccion;
		this.tipoAeropuerto = tipoAeropuerto;
		this.ciudad = ciudad;
		this.operadora = operadora;
	}
	
	public String consultarDatos(){
		String cadena = "Aeropuerto: " + nombre + " - " + ciudad.getNombre() + " - " + tipoAeropuerto + "\n";
		cadena+= operadora.consultarDatos();
		return cadena;
	}
}