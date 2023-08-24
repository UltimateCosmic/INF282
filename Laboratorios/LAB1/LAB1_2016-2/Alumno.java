import java.util.Date;

class Alumno extends MiembroPUCP{
	// Atributos:
	private double CRAEST;
	// Constructor:
	public Alumno(String codigo, String nombre, Date fechaNacimiento, String direccion, String email, 
			char sexo, double CRAEST) {
		super(nombre, fechaNacimiento, direccion, email, sexo, codigo);
		this.CRAEST = CRAEST;
	}
	// Métodos:
	@Override
	public String consultarDatos() {
		return "Alumno: " + getCodigo() + " - " + getNombre() + " - " + CRAEST;
	}
}