using System;

namespace Max_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Int  Number using Generic Method");
            Refactor.FindMax<int>(11, 22, 9);

            Console.WriteLine("Find Max Double  Number using Generic Method");
            Refactor.FindMax<double>(11.3, 22.23, 9.55);

            Console.WriteLine("Find Max String Number using Generic Method");
            Refactor.FindMax<string>("Apple", "Peach", "Banana");
        }
    }
}