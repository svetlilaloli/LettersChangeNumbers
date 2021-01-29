using System;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int length = line.Length;
            char letterBefore;
            char letterAfter;
            decimal number;
            decimal result;
            decimal sum = 0;

            for (int i = 0; i < length; i++)
            {
                letterBefore = line[i][0];
                string digits = "";

                for (int j = 1; j < line[i].Length - 1; j++)
                {
                    if (char.IsDigit(line[i][j]))
                    {
                        digits += line[i][j];
                    }
                }
                number = decimal.Parse(digits);
                letterAfter = line[i][line[i].Length - 1];

                if (char.IsUpper(letterBefore))
                {
                    result = Convert.ToDecimal(number / Position(letterBefore));
                }
                else
                {
                    result = number * Position(letterBefore);
                }
                if (char.IsUpper(letterAfter))
                {
                    result -= Position(letterAfter);
                }
                else
                {
                    result += Position(letterAfter); 
                }

                sum += result;
            }
            Console.WriteLine($"{ sum:f2}");
        }
        private static int Position(char letter)
        {
            int position;

            if (char.IsUpper(letter))
            {
                position = letter - 64;
            }
            else
            {
                position = letter - 96;
            }
            return position;
        }
    }
}
