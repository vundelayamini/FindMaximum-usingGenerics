using System;

namespace FindMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number :");
            FindMaximumNum find = new FindMaximumNum();//Create object fot findmaximumnum
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));//find the max  ineger number
            Console.WriteLine(find.MaximumFloatNumber(10.5f, 20.5f, 30.5f));//find the float number


        }
    }
    

}
