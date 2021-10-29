using System;

namespace GenericMaximumValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC5MaximumValueGeneric class:");
            int[] arr = { 30, 2, 6 };
            UC5MaximumValueGeneric<int> gen = new UC5MaximumValueGeneric<int>(arr);
            gen.PrintMaxValue();
        }
    }
}
