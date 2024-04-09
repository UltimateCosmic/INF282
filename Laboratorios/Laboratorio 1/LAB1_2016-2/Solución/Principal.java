import java.text.SimpleDateFormat;
import java.util.ArrayList;
 
 public class Principal {
	public static void main(String[] args) {		
		
		// Formato para el manejo de fechas
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");		
		
		//Crea una instancia de EQuipu
		EQuipu objEquipu = new EQuipu();
		
		//Se crean los equipos, se asignan los miembros a cada equipo y se agregan los equipos a EQuipu
		Equipo objEquipo1 = new Equipo("HCI-DUXAIT","Temas de Interacción Humano-Computador");
				
		// Miembros
		Alumno objEstudiante1 = new Alumno("20090606", "Juan Perez", sdf.parse("20-03-1992"), "Av. Universitaria 2021 - San Miguel", "jperez@pucp.edu.pe", 'M', 68.3);
		Profesor objProfesor1 = new Profesor("46891", "Andrea Montenegro", sdf.parse("30-10-1965"), "Av. Bolivar 872 - Pueblo Libre", "amontenegro@pucp.edu.pe", 'F',Dedicacion.TC);
		Alumno objEstudiante2 = new Alumno("20096969", "Viviana Rivasplata", sdf.parse("01-01-1995"), "Av. La Marina 2873 - San Miguel", "vivirivasplata@pucp.edu.pe", 'F', 64.5);
		MiembroExterno objMExterno1 = new MiembroExterno("Jorge Santisteban", sdf.parse("04-07-1982"), "Av. Brasil 1023 - Jesus Maria", "jsantiste@gmail.com", 'M', 'T');		
		
		//Inicializamos la lista de miembros dentro del equipo
		objEquipo1.setMiembros(new ArrayList<Miembro>());
		
		//Agregamos los miembros al equipo
		objEquipo1.getMiembros().add(objEstudiante1);
		objEquipo1.getMiembros().add(objProfesor1);
		objEquipo1.getMiembros().add(objEstudiante2);
		objEquipo1.getMiembros().add(objMExterno1);
		
		//Inicializamos la lista de equipos dentro del EQuipu
		objEquipu.setEquipos(new ArrayList<Equipo>());
		
		//Agregamos los equipos al EQuipu
		objEquipu.getEquipos().add(objEquipo1);
		
		//Consulta los miembros del equipo cuyo índice es 2
		String reporte = objEquipu.ConsultarMiembrosDeEquipo(2);
		System.out.print(reporte);
	}
} 