using System;

// Definición de la interfaz
public interface IMostrarInformacion
{
    void MostrarInformacion();
}

// Definición de la clase Empleado
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

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación de la interfaz
    public void MostrarInformacion()
    {
        Console.WriteLine($"Empleado - Nombre: {Nombre}, Salario: {Salario:C}, Salario Anual: {CalcularSalarioAnual():C}");
    }
}

// Definición de la clase Gerente que hereda de Empleado
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