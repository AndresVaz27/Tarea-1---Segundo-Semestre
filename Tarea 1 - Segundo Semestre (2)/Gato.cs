using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1___Segundo_Semestre__2_
{
    public class Gato
    {
        public string nombre;
        public int edad;
        public string juguetefav;
        public string color;
        public string comidafav;

        public void Guardarnom()
        {
            Console.WriteLine("Se ha guardado el nombre de tu Mascota: " + nombre);
        }
        public void Guardaredad()
        {
            Console.WriteLine("Se ha guardado la edad de tu Mascota: " + edad);
        }
        public void Jugar() 
        {
            Console.WriteLine(nombre + " juega con su juguete favorito ---> " + juguetefav);
        }
        public void Pintura()
        {
            Console.WriteLine(nombre + " tiro un bote de pintura y ya no es color " + color);
        }
        public void Comer()
        {
            Console.WriteLine(nombre + " se puso triste y fue a comer su comida favorita para terminar el dia.");
        }
    }
}
