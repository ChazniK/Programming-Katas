using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalc
{
    public class StringCalculator
    {

        public int add(string numbers)
        {
            int sum = 0;
            bool res;
            int a;
            res = int.TryParse(numbers, out a);
  
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else if (res)
            {
                return sum + a;
            }
            else
            {
                var firstNum = Int32.Parse((numbers.Split(','))[0]);
                var secondNum = Int32.Parse((numbers.Split(','))[1]);
                sum = firstNum + secondNum;
                return sum;
            }
        }
    }
}
