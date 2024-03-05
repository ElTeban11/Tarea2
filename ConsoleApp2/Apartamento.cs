using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Apartamento : Casa
    {
        public Apartamento() : base(50)
        {
            
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Soy un Apartamento mi área es " + Area );
            base.MostrarDatos();
        }
    }
}
