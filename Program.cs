using System;

namespace broini_sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            string chislo2 = Convert.ToString(chislo,2);
            Console.WriteLine("dvuichnoto chislo e " + chislo2);
        }
    }
}
