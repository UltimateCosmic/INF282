import java.util.Date;

abstract class Miembro {
	// Atributos:
	private static int correlativo = 1;
	private int indice;
	private String nombre;
	private Date fechaNacimiento;
	private String direccion;
	private String email;
	private char sexo;
	// Constructor:
	public Miembro(String nombre, Date fechaNacimiento, String direccion, String email, char sexo) {
		indice = correlativo;
		this.nombre = nombre;
		this.fechaNacimiento = fechaNacimiento;
		this.direccion = direccion;
		this.email = email;
		this.sexo = sexo;
		correlativo++;
	}
	// Métodos:
	public String getNombre() {
		return nombre;
	}
}