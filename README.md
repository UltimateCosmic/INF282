# INF282 - Lenguaje de Programación 2 👨🏻‍💻
Este es un repositorio de solucionarios del curso de Lenguaje de Programación 2.

> Nota: Si alguien desea aportar al repositorio pueden hacer un pull request. Lo mismo si ven alguna falla en los códigos ya que son muchos programas.

Última actualización el 08/04/2024: Enunciado + Retroalimentación + Solución.

# Programación Orientada a Objetos (POO)
Si bien las técnicas de POO facilitan la creación de complejos sistemas de software por medio de mejores mecanismos de abstracción, no son la panacea universal de solución.
- Objeto: Es la representación de un concepto del mundo real (tangible o intangible) dentro de nuestro sistema de software.
    - Estado: Está representado por un conjunto de características del objeto.
    - Comportamiento: Está representado por un conjunto de métodos u operaciones que realiza el objeto.
- Clase: Representan un tipo particular de objetos con características y comportamiento similar.

## ¿Qué es un paradigma?
> *Un modelo para describir un conjunto de teorías, estándares y métodos que agrupados representan una forma de organizar el conocimiento, esto es, una forma de ver el mundo.*
>
## Impresión en Java
Para imprimir datos de salida en Java usamos la instrucción `System.out.println();`.
```java
System.out.println(nombre + " " + apellidoPaterno);
```
## Clases en Java
Al implementar una clase en Java respetaremos un orden, este será el siguiente:
1. Propiedades: Atributos de la clase.
2. Constructos: Constructores de la clase.
3. Métodos: Funciones y procedimientos.
```java
class <identificador> extends <Clase> {
	//Propiedades
	<Modo de Acceso> <Tipo de dato> <Nombre del Atributo>;
	...
	//Métodos
	Para funciones:
	<Modo de Acceso> <Tipo de dato> <Nombre> (Lista Parámetros){}
	Para procedimientos:
	<Modo de Acceso> void <Nombre> (Lista Parámetros){}
}
```
Las clases deben ser implementadas de forma tal que los objetos que de ellas se creen siempre tengan un estado consistente.
### Constructor

Se utiliza para construir o instanciar una clase. Puede haber varios constructores, de acuerdo
a las necesidades del usuario.

```java
public class Persona {
	private String nombre;
	private int edad;
	public Persona(){}
	public Persona(String nombre, int edad){
		nombre = nombre;
		edad = edad;
	}
}
```
### Destructor
Se utiliza para destruir una instancia de una clase y liberar memoria. En Java no hay destructores, ya que la liberación de memoria es llevada acabo por el Garbage Collector cuando las instancias de los objetos quedan no referenciadas.
```java
public class Persona {
	private String nombre;
	private int edad;
	public Persona(){}
	public void finalize(){
		System.out.println("El objeto se esta destruyendo");
	}
	~Persona(){
		System.Console.WriteLine("Se esta destruyendo un objeto");
	}
}
```
## Herencia
Permite crear nuevas clases que reutilizan, extienden y modifican el comportamiento que se define en otras clases. La clase cuyos miembros se heredan se denomina clase base y la clase que hereda esos miembros se denomina clase derivada. Una clase derivada solo puede tener una clase base directa. Sin embargo, la herencia es transitiva.
```java
public class Cientifico extends Persona {
	public String especialidad;
	public void investigar () {…}
}
```
![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/0691536a-9e35-40b3-8cee-c104c225a5c6/Untitled.png)
## Principios de POO
- Encapsulamiento: Al restringir el acceso de otros objetos a sus datos. Acceso indirecto, por sus métodos.
- Herencia: Permite crear nuevas clases que reutilizan el comportamiento de otras clases.
- Polimorfismo: Es posible enviar el mismo mensajes iguales a objetos de distintos tipos.
## Polimorfismo
Propiedad por la que es posible enviar mensajes sintácticamente iguales a objetos de tipos distintos. El único requisito que deben cumplir los objetos que se utilizan de manera polimórfica es saber responder al mensaje que se les envía.
```java
public class Figura{
	public int base;
		public int altura;
		public Figura(int base, int altura){
		this.base = base;
		this.altura = altura;
	}
	public void calcularArea(){
		System.out.println("Procedimiento para calcular el area");
	}
}
```
```java
public class Cuadrado extends Figura{
	public Cuadrado(int base, int altura){
		super(base,altura);
	}
	public void calcularArea(){
		System.out.println(base*altura);
	}
}
```
```java
public class Triangulo extends Figura{
	public Triangulo(int base, int altura){
		super(base,altura);
	}
	public void calcularArea(){
		System.out.println(base*altura/2);
	}
}
```
```java
public class Principal{
	public static void main(String[] args){
		Triangulo t1 = new Triangulo(10,20);
		Figura t2 = new Triangulo(10,20);
		Cuadrado c1 = new Cuadrado(10,20);
		Figura c2 = new Cuadrado(10,20);
		t1.calcularArea();
		t2.calcularArea();
		c1.calcularArea();
		c2.calcularArea();
	}
}
```
![Las clases Cuadrado y Triangulo implementan el método calcular área de forma específica.](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/f4191010-73a0-43e8-8201-0f38aee1247b/Untitled.png)
Las clases Cuadrado y Triangulo implementan el método calcular área de forma específica.
### Override
El uso de **`@Override`** en Java es una anotación que se coloca antes de un método en una clase para indicar que ese método está destinado a sobrescribir (override) un método de la clase padre o de una interfaz implementada. Esta anotación es una herramienta útil para mejorar la claridad del código y evitar errores sutiles al sobrescribir métodos.
## Sobrecarga



La sobrecarga (overload) es un tipo de polimorfismo, que se caracteriza de poder definir más de un método o constructor con el mismo nombre (identificador), siendo distinguidos entre sí por el número y la clase (tipo) de los argumentos que la definen.

```java
public class Persona{
	private string nombre;
	public Persona(string nombre){
		this.nombre = nombre;
	}
	public Persona(string nombre, string apellidos){
		this.nombre = nombre + " " + apellidos;
	}
}
```

```java
public class Persona{
	public void setNombre(string nombre){
		this.nombre = nombre;
	}
	public void setNombre(string nombre, string apellidos){
		this.nombre = nombre + apellidos;
	}
}
```

## Clase Abstracta



- Puede declarar una clase como abstracta si desea evitar la creación directa de instancias por medio de la palabra clave new. Si hace esto, la clase solo se puede utilizar si una nueva clase se deriva de ella.
- Basta con que un método sea abstracto para que la clase sea abstracta. A las clases que tienen todos sus métodos implementados se les llama “clases concretas”. De manera similar, un método declarado y no implementado se le dice “método abstracto”, y uno implementado se le dice “método concreto”.

```java
public abstract class SerVivo{
	public abstract void alimentarse();
	public void correr(){
		//Implementación de correr
	}
}
```

![No se puede instanciar Instrumento, pero si se puede instanciar Saxofon, Guitarra o Violin.](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/99e843e2-8667-4788-acda-a15ede448116/Untitled.png)

No se puede instanciar Instrumento, pero si se puede instanciar Saxofon, Guitarra o Violin.

<aside>
<img src="/icons/code_pink.svg" alt="/icons/code_pink.svg" width="40px" /> Utilizar cuando exista una clase de la cual es necesario heredar (pues agrupa características y comportamientos) pero que no debe ser instanciada en nuestro programa.

</aside>

### Método Abstracto



Cuando no necesitamos definir un método podemos indicarlo como abstracto. Obliga que la clase derivada implemente el método.

```java
public abstract void imprimirDatos();
// public void imprimirDatos(){};
```

## Interfaz



- Define el comportamiento de una clase pero no la implementación.
- Las interfaces se utilizan para definir funciones específicas para las clases que no tienen necesariamente una relación de identidad.
- No se establece el modo de acceso de los métodos de una interfaz. Por defecto son públicos.

```java
interface IhabilidadCanto{
	void cantar();
}
public class Canario implements IHabilidadCanto{
	public void cantar(){
		System.out.println(" pio pio pio ");
	}
}
```

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/c093fd59-e937-4883-b30d-148b0e1ab191/Untitled.png)

<aside>
<img src="/icons/code_pink.svg" alt="/icons/code_pink.svg" width="40px" /> Utilizar cuando notamos comportamientos similares que obligatoriamente deben ser implementados por algunas clases.

</aside>

### Clase Abstracta vs. Interfaz



Comparacion entre clases abstractas e inferfaces.

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/041abbac-6e37-4ebf-a210-eb2fa487d756/Untitled.png)

## Miembros Estáticos



- Constituyen datos, métodos y tipos que forman parte de un tipo de dato (por ejemplo, una clase) pero que no requieren una instancia de este para ser utilizados.
- En Java, cuando declaras una variable como **`static`**, estás indicando que esa variable pertenece a la clase en sí, en lugar de pertenecer a una instancia específica de la clase.

<aside>
<img src="/icons/code_pink.svg" alt="/icons/code_pink.svg" width="40px" /> **Compartir datos entre instancias:** Una variable **`static`** se comparte entre todas las instancias de la clase. Esto significa que si modificas su valor en una instancia, ese cambio se reflejará en todas las demás instancias de la misma clase.

</aside>

## Clase Anidada



- Es una clase definida como miembro de otra clase.
- En general, un tipo de dato definido dentro de otro se le llama tipo de dato anidado.
- Se le conoce como clase inner, y a la clase dentro de la que se definen, clase outer.

```java
public class Computador{
	public void imprimir(){
		System.out.println("Imprimir desde Computador");
	}
	public class Microprocesador{
		public void imprimir(){
			System.out.println("Imprimir desde Microprocesador");
		}
	}
}
```

```java
public class Principal{
	public static void main(String[] args){
		Computador c = new Computador();
		c.imprimir();
		Computador.Microprocesador m = c.new Microprocesador();
		m.imprimir();
	}
}
```

## Enumerados



La enumeración (también denominado enum) proporciona una manera eficaz de definir un conjunto de constantes integrales con nombre que pueden asignarse a una variable.

```java
public enum Dias{
	Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado
}
Dias d = Dias.Domingo;
```

## Arreglos



La enumeración (también denominado enum) proporciona una manera eficaz de definir un conjunto de constantes integrales con nombre que pueden asignarse a una variable.

```cpp
public class EjemploArreglos {
    public static void main(String[] args) {
        // Declaración e inicialización de un arreglo de enteros
        int[] numeros = new int[5]; // Arreglo de tamaño 5
        // Asignación de valores al arreglo
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;
    }
}
```

## Get y Set



Las propiedades deben manejarse de forma privada y se deben establecer métodos para modificar y leer estos valores.

```java
public class Persona {
	private String nombre;
  private int edad;

  public String getNombre() {
    return nombre;
  }

  public void setNombre(String nombre) {
    this.nombre = nombre;
  }

  public int getEdad() {
    return edad;
  }

  public void setEdad(int edad) {
    this.edad = edad;
  }
}
```

# Anotaciones de Programación



Anotaciones útiles para los lenguajes de programación Java y C#. Servirán y serán útiles al momento de desarrollar los programas.

## Java



1. Para el uso de `ArrayList<>` es necesario importar la librería `java.util.ArrayList`.
2. Para convertir de entero a String: `Integer.parseInt(variable)`.
3. Para convertir de String a entero: `Integer.toString(variable)`.
4. Para lectura por teclado:
    
    ```java
    import java.util.Scanner;
    Scanner teclado = new Scanner(System.in);
    nombre = teclado.nextLine();
    ```
    
    ```java
    import java.io.*;
    BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
    nombre = teclado.readLine();
    ```
    
5. Para manejo de fechas: clase Date
    
    ```java
    import java.text.SimpleDateFormat;
    import java.util.Date;
    SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
    Date date = formato.parse("24-12-2012");
    System.out.println(formato.format(date));
    ```
    

## C#



1. Para el uso de `List<>` es necesario importar la librería `System.Collections.Generic`.
2. Para el uso de `BindingList<>` es necesario importar la librería `System.ComponentModel`.
3. Para convertir de entero a String: `variable.ToString()`.
4. Para convertir de String a entero: `Int32.Parse()`.
5. Para lectura por teclado:
    
    ```csharp
    nombre = System.Console.ReadLine()
    ```
    
6. Para manejo de fechas: clase DateTime
    
    ```csharp
    using System;
    DateTime fecha = Convert.ToDateTime("18-09-2012");
    System.Console.WriteLine(fecha.ToString("dd-MM-yyyy"));
    ```
    

# Librerías



Una librería es un programa cuyos elementos pueden ser utilizados por otros programas. La forma de crear y utilizar una librería dependen del lenguaje de programación o del sistema operativo.

## Paquetes



Un Paquete en Java es un contenedor de clases que permite agrupar las distintas partes de un programa y que por lo general tiene una funcionalidad y elementos comunes, definiendo la ubicación de dichas clases en un directorio de estructura jerárquica.

![Ejemplo de estructura de paquetes](https://prod-files-secure.s3.us-west-2.amazonaws.com/ef662f39-07c9-4823-9793-3963f5e3ea5b/f6a84f4b-f415-4eeb-94e5-d641e9f2121b/Untitled.png)

Ejemplo de estructura de paquetes

```java
package matematicas;
public class Operacion{
	public int sumar(int a, int b){
		return a + b;
	}
	public int restar(int a, int b){
		return a - b;
	}
}
```

```java
package principales;
import matematicas.*;
public class Principal{
	public static void main(String[] args){
		Operacion op = new Operacion();
		int x = op.sumar(10,90);
		int y = op.restar(10,90);
		System.out.println(x);
		System.out.println(y);
	}
}
```

## Librerías en Java



Están estrechamente relacionadas a los directorios. Una librería es un directorio con un conjunto de archivos `CLASS` que forman parte de la librería. Para encontrar una librería, tanto el compilador como el intérprete utilizan la variable de entorno `CLASSPATH`.

### Creación



1. Generar los archivos CLASS que conformarán la librería.
2. Empaquetar los archivos CLASS mediante el siguiente comando: `jar cvf "nombre del paquete" [clases]`.

### Archivos JAR



1. Comprimen uno o más paquetes conservando la información acerca de los directorios (paquetes) donde se encuentran cada archivo `.CLASS`.
2. Pueden ser utilizados en `CLASSPATH` como lugares de búsqueda de archivos `.CLASS`.
3. Constituyen una mejor forma distribuir un conjunto de archivos `.CLASS`, como los que forman una aplicación, dado que se tiene la opción de comprimir estos.

## Espacios de Nombres en C#



Proporcionan los medios para agrupar lógicamente las clases relacionadas en sus correspondientes espacios de nombres, haciendo así el sistema más modular

![Ejemplo de estructura de espacios de nombres](https://prod-files-secure.s3.us-west-2.amazonaws.com/ef662f39-07c9-4823-9793-3963f5e3ea5b/e01b258a-7637-4146-bb28-e77f104221ac/Untitled.png)

Ejemplo de estructura de espacios de nombres

```csharp
namespace matematicas{
	public class Operacion{
		public int sumar(int a, int b){
			return a + b;
		}
		public int restar(int a, int b){
			return a - b;
		}
	}
}
```

```csharp
using matematicas;
namespace principales{
	public class Principal{
		public static void Main(string[] args){
			Operacion op = new Operacion();
			int x = op.sumar(10,80);
			int y = op.restar(10,80);
			System.Console.WriteLine(x+" "+y);
		}
	}
}
```

## Librerías en C# (DLLs)



Problemas encontrados en la utilización de DLLs:

- Si al desinstalar un programa, este elimina una DLL que es utilizada por otro programa, este último dejará de funcionar correctamente.
- Si un usuario cambia de posición el archivo de la DLL utilizada por un programa, este quizá no lo encuentre, por lo que dejará de funcionar correctamente.

# Conexión a Base de Datos



Para establecer una conexión a base de datos es necesario utilizar una interface de aplicaciones (API) que permita acceder a los datos almacenados en sistemas gestores de bases de datos (DBMS) tanto relacionales como no relacionales, utilizando SQL (Lenguaje de Consulta Estructurado).

## JAVA: JDBC



JDBC es una API que permite la ejecución de operaciones sobre bases de datos desde el lenguaje de programación Java, independientemente del sistema operativo donde se ejecute o de la base de datos a la cual se accede, utilizando el dialecto SQL del modelo de base de datos que se utilice.

![Funcionamiento de JDBC](https://prod-files-secure.s3.us-west-2.amazonaws.com/ef662f39-07c9-4823-9793-3963f5e3ea5b/960ff3d9-af3a-49eb-ae1c-a946190fd142/Untitled.png)

Funcionamiento de JDBC

## JAVA Driver



Un controlador o driver JDBC es un componente de software que permite conectar con bases de datos individuales. La interfaz JDBC requiere controladores (drivers) para cada base de datos. El controlador JDBC ofrece la conexión a la base de datos específica e implementa el protocolo para la transferencia de las consultas y resultados entre el cliente (aplicación) y la base de datos.

## MySQL JDBC Driver



- Nombre del Driver: com.mysql.jdbc.Driver
- Formato URL: jdbc:mysql://hostname/databaseName

## Connection



Un objeto **Connection** representa una conexión a una base de datos. La forma estándar de establecer una conexión con una base de datos es llamando al método DriverManager.getConnection. Este método toma como parámetro una cadena de caracteres que contiene una URL, usuario y password.

```java
Connection con = DriverManager.getConnection(url, usuario, password)
```

### Estableciendo la conexión



La conexión se realiza de la siguiente manera:

```java
try {
	//registrar el Driver
	Class.forName("com.mysql.cj.jdbc.Driver");
	//establecer la conexión
	Connection con = DriverManager.getConnection("jdbc:mysql://50.62.209.73/inf282", "inf282", "inf282lp2");
} catch (Exception ex) {
	System.out.println(ex.getMessage());
}
```

## Statement



Un objeto **Statement** se usa para enviar sentencias SQL a una base de datos. Una vez que se ha establecido una conexión con una base de datos particular, esa conexión puede ser usada para enviar sentencias SQL. Un objeto **Statement** se crea con el método `createStatement` de Connection como en el siguiente fragmento de código

```java
Statement stmt = con.createStatement();
```

- El método `executeQuery(sqlString)` es para sentencias SQL tipo SELECT.
- El método `executeUpdate(sqlString)` es para sentencias SQL tipo INSERT, UPDATE, DELETE.

### Insert



Aplicación de un insert para el statement.

```java
Statement sentencia = con.createStatement();
String query =
	"INSERT INTO empleado (dni,nombres,apellido_paterno,apellido_materno) "
	+ "values "
	+ "('12114689','Jorge','Mendoza','Lopez')";
int i = sentencia.executeUpdate(query);
con.close();
```

### Update



Aplicación de un update para el statement.

```java
Statement sentencia = con.createStatement();
String query =
	"UPDATE empleado SET nombres = 'Karla Celeste' "
	+ "WHERE "
	+ "dni = '18276221'";
int i = sentencia.executeUpdate(query);
con.close();
```

### Delete



Aplicación de un delete para el statement.

```java
Statement sentencia = con.createStatement();
String query =
	"DELETE FROM empleado WHERE dni = '18276221'";
int i = sentencia.executeUpdate(query);
con.close();
```

<aside>
💡 Este tipo de delete es físico, lo ideal es realizar uno lógico en el que el atributo activo de la entidad cambie a 0 o false.

</aside>

## ResultSet



Un **ResultSet** contiene todos los registros (filas) que satisfacen las condiciones impuestas en una sentencia SQL y proporciona acceso a los datos en dichos registros a través de un conjunto de métodos `get` que permiten acceder a los diferentes campos o atributos (columnas) del registro actual. Un **ResultSet** mantiene un cursor que apunta al registro actual. El método `ResultSet.next()` se usa para moverse al siguiente registro del **ResultSet**, haciendo el siguiente registro el registro actual.

### Select



Aplicación de un select para el statement.

```java
Statement sentencia = con.createStatement();
String query =
	"SELECT * FROM empleado";
ResultSet rs = sentencia.executeQuery(query);
while(rs.next()){
	String dni = rs.getString("dni");
	String nombres = rs.getString("nombres");
	String apellido_paterno = rs.getString("apellido_paterno");
	String apellido_materno = rs.getString("apellido_materno");
	System.out.println(dni +" "+nombres+" "+apellido_paterno+" "+apellido_materno);
}
con.close();
```

# Procedimientos Almacenados



Es un programa dentro de la base de datos que ejecuta una acción o conjunto de acciones especificas. Un procedimiento tiene un nombre, un conjunto de parámetros y un bloque de código.

```sql
DELIMITER $$
CREATE PROCEDURE insertarEmpleado(
	IN _dni VARCHAR(8),
	IN _nombres VARCHAR(100),
	IN _apellido_paterno VARCHAR(100),
	IN _apellido_materno VARCHAR(100))
BEGIN
	INSERT INTO empleado (dni, nombres, apellido_paterno,
		apellido_materno) VALUES (_dni, _nombres, _apellido_paterno,
		_apellido_materno);
END
```

<aside>
💡 Se suele colocar un ‘_’ antes para diferencias el atributo del valor que se quiere ingresar (para que no exista ambigüedades).

</aside>
## CallableStatement
Es la interfaz utilizada para ejecutar procedimientos SQL almacenados. Los parámetros de entrada se establecen utilizando el método set. Un objeto de tipo **CallableStatement** puede retornar un objeto de tipo ResultSet o un boolean. Los parámetros de salida deben registrarse antes de la ejecución del procedimiento almacenado y ser recuperados después de la ejecución.

```java
import java.sql.CallableStatement;

Class.forName("com.mysql.jdbc.Driver");
Connection con =
	DriverManager.getConnection("jdbc:mysql://50.62.209.73/prueba", "prueba","lp2");
CallableStatement cStmt = con.prepareCall("{call insertarEmpleado(?,?,?,?)}");
cStmt.setString("_dni", "12456111");
cStmt.setString("_nombres", "Freddy Alberto");
cStmt.setString("_apellido_paterno", "Paz");
cStmt.setString("_apellido_materno", "Espinoza");
cStmt.execute();
```
### Ejemplo de Procedimiento Almacenado con parámetro salida
Tenemos la siguiente tabla de empleados.
```sql
CREATE TABLE empleado2 (
	id INT AUTO_INCREMENT,
	nombres VARCHAR(50),
	apellido_paterno VARCHAR(50),
	apellido_materno VARCHAR(50),
	PRIMARY KEY (id)
);
```
Ahora crearemos un procedimiento para insertar un empleado.
```sql
DELIMITER $$
CREATE PROCEDURE INSERTAR_EMPLEADO_2(
	OUT _id INT,
	IN _nombres VARCHAR(100),
	IN _apellido_paterno VARCHAR(100),
	IN _apellido_materno VARCHAR(100))
BEGIN
	INSERT INTO empleado2 (nombres, apellido_paterno,
		apellido_materno) VALUES (_nombres, _apellido_paterno,
		_apellido_materno);
	SET _id = last_insert_id();
END
```
Podemos probar si el procedimiento funciona de la siguiente manera.
```sql
SET @ID = 0;
CALL INSERTAR_EMPLEADO_2(@ID, 'Juan', 'Perez', 'Sandoval');
SELECT @ID;
```
Ahora, una vez nos aseguramos que funciona en el MySQL, lo implementamos en el Java.
```java
Class.forName("com.mysql.jdbc.Driver");
Connection con = 
	DriverManager.getConnection("jdbc:mysql://50.62.209.73/prueba","prueba", "lp2");
CallableStatement cStmt = con.prepareCall("{call INSERTAR_EMPLEADO_2(?,?,?,?)}");
cStmt.registerOutParameter("_id", java.sql.Types.INTEGER);
cStmt.setString("_apellido_paterno", "Paz");
cStmt.setString("_nombres", "Freddy Alberto");
cStmt.setString("_apellido_materno", "Espinoza");
cStmt.execute();
int id = cStmt.getInt("_id");
System.out.println(id);
```
### Ejemplo e implementación en C#
```csharp
MySqlConnection con = new MySqlConnection(cadena);
con.Open();
MySqlCommand comando = new MySqlCommand();
comando.Connection = con;
comando.CommandType = CommandType.StoredProcedure;
comando.CommandText = "INSERTAR_PROFESOR";
comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = "Juan";
comando.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = "Perez";
comando.Parameters.Add("_id_profesor", MySqlDbType.Int32).Direction = ParameterDirection.Output;
comando.ExecuteNonQuery();
int numero = Int32.Parse(comando.Parameters["_id_profesor"].Value.ToString());
System.Console.WriteLine(numero);
System.Console.Read();
con.Close();
```
### Procedimiento Almacenado para listar empleados
```sql
DELIMITER $$
CREATE PROCEDURE LISTAR_EMPLEADOS()
BEGIN
	SELECT * FROM empleado;
END
```
```java
Class.forName("com.mysql.jdbc.Driver");
Connection con =
	DriverManager.getConnection("jdbc:mysql://50.62.209.73/prueba","prueba", "lp2");
CallableStatement cStmt = con.prepareCall("{call LISTAR_EMPLEADOS()}");
ResultSet rs = cStmt.executeQuery();
while (rs.next()){
	String dni = rs.getString("dni");
	System.out.println(dni);
}
```
### Procedimiento Almacenado para buscar empleados
```sql
DELIMITER //
CREATE PROCEDURE BUSCAR_EMPLEADO(
	IN variable VARCHAR(50)
)
BEGIN
	SELECT * from empleado where nombres like Concat('%',variable,'%');
END
```
