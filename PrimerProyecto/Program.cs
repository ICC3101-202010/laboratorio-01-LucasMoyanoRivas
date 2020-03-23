using System;

namespace PrimerProyecto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona jugador = new Persona("Bob", "Kunga");
            Console.WriteLine($"El jugador llamado {jugador.GetName()} {jugador.GetSirname()}, ha jugado {jugador.Lanzar()}");

        }
       

    }
}
