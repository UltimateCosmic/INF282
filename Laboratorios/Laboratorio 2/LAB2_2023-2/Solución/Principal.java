import java.text.SimpleDateFormat;
import java.time.LocalTime;

class Principal{
	public static void main(String[] args) throws Exception{
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		Ciudad ciudad01 = new Ciudad("Lima");
		Ciudad ciudad02 = new Ciudad("Chiclayo");
		Operadora operadora01 = new Operadora("LIMA PARTNERS", true, true);
		Operadora operadora02 = new Operadora("CORPAC", false, true);
		Aeropuerto aeropuerto01 = new Aeropuerto("Jorge Chavez", "Av. Elmer Faucett S/N",
				TipoAeropuerto.Internacional, ciudad01, operadora01);
		Aeropuerto aeropuerto02 = new Aeropuerto("Jose Abelardo Quiones", "Av. Bolognesi S/N",
				TipoAeropuerto.Internacional, ciudad02, operadora02);
		Aerolinea aerolinea01 = new Aerolinea("Latam Airlines", "LATAM", true);
		Avion avion01 = new Avion(aerolinea01, "AIRBUS A320", 890.00, 186);
		Remolque remolque01 = new Remolque(aerolinea01, "HD-ATT60", 158.00, 4160.00);
		Vuelo vuelo01 = new Vuelo("LA2023", sdf.parse("25-08-2023"), LocalTime.of(13,00,00),
				LocalTime.of(14,30,00));
		vuelo01.setAvion(avion01);
		vuelo01.setRemolque(remolque01);
		vuelo01.setAeropuertoSalida(aeropuerto01);
		vuelo01.setAeropuertoLlegada(aeropuerto02);		
		String reporte = vuelo01.devolverInformacion();
		System.out.print(reporte);
	}
}

