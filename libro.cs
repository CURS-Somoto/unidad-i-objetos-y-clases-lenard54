using System;

public class Libro
{
    // Propiedades
    public string Título { get; set; }
    public string Autor { get; set; }

    public void Mostrarinformación() 
    {
     System.Console.WriteLine("Titulo: " + titulo);
     System.Console.WriteLine("Autor: " + autor);
     System.Console.WriteLine(" ");
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        Libro libro1 = new Libro();
        libro1.titulo = "EL QUIJOTE";
        libro1.autor = "Miguel de Cervantes";

        Libro libro2 = new Libro();
        libro2.titulo = "LA ODISEA";
        libro2.autor = "Homero";

        libro1.Mostrarinformación();
        libro2.Mostrarinformación();

    }
}
