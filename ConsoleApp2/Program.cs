using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Persona persona = new Persona();
           persona.MostrarDatos();
            persona.Nombre = "Carlos";
            Apartamento nuevoApartamento = new Apartamento();
            Puerta nuevaPuerta = new Puerta("Verde");
            nuevoApartamento.SetPuerta(nuevaPuerta);
            persona.SetCasa(nuevoApartamento);
            persona.MostrarDatos(); 

        }
    }
}
