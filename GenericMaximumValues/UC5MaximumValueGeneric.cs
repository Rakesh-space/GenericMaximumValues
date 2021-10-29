using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximumValues
{
    class UC5MaximumValueGeneric<T> where T : IComparable //declare the generic class here
    {
        T[] arrName;  //Genric Array declaration
        public UC5MaximumValueGeneric(T[] arrName)  //constructor to initialize to generic array
        {
            this.arrName = arrName;
        }

        public T[] sortMethod(T[] values)  //user define generic method by using Array.Sort() method
        {
            Array.Sort(values);  //here Array.Sort() method
            return values;
        }
        public T MaxValue(params T[] ar) // geting the element of generic array
        {
            var sortValue = sortMethod(ar);
            return sortValue[^1];  // find out the max possition value
        }

        public T MaxMethod() //max value assgined to the generic array
        {
            var max = MaxValue(this.arrName);
            return max;  //returned the max value
        }

        public void PrintMaxValue()   //Print the maximum value
        {
            var max = MaxValue(this.arrName);
            Console.WriteLine("\n Maximum Values is:" + max);
        }

    }
}
