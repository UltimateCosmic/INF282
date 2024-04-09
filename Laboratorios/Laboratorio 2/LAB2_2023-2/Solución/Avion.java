class Avion extends Vehiculo{
	// Atributos:
	private int capMaxPasajeros;
	// Constructor:
	public Avion(Aerolinea aerolinea, String modelo, double velocidadMax, int capMaxPasajeros) {
		super(aerolinea, modelo, velocidadMax);	
		this.capMaxPasajeros = capMaxPasajeros;
	}
	// Métodos:
	@Override
	public String consultarDatos() {
		return "Avion: " + getModelo() + " - Capacidad Max. Pasajeros:" + capMaxPasajeros + "\n";
	}
}