using System;

namespace FindMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number :");
            FindMaximumNum find = new FindMaximumNum();//Create object fot findmaximumnum
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));//find the max value
           
        }
    }
    

}
