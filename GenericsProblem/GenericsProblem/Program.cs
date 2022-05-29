using System;

namespace Max_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("UseCase 1 Find Max Int  Number");

            //int intOutput = MaxNumberCheck_Double.MaxNumbermethod_Int(11, 22, 33);
            //Console.Write(intOutput);
            Console.WriteLine("UseCase 2 Find Max Double  Number");

            double doubleOutput = MaxNumberCheck_Double.MaxNumbermethod_Double(112.3, 22.23, 33.6);
            Console.Write(doubleOutput);
        }
    }
}