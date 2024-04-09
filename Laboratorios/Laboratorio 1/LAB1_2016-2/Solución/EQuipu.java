import java.util.ArrayList;

class EQuipu {
	// Atributos:
	private ArrayList<Equipo> equipos;	
	private ArrayList<Miembro> ejecutivos;	
	// Métodos:
	public void setEquipos(ArrayList<Equipo> equipos) {
		this.equipos = equipos;		
	}
	public ArrayList<Equipo> getEquipos() {
		return equipos;
	}
	public void setEjecutivos(ArrayList<Miembro> ejecutivos) {
		this.ejecutivos = ejecutivos;
	}
	public ArrayList<Miembro> getEjecutivos() {
		return ejecutivos;
	}
	public String ConsultarMiembrosDeEquipo(int i) {
		return equipos.get(i).consultarMiembrosPUCP();
	}
}