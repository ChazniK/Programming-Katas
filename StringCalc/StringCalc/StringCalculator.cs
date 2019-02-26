using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalc
{
    public class StringCalculator
    {
        List<int> negativeNumbers = new List<int>();
        List<int> numberList = new List<int>();
        List<char> delimiterList = new List<char> { '\n', ',' };

        public int addNumbers(List<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            return sum;
        }
        public string checkCustomDelim(string numberString)
        {
            if (numberString.Substring(0, 2).CompareTo("//") == 0)
            {
                string customPart = numberString.Split('\n')[0];
                string numberPart = numberString.Split('\n')[1];
                delimiterList.Add(customPart[2]);
                return numberPart;
            }
            return numberString;

        }
        public int add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString))
            {
                return 0;
            }
            else 
            {
                string numbers = checkCustomDelim(numbersString);
                string[] numberArrays = numbers.Split(delimiterList.ToArray());

                foreach(string number in numberArrays)
                {
                    bool res = int.TryParse(number, out int num);
                    if (res)
                    {
                        if (num <= 1000 && num >= 0 )
                        {
                            numberList.Add(num);
                        }
                        else if (num < 0)
                        {
                            negativeNumbers.Add(num);
                        }
                    }
                }
                if (negativeNumbers.Count > 0)
                {
                    string negMessage = string.Join(",", negativeNumbers.ToArray());
                    throw new Exception($"negatives not allowed: " + negMessage);
          
                }
                return addNumbers(numberList);
            }     
        }
    }
}
