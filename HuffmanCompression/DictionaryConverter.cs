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
        
        public static Dictionary<string, byte[]> ConvertFromString(string content)
        {
            var dictionary = new Dictionary<string, byte[]>();
            var lines = content.Split("\n");
            foreach (var line in lines)
            {
                var parts = line.Split(":");
                if (parts.Length == 2)
                {
                    dictionary.TryAdd(parts[0], ByteExtractor.GetBytes(parts[^1]));
                }
                else
                {
                    if (parts[0].Length > 1)
                    {
                        dictionary.TryAdd(string.Empty, ByteExtractor.GetBytes(parts[^1]));
                    }
                }
            }

            return dictionary;
        }
    }
}