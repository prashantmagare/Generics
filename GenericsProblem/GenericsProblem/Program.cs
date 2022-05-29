using System;

namespace Max_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UseCase 1 Find Max Int  Number");

            int intOutput = MaxNumberCheck.MaxNumbermethod_Int(11, 22, 33);
            Console.Write(intOutput);
        }
    }
}