using System;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi dvoichno chislo: ");
            string bin = Console.ReadLine();
            int dec = Convert.ToInt32(bin, 2);
            Console.WriteLine("Desetichnoto: "+dec);
            Console.WriteLine("Dvoichno: " +bin);
        }
    }
}
