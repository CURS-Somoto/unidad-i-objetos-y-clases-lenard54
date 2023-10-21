using System;

public class Mascota
{
  public string nombre
        {
            get;
            set;
        }
        public string tipo
       {
            get;
            set;
        }
        public int edad
        {
            get;
            set;
        }   
}

class Program
{
    static void Main(string[] args)
    {
        Mascota mascota1 = new Mascota();
        mascota1.nombre = "Bruno";
        mascota1.tipo = "Gato" ;
        mascota1.edad = 2;

        Mascota mascota2 = new Mascota();
        mascota2.nombre = "Max";
        mascota2.tipo = "perro" ;
        mascota2.edad = 4;

        Mascota mascota3 = new Mascota();
        mascota3.nombre = "Igor";
        mascota3.tipo = "perico";
        mascota3.edad = 3;


       System.Console.WriteLine($"Mi mascota se llama {mascota1.nombre} es un {mascota1.tipo} y tiene {mascota1.edad} años.");
       System.Console.WriteLine($"Mi mascota se llama {mascota2.nombre} es un {mascota2.tipo} y tiene {mascota2.edad} años.");
       System.Console.WriteLine($"Mi mascota se llama {mascota3.nombre} es un {mascota3.tipo} y tiene {mascota3.edad} años.");
    
    }
}
