using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week1
{
    public static class CamelCase4
    {
        public static void CamelCase4Main()
        {

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                if (input.Contains("S;"))
                {
                    Console.WriteLine(SplitCamelCase(input));
                }
                else
                {
                    Console.WriteLine(CombineCamelCase(input));
                }
            }
        }
        public static string SplitCamelCase(string input)
        {
            try
            {
                input = input.Remove(0, 4);

                if (input.Contains("()"))
                    input = input.Replace("()", "");

                var uppercaseLetters = input.Where(x => char.IsUpper(x)).Select(x => x.ToString()).ToList();

                foreach (var uppercaseLetter in uppercaseLetters)
                {
                    if (input[0].ToString() != uppercaseLetter)
                    {
                        input = input.Replace(uppercaseLetter + "", " " + uppercaseLetter);
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return input.ToLower();
        }
        public static string CombineCamelCase(string input)
        {
            string result = "";

            try
            {
                var emptySpaceSplittedItems = input.Remove(0, 4).Split(' ');
                for (int i = 0; i < emptySpaceSplittedItems.Count(); i++)
                {
                    result += emptySpaceSplittedItems.ElementAt(i)[0].ToString().ToUpper() + emptySpaceSplittedItems.ElementAt(i).Remove(0, 1);
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            if (input.Contains("M;"))
            {
                result = result[0].ToString().ToLower() + result.Remove(0, 1) + "()";
            }
            if (input.Contains("V;"))
            {
                result = result[0].ToString().ToLower() + result.Remove(0, 1);
            }
            return result;
        }
    }
}
