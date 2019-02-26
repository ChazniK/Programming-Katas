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
            char delimiter;
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
                if (numbers[0].CompareTo('/') == 0 && numbers[1].CompareTo('/') == 0)
                {
                    string[] delimeterNumber = numbers.Split('\n');
                    delimiter = delimeterNumber[0][2];
                    string[] numArray = delimeterNumber[1].Split(',', '\n', delimiter);
                    foreach (string num in numArray)
                    {
                        res = int.TryParse(num, out int n);
                        if (res)
                        {
                            sum += n;
                        }

                    }
                }
                else
                {
                    string[] numArray = numbers.Split(',', '\n');
                    foreach (string num in numArray)
                    {
                        res = int.TryParse(num, out int n);
                        if (res)
                        {
                            sum += n;
                        }
                    }
                }
               

                return sum;
            }
        }
    }
}
