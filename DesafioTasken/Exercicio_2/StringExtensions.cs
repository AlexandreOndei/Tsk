using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2.StringExtensions
{
    internal static class StringExtensions
    {
        public static string Compress(this string s)
        {
            char[] chars = s.ToCharArray();
            int quantity = 1;
            string result = string.Empty;
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (i < chars.Length - 1 && c == chars[i + 1])
                    quantity++;
                else
                {
                    result += $"{c}{(quantity > 1 ? quantity : string.Empty)}";
                    quantity = 1;
                }
            }
            return result;
        }
    }
}
