using System;

namespace SelectionStat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(30);
            Console.WriteLine("Try to guess my favorite number");
            var userlnput = int.Parse(Console.ReadLine());
            if (userlnput < 30)
            {
                Console.WriteLine($"Too low");
            }

            else if (userlnput > 30)
            {
                Console.WriteLine($"Too high");
            }
            else 
            {
                Console.WriteLine($"Nevermind");
            }




           
        }
    }
}
