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
            List<int> negativeNumbers = new List<int>();
  
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else if (res)
            {
                if (sum >= 0)
                {
                    return sum;
                }
                else
                {
                    throw new Exception("negatives not allowed: " + sum.ToString());
                }
            }
            else
            {
                if (numbers[0].CompareTo('/') == 0 && numbers[1].CompareTo('/') == 0)
                {
                    string[] delimeterNumber = numbers.Split('\n');
                    delimiter = delimeterNumber[0][2];
                    string[] numArray = delimeterNumber[1].Split(new char[] { ',', '\n', delimiter });
                    foreach (string num in numArray)
                    {
                        res = int.TryParse(num, out int n);
                        if (res && n >= 0)
                        {
                            sum += n;
                        }
                        else
                        {
                            negativeNumbers.Add(n);
                        }
                    }
                }
                else
                {
                    string[] numArray = numbers.Split(new char[] { ',','\n' });
                    foreach (string num in numArray)
                    {
                        res = int.TryParse(num, out int n);
                        if (res && n >= 0)
                        {
                            sum += n;
                        }
                        else
                        {
                            negativeNumbers.Add(n);
                        }
                    }            
                }
                if (negativeNumbers.Count > 0)
                {
                    string negativeString = string.Join(",", negativeNumbers);
                    throw new Exception("negatives not allowed: " + negativeString);
                }
                return sum;
            }
        }
    }
}
