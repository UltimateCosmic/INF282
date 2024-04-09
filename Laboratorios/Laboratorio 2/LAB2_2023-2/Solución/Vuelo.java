import java.text.SimpleDateFormat;
import java.time.LocalTime;
import java.util.Date;

class Vuelo{
	// Atributos:
	private static int correlativo = 1;
	private int indice;
	private String codigo;
	private Date fecha;
	private LocalTime horaSalida;
	private LocalTime horaLlegada;
	private Avion avion;
	private Remolque remolque;
	private Aeropuerto aeropuertoSalida;
	private Aeropuerto aeropuertoLlegada;
	// Constructor:
	public Vuelo(String codigo, Date fecha, LocalTime horaSalida, LocalTime horaLlegada){
		indice = correlativo;
		this.codigo = codigo;
		this.fecha = fecha;
		this.horaSalida = horaSalida;
		this.horaLlegada = horaLlegada;
		correlativo++;
	}	
	// Métodos:
	public void setAvion(Avion avion){
		this.avion = avion;		
	}
	public void setRemolque(Remolque remolque){
		this.remolque = remolque;		
	}
	public void setAeropuertoSalida(Aeropuerto aeropuertoSalida){
		this.aeropuertoSalida = aeropuertoSalida;		
	}
	public void setAeropuertoLlegada(Aeropuerto aeropuertoLlegada){
		this.aeropuertoLlegada = aeropuertoLlegada;		
	}	
	public String devolverInformacion(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		String cad = "Datos del vuelo " + codigo + " con ID:" + indice + "\n";
		cad += devolverLinea(70, '-');
		cad += "\nFecha: " + sdf.format(fecha) + " - Hora Salida:" + horaSalida + 
				" - Hora Llegada:" + horaLlegada + "\n";
		cad += avion.getAerolinea().consultarDatos();
		cad += remolque.consultarDatos();
		cad += devolverLinea(70, '-');
		cad += "\nDESDE:\n";
		cad += aeropuertoSalida.consultarDatos();
		cad += devolverLinea(70, '-');
		cad += "\nHACIA:\n";
		cad += aeropuertoLlegada.consultarDatos();
		return cad;
	}
	public String devolverLinea(int cap, char c) {		
		String cad="";		
		for (int i=0; i<cap; i++) cad+=c;
		return cad;
	}
}

