using System.Collections.Generic;

namespace CurrencyConverter.Const
{
    public static class Numbers
    {
        public const string Zero = "zero";

        public static IReadOnlyDictionary<int, string> BigPowerOfTenNumbers = new Dictionary<int, string>
        {
            { 2, "hundred" },
            { 3, "thousand" },
            { 6, "million" },
            { 9, "billion" }
        };

        public static string[] Units = new[]
        {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen"
        };

        public static string[] Tens = new[]
        { 
            "zero",
            "ten",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };
    }
}
