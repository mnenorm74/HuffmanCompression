using System;
using System.Collections.Generic;
using System.Text;
using HuffmanCompression.TextProcessors;

namespace HuffmanCompression
{
    public static class DictionaryConverter
    {
        public static string ConvertToString(Dictionary<string, byte[]> dictionary)
        {
            var text = new StringBuilder();
            foreach (var value in dictionary)
            {
                text.Append($"{value.Key}:");
                foreach (var symbol in value.Value)
                {
                    text.Append(symbol);
                }

                if (value.Value.Length > 0)
                    text.Append("\n");
            }

            return text.ToString();
        }
    }
}