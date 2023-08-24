abstract class Empresa implements Consultable{
	// Atributos:
	private String nombre;
	// Constructor:
	public Empresa(String nombre){
		this.nombre = nombre;
	}
	// Métodos:
	public String getNombre(){
		return nombre;
	}
	abstract public String consultarDatos();
}

