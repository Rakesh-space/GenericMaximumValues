using System;

namespace GenericMaximumValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC2MaximumValueGeneric class:");
            Console.WriteLine("\n Enter the 3 interger variable:");
            int first = Convert.ToInt32(Console.ReadLine());
            int secound = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the 3 double variable:");
            double first1 = Convert.ToDouble(Console.ReadLine());
            double secound1 = Convert.ToDouble(Console.ReadLine());
            double third1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Enter the 3 character variable:");
            char first3 = Convert.ToChar(Console.ReadLine());
            char secound3 = Convert.ToChar(Console.ReadLine());
            char third3 = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("\n Integer Maximum vlaue {0} out of 3 Variable.", UC2MaxFloatThree.maxValue1(first, secound, third));
            Console.WriteLine("\n Double Maximum vlaue {0} out of 3 Variable.", UC2MaxFloatThree.maxValue2(first1, secound1, third1));
            Console.WriteLine("\n Charecter Maximum vlaue {0} out of 3 Variable.", UC2MaxFloatThree.maxValue3(first3, secound3, third3));
        }
    }
}
