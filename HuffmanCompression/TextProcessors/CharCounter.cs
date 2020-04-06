using System.Collections.Generic;

namespace HuffmanCompression.TextProcessors
{
    public static class CharCounter
    {
        public static Dictionary<char, int> GetSymbolsCount(string text)
        {
            var symbolsCount = new Dictionary<char, int>();
            foreach (var character in text)
            {
                if (symbolsCount.ContainsKey(character))
                {
                    symbolsCount[character]++;
                }
                else
                {
                    symbolsCount.Add(character, 1);
                }
            }

            return symbolsCount;
        }
    }
}