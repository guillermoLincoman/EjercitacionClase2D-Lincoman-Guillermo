using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string edadAux;
            /*Console.WriteLine($"{nombre} tenes {edad} años");
            Console.WriteLine($"{0} tenes {1} años", nombre, edad);*/

            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Edad");
            edadAux = Console.ReadLine();

            //para escribir flotantes
            float precio = 43.3245f;
            //No hace falta la f
            double doble = 35.3;
            //Es mas preciso que double
            decimal numeroDecimal = 26.4M;
            //Toma el primer dato que se le ingresa y se convierte a ese tipo
            var edad2 = 4;

            if (int.TryParse(edadAux, out edad))
            {
                Console.WriteLine($"{nombre} tu edad es {edad}");
            }
            else {
                Console.WriteLine($"{nombre}, escribi una edad valida gato");
            }
            Console.WriteLine($"Asi mascarizo un flotante {precio:C2}");

        }
    }
}
