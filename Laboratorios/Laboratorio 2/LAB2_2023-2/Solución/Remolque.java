class Remolque extends Vehiculo{
	// Atributos:
	private double capMaxCarga;
	// Constructor:
	public Remolque(Aerolinea aerolinea, String modelo, double velocidadMax, double capMaxCarga) {
		super(aerolinea, modelo, velocidadMax);	
		this.capMaxCarga = capMaxCarga;
	}
	@Override
	public String consultarDatos() {
		return "Remolque: " + getModelo() + " - Capacidad de Carga:" + capMaxCarga + "Kg.\n";
	}
}