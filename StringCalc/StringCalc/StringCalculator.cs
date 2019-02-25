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
            //int a;
            res = int.TryParse(numbers, out sum);
  
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else if (res)
            {
                return sum;
            }
            else
            {
                string[] numArray = numbers.Split(',', '\n');
                foreach(string num in numArray)
                {
                    res = int.TryParse(num, out int n);
                    if (res)
                    {
                        sum += n;
                    }
                }

                return sum;
            }
        }
    }
}
