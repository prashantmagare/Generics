using System;

namespace Max_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find Max Int  Number using Generic Method");
            Refactor_to_generic<int>.FindMax<int>(11, 22, 9, 44);

            Console.WriteLine("Find Max Double  Number using Generic Method");
            Refactor_to_generic<double>.FindMax<double>(11.3, 22.23, 9.55, 30.5);

            Console.WriteLine("Find Max String Number using Generic Method");
            Refactor_to_generic<double>.FindMax<string>("Apple", "Banana", "Orange", "Peach");

        }
    }
}