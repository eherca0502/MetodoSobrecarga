using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escuela miEscuela = new Escuela("Mi escuela", "Calle principal 123");

            miEscuela.MostrarInformacion();
            Console.WriteLine();
            miEscuela.MostrarInformacion("Información de la escuela:");
            Console.WriteLine();
            miEscuela.MostrarInformacion("Información de la escuela:", true);

            Console.ReadKey();
        }
    }
}
