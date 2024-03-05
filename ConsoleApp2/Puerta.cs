using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Puerta
    {
        public string Color {  get; set; }

        public Puerta()
        {
            Color = "Cafe";
        }

        public Puerta(string newcolor)
        {
            Color = newcolor;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Yo soy puerta, mi color es " + Color);
        }
    }
}
