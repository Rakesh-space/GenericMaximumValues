using System;

namespace GenericMaximumValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC3MaximumValueGeneric class:");
            Console.WriteLine("\n Enter the frirs String:");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Enter the Secound String:");
            string secound = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Enter the third String:");
            string third = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Maximum vlaue {0} out of 3 Variable.", UC3MaxStringThree.maxValue(first, secound, third)); 
        }
    }
}
