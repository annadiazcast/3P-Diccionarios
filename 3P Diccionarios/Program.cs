using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> Libro = new Dictionary<int,string>();
            //INT = ID y string es el nombre
            Libro.Add(1, "The Maze Ruuner");
            Libro.Add(2, "Almendra");
            Libro.Add(3, "The Hunger Games");
            Libro.Add(4, "Correr o morir");
            Libro.Add(5, "Babel");
            Libro.Add(6, "El Principito");
            Libro.Add(7, "Peter Pan");
            Libro.Add(8, "Cura Mortal");
            Libro.Add(9, "Alice in Wonderland");
            Libro.Add(10, "Once Upon a Broken Heart");

        }
    }
}
