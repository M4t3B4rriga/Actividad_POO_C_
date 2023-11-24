# UNIVERSIDAD DE ALS FUERZAS ARMADAS ESPE 
Nombre : Mateo Barriga 
Fecha: 24/11/2023
NRC: 14956
## Objetivos: 
Refrozar el aprendizaje que se a tenido mediante los cursos propuestos por el porfesor, para poder realizar la actividad puesta en clase. 

## Ejercicio 
1. Definición de Clases:
- Define una clase Empleado con los siguientes atributos:
- Nombre (string)
- Salario (double)
- Implementa un método en la clase `Empleado` para calcular el salario anual.
2. Herencia:
- Crea una clase Gerente que herede de la clase Empleado.
- Agrega un nuevo atributo para el departamento que supervisa en la clase Gerente.
3. Interfaz:
- Define una interfaz IMostrarInformacion con un método para mostrar información
general.
4. Implementación:
- Implementa la interfaz IMostrarInformacion en ambas clases (Empleado y Gerente).
- Crea instancias de Empleado y Gerente y muestra su información utilizando el
polimorfismo a través de la interfaz.

### Realizacion de la actividad 
#### Punto 1:
Creamos cada una de las clases que se ha propuesto para el ejercicio. 
```c#
public class Empleado : IMostrarInformacion
{
    // Atributos
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}
```
#### Punto 2
Creamos la herencia de nuestra clase gerente y las relacionamos. 

```c#
public class Gerente : Empleado, IMostrarInformacion
{
    // Nuevo atributo para el departamento que supervisa
    public string Departamento { get; set; }

    // Constructor
    public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Implementación del método de la interfaz
    public new void MostrarInformacion()
    {
        Console.WriteLine($"Gerente - Nombre: {Nombre}, Salario: {Salario:C}, Salario Anual: {CalcularSalarioAnual():C}, Departamento: {Departamento}");
    }
}
```
#### Punto 3:
Creamos nuestra interfas: 
```C#
// Definición de la interfaz
public interface IMostrarInformacion
{
    void MostrarInformacion();
}
```
#### Punto 4:
 Realizamos la implementacion de la interfaz: 
 ```C#
 // Implementación de la interfaz clase empleado 
    public void MostrarInformacion()
    {
        Console.WriteLine($"Empleado - Nombre: {Nombre}, Salario: {Salario:C}, Salario Anual: {CalcularSalarioAnual():C}");
    }

 // Implementación del método de la interfaz en clase gerente
    public new void MostrarInformacion()
    {
        Console.WriteLine($"Gerente - Nombre: {Nombre}, Salario: {Salario:C}, Salario Anual: {CalcularSalarioAnual():C}, Departamento: {Departamento}");
    }

class Program
{
    static void Main()
    {
        // Crear instancias de Empleado y Gerente
        Empleado empleado = new Empleado("Juan", 50000);
        Gerente gerente = new Gerente("Ana", 70000, "Ventas");

        // Utilizar polimorfismo a través de la interfaz
        MostrarInformacionGenerico(empleado);
        MostrarInformacionGenerico(gerente);
    }

    // Método para mostrar información genérica utilizando la interfaz
    static void MostrarInformacionGenerico(IMostrarInformacion entidad)
    {
        entidad.MostrarInformacion();
    }
}
```
### Pasos para usar la apliacion 
1. Descargar el repositorio de la aplicacion
https://github.com/M4t3B4rriga/Actividad_POO_C_
2.  Abrir la carpeta de Aplicacion_POO
3. Abrir la terminal del programa para probar su funcionalidad 
4. Dentro de la terminarl ingrear dotnet run 
5. Podra visualizar los datos quemados de la aplicacion. 