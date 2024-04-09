package org.pucp.airsoft.companies.model;

import org.pucp.airsoft.companies.model.Consultable;

public abstract class Empresa implements Consultable{
	private int idEmpresa;
	private String nombre;
	
	public Empresa(){}
	public Empresa(int idEmpresa, String nombre){
		this.idEmpresa = idEmpresa;
		this.nombre = nombre;
	}
	public Empresa(String nombre){
		this.nombre = nombre;
	}
	
	public int getIdEmpresa(){
		return idEmpresa;
	}
	public void setIdEmpresa(int idEmpresa){
		this.idEmpresa = idEmpresa;
	}
	public String getNombre(){
		return nombre;
	}
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	
	public abstract String consultarDatos();
}