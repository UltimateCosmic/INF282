import java.util.ArrayList;

class Equipo {
	// Atributos:
	private String nombre;
	private String interes;
	private ArrayList<Miembro> miembros;
	// Constructor:
	public Equipo(String nombre, String interes) {
		this.nombre = nombre;
		this.interes = interes;
	}	
	// Métodos:
	public void setMiembros(ArrayList<Miembro> miembros) {
		this.miembros = miembros;
	}
	public ArrayList<Miembro> getMiembros()	{		
		return miembros;
	}
	public String consultarMiembrosPUCP() {
		String cadena = "";
		for (Miembro m : miembros) {
			if (m instanceof MiembroPUCP) {
				cadena += ((MiembroPUCP)m).consultarDatos() + "\n";
			}
		}
		return cadena;
	}
}