using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[3];
            nombres[0] = "Juan";
            nombres[1] = "Ruban";
            nombres[2] = "Nacho";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }


            string[] paises = { "Brasil", "Peru", "Chile" };

            foreach (var loQueGuardo in paises)
            {
                Console.WriteLine(loQueGuardo);
            }
        }
    }
}
