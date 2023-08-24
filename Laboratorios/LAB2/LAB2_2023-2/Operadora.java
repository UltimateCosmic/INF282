class Operadora extends Empresa{
	// Atributos:
	private boolean hasSoporteLogistico;
	private boolean hasAsistenciaDeNavegacion;
	// Constructor:
	public Operadora(String nombre, boolean hasSoporteLogistico, boolean hasAsistenciaDeNavegacion){
		super(nombre);
		this.hasSoporteLogistico = hasSoporteLogistico;
		this.hasAsistenciaDeNavegacion = hasAsistenciaDeNavegacion;
	}
	// Métodos:
	@Override
	public String consultarDatos(){
		return "Operadora: " + getNombre() + " - Soporte Logistico:" + hasSoporteLogistico + 
				" - Asistencia Navegacion:" + hasAsistenciaDeNavegacion + "\n";
	}
}

