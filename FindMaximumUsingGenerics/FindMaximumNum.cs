using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenerics
{
    public class FindMaximumNum
    {
        //UC1-Given 3 integers find maximum number
        public int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)//constructor
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)//using compare method 
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("Either two or three inputs are same");
        }
        //UC2-Given 3 floats find the maximum  number
        public float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("Either two or three inputs are same");
        }

    }

}
