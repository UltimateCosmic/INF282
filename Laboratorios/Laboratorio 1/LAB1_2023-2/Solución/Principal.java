import java.text.SimpleDateFormat;
import java.time.LocalTime;
import java.util.ArrayList;
/*
	Autor: <Johan Carlo Amador Egoavil>
	Fecha: <24-08-2023>
*/
class Principal{
	public static void main(String[] args) throws Exception{
		//Creamos un objeto para manejo de fechas
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		//Creamos la institucion educativa
		InstitucionEducativa ie1 = new InstitucionEducativa(1,"1092828764","Intelectuales SAC");
		//Creamos una sede
		Sede sede1 = new Sede(1,"Intelectuales SAC San Miguel","Av. Universitaria 1801");
		//Inicializamos los programas académicos de la sede
		sede1.setProgramasAcademicos(new ArrayList<>());
		//Inicializamos las sedes de la institucion educativa
		ie1.setSedes(new ArrayList<>());
		//Asociamos la sede a la institucion educativa
		ie1.getSedes().add(sede1);
		//Creamos un curso de la sede
		Curso curso1 = new Curso("LENGUAJE DE PROGRAMACION 2", "INF282", 'P', 1500.00, 4, 5, 
				sdf.parse("20-03-2023"), sdf.parse("08-07-2023"), DiaSemana.Martes, 
				LocalTime.of(8,00,00), LocalTime.of(11,00,00));
		//Creamos dos talleres de la sede
		Taller taller1 = new Taller("PYTHON PARA INVESTIGACION CUANTITATIVA","TAL725",'V', 
				500.00, sdf.parse("28-03-2023"),LocalTime.of(13,00,00), LocalTime.of(16,00,00));
		Taller taller2 = new Taller("INTRODUCCION A LATEX","TAL331",'V', 600.00, 
				sdf.parse("30-03-2023"),LocalTime.of(18,00,00), LocalTime.of(22,00,00));
		//Asociamos el curso y los talleres a la sede
		sede1.getProgramasAcademicos().add(curso1);
		sede1.getProgramasAcademicos().add(taller1);
		sede1.getProgramasAcademicos().add(taller2);
		//Consultamos los programas disponibles en la primera sede de la institucion educativa
		String reporte = ie1.consultarProgramas(0);
		//Imprimimos el reporte
		System.out.print(reporte);
	}
}

