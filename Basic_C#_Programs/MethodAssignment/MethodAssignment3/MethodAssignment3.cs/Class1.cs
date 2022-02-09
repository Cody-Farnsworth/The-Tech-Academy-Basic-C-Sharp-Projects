using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment3.cs
{
    public class Class1
    {
        public int add(int NumberOne, String NumberTwo)
        {
            if (NumberTwo == "")
            {
                return NumberOne; 
            }
            else
            {
                int Number2 = Convert.ToInt32(NumberTwo);
                return NumberOne + Number2;
            }
        }
    }
}
