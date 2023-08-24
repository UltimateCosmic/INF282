import java.util.Date;
import java.time.LocalTime;

class Curso extends ProgramaAcademico {	
	// Atributos:
	private int cantHorasPorSemana;
	private double cantCreditos;
	private Date fechaInicio;
	private Date fechaFin;
	private DiaSemana diaDeDictado;
	private LocalTime horaInicioClase;
	private LocalTime horaFinClase;	
	// Constructor:	
	public Curso(String nombre, String clave, char modalidad, double precio, int cantHorasPorSemana,
			double cantCreditos, Date fechaInicio, Date fechaFin, DiaSemana diaDeDictado, 
			LocalTime horaInicioClase, LocalTime horaFinClase) {
		super(nombre, clave, modalidad, precio);
		this.cantHorasPorSemana = cantHorasPorSemana;
		this.cantCreditos = cantCreditos;
		this.fechaInicio = fechaInicio;
		this.fechaFin = fechaFin;
		this.diaDeDictado = diaDeDictado;
		this.horaInicioClase = horaInicioClase;
		this.horaFinClase = horaFinClase;
	}		
	// Métodos:
	@Override
	public String consultarDatos() {
		return "CURSO: " + getClave() + " - " + getNombre() + " - S/." + getPrecio() + " - CRED:" + cantCreditos;
	}	
}

