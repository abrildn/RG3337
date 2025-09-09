using System;

namespace RG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar monto de compra:");
            string linea = Console.ReadLine();
            int monto = int.Parse(linea);

            if (monto > 500000)
            {
                int RG3337 = monto * 5 / 10;
                Console.WriteLine($"El monto a retener es: " + RG3337);
            }
            else
            {
                Console.WriteLine("No sos plausible de retención");
            }

            Console.ReadKey();
        }
    }
}