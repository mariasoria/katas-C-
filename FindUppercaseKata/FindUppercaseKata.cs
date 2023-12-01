using System;
using System.Collections.Generic;

namespace FindUppercaseKata
{
    public static class KataFindUppercase
    {
        public static List<int> Execute(string text)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }
    }
}