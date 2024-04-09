package org.pucp.airsoft.management.model;

import java.util.Date;
import java.text.SimpleDateFormat;
import java.time.LocalTime;
import org.pucp.airsoft.engines.model.Avion;
import org.pucp.airsoft.engines.model.Remolque;
import org.pucp.airsoft.management.model.Aeropuerto;

public class Vuelo{
	private static int correlativo = 1;
	private int idVuelo;
	private String codigo;
	private Date fecha;
	private LocalTime horaSalida;
	private LocalTime horaLlegada;
	private Avion avion;
	private Remolque remolque;
	private Aeropuerto aeropuertoSalida;
	private Aeropuerto aeropuertoLlegada;
	
	public Vuelo(String codigo, Date fecha, LocalTime horaSalida, LocalTime horaLlegada){
		this.idVuelo = correlativo;
		this.codigo = codigo;
		this.fecha = fecha;
		this.horaSalida = horaSalida;
		this.horaLlegada = horaLlegada;
		correlativo++;
	}
	
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
		String cadena = "Datos del vuelo " + codigo + " con ID:" + idVuelo + " \n";
		cadena+="-----------------------------------------------------------"+"\n";
		cadena+="Fecha:" + sdf.format(fecha) + " - Hora Salida:" + horaSalida + " - Hora Llegada:" + horaLlegada + "\n" ;
		cadena+=avion.consultarDatos();
		cadena+=remolque.consultarDatos();
		cadena+="-----------------------------------------------------------"+"\n";
		cadena+="DESDE:" +"\n";
		cadena+=aeropuertoSalida.consultarDatos();
		cadena+="-----------------------------------------------------------"+"\n";
		cadena+="HACIA:" +"\n";
		cadena+=aeropuertoLlegada.consultarDatos();
		return cadena;
	}
}