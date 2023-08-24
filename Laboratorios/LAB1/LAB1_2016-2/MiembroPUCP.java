import java.util.Date;

abstract class MiembroPUCP extends Miembro implements Consultable {
	// Atributos:
	private String codigo;
	// Constructor:
	public MiembroPUCP(String nombre, Date fechaNacimiento, String direccion, String email, 
			char sexo, String codigo) {
		super(nombre, fechaNacimiento, direccion, email, sexo);
		this.codigo = codigo;
	}
	// Métodos:
	public String getCodigo() {
		return codigo;
	}
	public abstract String consultarDatos();
}