package org.pucp.airsoft.companies.model;

import java.util.Date;
import java.text.SimpleDateFormat;

public class Aerolinea extends Empresa{
	private String callsign;
	private boolean tieneProgramaFidelidad;
	private Date fechaFundacion;
	private String descripcion;
	private boolean activo;
	public Aerolinea(){}
	public Aerolinea(String nombre, String callsign, boolean tieneProgramaFidelidad){
		super(nombre);
		this.callsign = callsign;
		this.tieneProgramaFidelidad = tieneProgramaFidelidad;
	}
	
	public Aerolinea(String nombre, String callsign, boolean tieneProgramaFidelidad, Date fechaFundacion, String descripcion){
		super(nombre);
		this.callsign = callsign;
		this.tieneProgramaFidelidad = tieneProgramaFidelidad;
		this.fechaFundacion = fechaFundacion;
		this.descripcion = descripcion;
	}
	
	public Aerolinea(int idEmpresa, String nombre, String callsign, boolean tieneProgramaFidelidad, Date fechaFundacion, String descripcion){
		super(idEmpresa, nombre);
		this.callsign = callsign;
		this.tieneProgramaFidelidad = tieneProgramaFidelidad;
		this.fechaFundacion = fechaFundacion;
		this.descripcion = descripcion;
	}
	
	public void setCallsign(String callsign){
		this.callsign = callsign;
	}
	public String getCallsign(){
		return callsign;
	}
	public void setTieneProgramaFidelidad(boolean tieneProgramaFidelidad){
		this.tieneProgramaFidelidad = tieneProgramaFidelidad;
	}
	public boolean isTieneProgramaFidelidad(){
		return tieneProgramaFidelidad;
	}
	public void setFechaFundacion(Date fechaFundacion){
		this.fechaFundacion = fechaFundacion;
	}
	public Date getFechaFundacion(){
		return fechaFundacion;
	}
	public void setDescripcion(String descripcion){
		this.descripcion = descripcion;
	}
	public String getDescripcion(){
		return descripcion;
	}
	public void setActivo(boolean activo){
		this.activo = activo;
	}
	public boolean isActivo(){
		return activo;
	}
	
	@Override
	public String consultarDatos(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		return "Aerolinea: " + getIdEmpresa() + ". " + getNombre() + " - " + callsign + " - Programa Fidelidad:" + (tieneProgramaFidelidad?"SI":"NO") + " - Fecha de fundaci\u00F3n:" + sdf.format(fechaFundacion) + " - " + descripcion;
	}
}