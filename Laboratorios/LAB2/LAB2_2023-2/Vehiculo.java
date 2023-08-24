abstract class Vehiculo implements Consultable{
	// Atributos:
	private Aerolinea aerolinea;
	private String modelo;
	private double velocidadMax;
	// Constructor:
	public String getModelo(){
		return modelo;
	}	
	public Aerolinea getAerolinea(){
		return aerolinea;		
	}
	public Vehiculo(Aerolinea aerolinea, String modelo, double velocidadMax){
		this.aerolinea = aerolinea;
		this.modelo = modelo;
		this.velocidadMax = velocidadMax;
	}
	abstract public String consultarDatos();
}