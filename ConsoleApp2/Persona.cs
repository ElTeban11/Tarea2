using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Persona
    {
        public string Nombre { get; set; } 
        public Casa Casa { get; set; }

        public Persona()
        {
            Nombre = "Juan";
            Casa = new Casa(150);
        }

        public Persona(string nombre,Casa casa)
        {
            Nombre = nombre;
            Casa = casa;
        }

        public void SetNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre;
        }

        public void SetCasa(Casa nuevaCasa)
        {
            Casa = nuevaCasa;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Mi nombre es " + Nombre);
            Casa.MostrarDatos();
        }
    }
}
