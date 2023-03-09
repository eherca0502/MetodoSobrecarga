using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Escuela
    {
        private string nombre;
        private string direccion;

        public Escuela(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre de la escuela: {0}", this.nombre);
            Console.WriteLine("Dirección de la escuela: {0}", this.direccion);
        }
        public void MostrarInformacion(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine("Nombre de la escuela: {0}", this.nombre);
            Console.WriteLine("Dirección de la escuela: {0}", this.direccion);
        }
        public void MostrarInformacion(string mensaje, bool incluirDireccion)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine("Nombre de la escuela: {0}", this.nombre);

            if (incluirDireccion)
            {
                Console.WriteLine("Dirección de la escuela: {0}", this.direccion);
            }
        }
    }
}








