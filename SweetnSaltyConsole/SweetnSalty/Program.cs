using System;

namespace SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            string sweet = "Sweet";
            string salty = "Salty";
            string both = "Sweet'n Salty";

            int sweetTotal = 0;
            int saltyTotal = 0;
            int bothTotal = 0;

            for(int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.Write(both + " ");
                    bothTotal++;
                }
                else if (i % 3 == 0)
                {
                    System.Console.Write(sweet + " ");
                    sweetTotal++;
                }
                else if (i % 5 == 0)
                {
                    System.Console.Write(salty + " ");
                    saltyTotal++;
                }
                else { System.Console.Write(i + " "); }

                if(i % 10 == 0)
                {
                    System.Console.WriteLine();
                }
            }

            System.Console.WriteLine($"Sweets: {sweetTotal}");
            System.Console.WriteLine($"Salty: {saltyTotal}");
            System.Console.WriteLine($"Sweet'n Salty: {bothTotal}");

        }
    }
}
