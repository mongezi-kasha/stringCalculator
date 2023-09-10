using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalc
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            var delm = new List<char> { ',', '\n' };
            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');
                var custdel = splitInput.First().Trim('/');
                numberString = String.Join('\n', splitInput.Skip(1));
                delm.Add(Convert.ToChar(custdel));
            }


            var result = numberString.Split(delm.ToArray())
                .Select(x => int.Parse(x));


            var negetives = result.Where(n => n < 0);

            if (negetives.Any())
            {
                string negetiveString = String.Join(',',negetives.Select(n => n.ToString()));
                throw new Exception($"Negetives not allowed: {negetiveString}");


            }

            var somethign = result
                .Sum();
            return somethign;

        }
    }
}
