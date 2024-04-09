package org.pucp.airsoft.companies.model;

public class Operadora extends Empresa{
	private boolean ofreceSoporteLogistico;
	private boolean ofreceAsistenciaNavegacion;
	public Operadora(String nombre, boolean ofreceSoporteLogistico, boolean ofreceAsistenciaNavegacion){
		super(nombre);
		this.ofreceSoporteLogistico = ofreceSoporteLogistico;
		this.ofreceAsistenciaNavegacion = ofreceAsistenciaNavegacion;
	}
	@Override
	public String consultarDatos(){
		return "Operadora: " + getNombre() + " - Soporte Logistico:" +  ofreceSoporteLogistico + " - Asistencia Navegacion:" + ofreceAsistenciaNavegacion + "\n";
	}	
}