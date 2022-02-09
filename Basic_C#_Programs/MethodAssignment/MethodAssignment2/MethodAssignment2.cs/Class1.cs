using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment2.cs
{
    public class Class1
    {
        public int add(int number)
        {
            return number + 10;
        }
        public int add(decimal number2)
        {
            return Convert.ToInt32(number2 * 6.5m);
        }
        public int add(string number3)
        {
            int number4 = Convert.ToInt32(number3);
            return number4 - 2;

        }
    }
    
}
