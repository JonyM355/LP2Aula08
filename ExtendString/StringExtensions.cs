using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static readonly Random random;

        static StringExtensions()
        {
            random = new Random();
        }

        public static string ToRandomCase(this string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                char modChar;
                if (random.NextDouble() < 0.5)
                {
                    modChar = Char.ToLower(c);
                }
                else
                {
                    modChar = Char.ToUpper(c);
                }

                sb.Append(modChar);
            }

            return sb.ToString();
        }
    }
}