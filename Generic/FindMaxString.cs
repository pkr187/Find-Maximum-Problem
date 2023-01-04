﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class FindMaxString
    {
        //Use maximum int number 
        public int FindMaxIntNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        //Use maximum float number
        public float FindMaxFloatNumber(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        public string FindMaxStringNumber(string firstNum, string secondNum, string thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
    }
}
    

