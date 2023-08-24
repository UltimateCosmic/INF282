import java.util.ArrayList;

class InstitucionEducativa {	
	// Atributos:
	private int identificador;
	private String RUC;
	private String nombre;
	private ArrayList<Sede> sedes;	
	// Constructor:
	public InstitucionEducativa(int identificador, String RUC, String nombre) {
		this.identificador = identificador;
		this.RUC = RUC;
		this.nombre = nombre;
	}	
	// Métodos:
	public void setSedes(ArrayList<Sede> sedes) {
		this.sedes = sedes;
	}
	public ArrayList<Sede> getSedes() {
		return sedes;
	}
	public String consultarProgramas(int iSede) {
		String cadena = "Programas disponibles para " + sedes.get(iSede).getNombre() + "\n";
		cadena += sedes.get(iSede).consultarProgramasAcademicos();
		return cadena;
	}
}

