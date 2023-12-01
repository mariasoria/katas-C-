using System;
using System.Collections.Generic;

namespace FindUppercaseKata
{
    public static class FindUppercaseKata
    {
        public static List<int> Execute(string text)
        {
            var indexes = new List<int>();
            for (var indexPosition = 0; indexPosition < text.Length; indexPosition++)
            {
                if (char.IsUpper(text[indexPosition]))
                {
                    indexes.Add(indexPosition);
                }
            }

            return indexes;
        }
    }
}