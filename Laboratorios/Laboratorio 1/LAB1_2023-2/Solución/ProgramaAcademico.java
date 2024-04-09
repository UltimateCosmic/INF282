abstract class ProgramaAcademico implements IConsultable {	
	// Atributos:
	private static int indice = 1;
	private int idCorrelativo;	
	private String nombre;
	private String clave;
	private char modalidad;
	private double precio;		
	// Constructor:
	public ProgramaAcademico(String nombre, String clave, char modalidad, double precio) {
		idCorrelativo = indice;
		this.nombre = nombre;
		this.clave = clave;
		this.modalidad = modalidad;
		this.precio = precio;		
		indice++;
	}	
	// Métodos:
	public abstract String consultarDatos();
	public String getClave() {
		return clave;
	}
	public String getNombre() {
		return nombre;
	}
	public double getPrecio() {
		return precio;
	}
}

