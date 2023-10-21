using System;

public class Empleado
{
   
    public string Nombre { get; set; }
    public double Salario { get; set; }

    
    public double CalcularSalarioAnual()
    {
    double total = this.salario * 12;
    return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado();

            empleado1.nombre = "Leonel";
            empleado1.salario = 5000;
             
        Empleado empleado2 = new Empleado();

            empleado2.nombre = "Selene";
            empleado2.salario = 3000;

        Empleado empleado3 = new Empleado();

            empleado3.nombre = "Julio";
            empleado3.salario = 7000;
            
               System.Console.WriteLine($"Nuestro empleado {empleado1.nombre} gana un salario mensual de { empleado1.salario} y uno anual de {empleado1.CalcularSalarioAnual()}.");
               System.Console.WriteLine($"Nuestra empleada {empleado2.nombre} gana un salario mensual de { empleado2.salario} y uno anual de {empleado2.CalcularSalarioAnual()}.");
               System.Console.WriteLine($"Nuestro empleado {empleado3.nombre} gana un salario mensual de { empleado3.salario} y uno anual de {empleado3.CalcularSalarioAnual()}.");
    }
}
