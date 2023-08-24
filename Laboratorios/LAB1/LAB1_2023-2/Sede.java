import java.util.ArrayList;

class Sede {	
	// Atributos:
	private int identificador;
	private String nombre;
	private String direccion;
	private ArrayList<ProgramaAcademico> programasAcademicos;	
	// Constructor:
	public Sede(int identificador, String nombre, String direccion) {
		this.identificador = identificador;
		this.nombre = nombre;
		this.direccion = direccion;
	}	
	// Métodos:
	public void setProgramasAcademicos(ArrayList<ProgramaAcademico> programasAcademicos) {
		this.programasAcademicos = programasAcademicos;
	}
	public ArrayList<ProgramaAcademico> getProgramasAcademicos() {
		return programasAcademicos;
	}
	public String getNombre() {
		return nombre;
	}
	public String consultarProgramasAcademicos() {
		String cadena = "";
		for(ProgramaAcademico pa : programasAcademicos)
			cadena += pa.consultarDatos() + "\n";
		return cadena;
	}
}

