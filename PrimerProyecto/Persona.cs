using System;
namespace PrimerProyecto
{
    public class Persona
    {
        private string name;
        private string sirname;
        public Persona(string name, string sirname)
        {
            this.name = name;
            this.sirname = sirname;
        }
        public string GetName()
        {
            return name;
        }
        public string GetSirname()
        {
            return sirname;
        }
        public int Lanzar()
        {
            int randomnumber;
            Random number = new Random();
            randomnumber = number.Next(0, 3);
            return randomnumber;
        }
    }
}
