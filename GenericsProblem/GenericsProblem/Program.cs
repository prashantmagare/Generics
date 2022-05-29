using System;

namespace Max_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UseCase 3 Find Max String  Number");

            string stringOutput = MaxNumberCheck_String.MaxNumbermethod_String("Apple", "Banana", "Peach");
            Console.Write(stringOutput);
        }
    }
}