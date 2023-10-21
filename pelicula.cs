using System;

public class Película
{
    
    public string Titulo { get; set; }
    public int AnyoLanzamiento { get; set; }
    private int calificacion { get; set; }

    public int Calificacion
    {
        get { return calificacion; }
        set
        {
            if (value >= 1 && value <= 5)
            {
                calificacion = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("La calificación de esta pelicula debe de estar entre 1 y 5.");
            }
        }
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        Pelicula pelicula1 = new Pelicula();
        
            pelicula1.titulo = "La invitación";
            pelicula1.AnyoLanzamiento = 2022;
            pelicula1.Calificacion = 3;
        

        Pelicula pelicula2 = new Pelicula();
        
           pelicula2.titulo = "Los asesinos de la luna";
           pelicula2.AnyoLanzamiento = 2023;
           pelicula2.Calificacion = 5;
        
        System.Console.WriteLine($"Cuando se estreno \"{pelicula1.titulo}\" en el año {pelicula1.AnyoLanzamiento} no me gusto tanto asi que la califique con {pelicula1.Calificacion} estrellas");
        System.Console.WriteLine($"Cuando se estreno \"{pelicula2.titulo}\" en el año {pelicula2.AnyoLanzamiento} me gusto tanto que la califique con {pelicula2.Calificacion} estrellas");
    }
}
