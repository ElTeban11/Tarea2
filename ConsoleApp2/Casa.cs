using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;


namespace ConsoleApp2
{
    public class Casa
    {
        public int Area {  get; set; }
        public Puerta Puerta { get; set; }

        public Casa(int area)
        {
            Area = area;
            Puerta = new Puerta();
        }


        public void SetArea(int nuevaArea)
        {
            Area = nuevaArea;
        }

        public void SetPuerta(Puerta puertaNueva) 
        {
            Puerta = puertaNueva;
        }


        public virtual void MostrarDatos()
        {
            Console.WriteLine("Yo soy una Casa, mi área es de " + Area + " m2");
            Puerta.MostrarDatos();
        }

    }
}
