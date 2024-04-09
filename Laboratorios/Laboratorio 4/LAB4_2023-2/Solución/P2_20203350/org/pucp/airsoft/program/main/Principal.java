package org.pucp.airsoft.program.main;

import java.text.SimpleDateFormat;
import java.time.LocalTime;
import org.pucp.airsoft.management.model.Ciudad;
import org.pucp.airsoft.companies.model.Operadora;
import org.pucp.airsoft.management.model.Aeropuerto;
import org.pucp.airsoft.companies.model.Aerolinea;
import org.pucp.airsoft.engines.model.Avion;
import org.pucp.airsoft.engines.model.Remolque;
import org.pucp.airsoft.management.model.Vuelo;
import org.pucp.airsoft.management.model.TipoAeropuerto;

public class Principal{
	/* Coloque sus datos
	Nombre Completo: Johan Carlo Amador Egoavil
	Código PUCP: 20203350
	*/
	public static void main(String[] args) throws Exception{
		//Se crea el objeto SimpleDateFormat
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		//Se crean ciudades
		Ciudad ciudad01 = new Ciudad("Lima");
		Ciudad ciudad02 = new Ciudad("Chiclayo");
		//Se crean operadoras
		Operadora operadora01 = new Operadora("LIMA PARTNERS", true, true);
		Operadora operadora02 = new Operadora("CORPAC", false, true);
		//Se crean los aeropuertos
		Aeropuerto aeropuerto01 = new Aeropuerto("Jorge Chavez","Av. Elmer Faucett S/N",TipoAeropuerto.Internacional,ciudad01,operadora01);
		Aeropuerto aeropuerto02 = new Aeropuerto("Jose Abelardo Qui\u00f1ones","Av. Bolognesi S/N",TipoAeropuerto.Internacional,ciudad02,operadora02);
		//Se crea la aerolinea
		Aerolinea aerolinea01 = new Aerolinea(1,"Latam Airlines", "LATAM", true, sdf.parse("05-03-1929"),"LATAM Airlines es una aerolinea multinacional chilena formada por la fusion de las sudamericanas LAN, TAM3 y sus filiales.");
		//Se crea el avion
		Avion avion01 = new Avion(aerolinea01, "AIRBUS A320", 890.00, 186);
		//Se crea el remolque
		Remolque remolque01 = new Remolque(aerolinea01,"HD-ATT60", 158.00, 4160.00);
		//Se crea el vuelo
		Vuelo vuelo01 = new Vuelo("LA2023",sdf.parse("25-08-2023"),LocalTime.of(13,00,00),LocalTime.of(14,30,00));
		//Establecemos el avion del vuelo
		vuelo01.setAvion(avion01);
		//Establecemos el remolque asignado al vuelo
		vuelo01.setRemolque(remolque01);
		//Establecemos el aeropuerto de salida del vuelo
		vuelo01.setAeropuertoSalida(aeropuerto01);
		//Establecemos el aeropuerto de llegada del vuelo
		vuelo01.setAeropuertoLlegada(aeropuerto02);
		//Se genera un reporte del vuelo
		String reporte = vuelo01.devolverInformacion();
		//Se imprime el reporte sobre el vuelo
		System.out.print(reporte);
	}
}