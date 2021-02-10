using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // napishete programa koqto chete sredniq uspeh na uchenicite ot edna grupa i izvejda sredniq uspeh na klasa.
            Console.WriteLine("Kolko uchenici ima?");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            int obshto = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.Write("Vuvedete uspeha: ");
                double uspeh = double.Parse(Console.ReadLine());
                suma = suma + uspeh;
            }
            obshto = suma / n;
            Console.WriteLine("sredniqt uspeh na klasa e {00:f2}",obshto);
        }
    }
}
