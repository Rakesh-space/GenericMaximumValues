﻿using System;

namespace GenericMaximumValues
{
    class UC1MaxIntThree
    {
        public static int maxValue(int firstValue, int secoundValue, int thirdValue)
        {
            if (firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) > 0)
            {
                return secoundValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secoundValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
