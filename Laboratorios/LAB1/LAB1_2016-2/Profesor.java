import java.util.Date;

class Profesor extends MiembroPUCP{
	// Atributos:
	private Dedicacion estado;
	// Constructor:
	public Profesor(String codigo, String nombre, Date fechaNacimiento, String direccion, String email, 
			char sexo, Dedicacion estado) {
		super(nombre, fechaNacimiento, direccion, email, sexo, codigo);
		this.estado = estado;
	}
	// Métodos:
	@Override
	public String consultarDatos() {
		return "Profesor: " + getCodigo() + " - " + getNombre() + " - " + estado;
	}
}