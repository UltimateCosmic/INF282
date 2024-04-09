import java.util.Date;

class MiembroExterno extends Miembro {
	// Atributos:
	private char dedicacion;
	// Constructor:
	public MiembroExterno(String nombre, Date fechaNacimiento, String direccion, String email, 
			char sexo, char dedicacion) {
		super(nombre, fechaNacimiento, direccion, email, sexo);
		this.dedicacion = dedicacion;
	}
}