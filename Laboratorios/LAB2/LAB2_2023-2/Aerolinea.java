import java.util.ArrayList;

class Aerolinea extends Empresa{
	// Atributos:
	private String callsign;
	private boolean hasProgramaDeFidelidad;
	private ArrayList<Vehiculo> vehiculos;
	// Constructor:
	public Aerolinea(String nombre, String callsign, boolean hasProgramaDeFidelidad){
		super(nombre);
		this.callsign = callsign;
		this.hasProgramaDeFidelidad = hasProgramaDeFidelidad;
	}
	// Métodos:
	@Override
	public String consultarDatos(){
		return "Aerolinea: " + getNombre() + " - " + callsign + " - Programa Fidelidad: " 
				+ hasProgramaDeFidelidad + "\n";
	}
}

