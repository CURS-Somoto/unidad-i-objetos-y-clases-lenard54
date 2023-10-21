using System;

public class Estudiante
{
   
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }

     public Estudiante(string nombre, int edad, string curso)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.curso = curso;
    }
   
}

class Program
{
    static void Main(string[] args)
    {
       Estudiante estudiante1 = new Estudiante("Jorge", 18,
    "ingenieria en sistemas.");
  
      Estudiante estudiante2 = new Estudiante("Carlos", 17,
    "derecho.");

      Estudiante estudiante3 = new Estudiante("Cristal", 20,
    "enfermeria.");

      System.Console.WriteLine($"Mi nombre es {estudiante1.nombre} tengo {estudiante1.edad} años y curso la carrera de {estudiante1.curso}");
      System.Console.WriteLine($"Mi nombre es {estudiante2.nombre} tengo {estudiante2.edad} años y curso la carrera de {estudiante2.curso}");
      System.Console.WriteLine($"Mi nombre es {estudiante3.nombre} tengo {estudiante3.edad} años y curso la carrera de {estudiante3.curso}");

    }
}
