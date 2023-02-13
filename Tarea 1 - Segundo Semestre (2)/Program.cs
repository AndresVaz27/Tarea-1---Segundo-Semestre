using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1___Segundo_Semestre__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            Console.WriteLine("Bienvenido al memorizador de Mascotas Felinas.\nCual es el nombre de tu gato?");
            gato.nombre = Console.ReadLine(); gato.Guardarnom(); Console.WriteLine("Presiona ENTER para continuar."); Console.ReadKey(); Console.Clear();
            Console.WriteLine("Cuantos años tiene?");
            gato.edad = int.Parse(Console.ReadLine()); gato.Guardaredad(); Console.WriteLine("Presiona ENTER para continuar.");Console.ReadKey(); Console.Clear();
            Console.WriteLine("Cual es su juguete favorito?");
            gato.juguetefav = Console.ReadLine();Console.Clear();
            Console.WriteLine("De que color es?");
            gato.color = Console.ReadLine();Console.Clear();
            Console.WriteLine("Cual es su comida favorita?");
            gato.comidafav= Console.ReadLine();Console.Clear();
            gato.Jugar();gato.Pintura();gato.Comer();
            Console.ReadKey();
        }
    }
}
