using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете десетично число");
            int chislo = int.Parse(Console.ReadLine());
            string chislo2 = Convert.ToString(chislo, 2);
            Console.WriteLine("Desetichno: " + chislo);
            Console.WriteLine("Dvoichno: " + chislo2);
            string chislo16 = Convert.ToString(chislo, 16);
            Console.WriteLine("Shestnadesetichno: " + chislo16);
        }
    }
}
