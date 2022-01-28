using System;

namespace BlendeaCiaoAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dimmi il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ciao{nome}");
        }
    }
}
