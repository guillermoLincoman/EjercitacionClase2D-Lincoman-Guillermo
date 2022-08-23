using System;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMax = int.MinValue;
            int numMin = int.MaxValue;
            int acumNumeros = 0;
            int cantNumeros = 5;
            int i = 0;
            int numIngresado;
            while (i != cantNumeros)
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numIngresado))
                {
                    if (numIngresado < numMin)
                    {
                        numMin = numIngresado;
                    }
                    if (numIngresado > numMax)
                    {
                        numMax = numIngresado;
                    }
                    acumNumeros += numIngresado;
                    i++;
                }else
                {
                    Console.WriteLine("Numero no valido");
                }
            }
            float promNumeros = (float)acumNumeros / cantNumeros;
            Console.WriteLine($"\nNumeros Maximo {numMax}\nNumeros Minimo {numMin}\nNumeros promedio {promNumeros}\n");
        }
    }
}
