using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanCompression
{
    public class HuffmanCompressor
    {
        public byte[] GetCompressedText(string text, Dictionary<string, byte[]> charCodes)
        {
            var modifiedText = text.Select(character => charCodes[character.ToString()]).ToList();
            var length = modifiedText.Sum(textPart => textPart.Length);
            var compressedText = new byte[length];
            var position = 0;
            foreach (var characterByte in modifiedText.SelectMany(character => character))
            {
                compressedText[position] = characterByte;
                position++;
            }

            return compressedText;
        }
        
        public string Decompress(byte[] compressedText, Dictionary<string, byte[]> charCodes)
        {
            var lengthString = charCodes.Where(x => x.Value.Length == 0).Select(x => x.Key).FirstOrDefault();
            var length = Convert.ToInt32(lengthString);
            var decompressedText = new StringBuilder();
            var maxCodeLength = charCodes.Select(code => code.Value.Length).Max();
            var text = ConvertToString(compressedText);
            var codeToSymbol = charCodes.ToDictionary(code => ConvertToString(code.Value), code => code.Key);
            var lastSubstringLength = 0;
            for (var i = 0; i < length; i += lastSubstringLength)
            {
                lastSubstringLength = 0;
                var currentLength = maxCodeLength;
                while (i + currentLength > text.Length)
                {
                    currentLength--;
                }

                while (currentLength > 0)
                {
                    var substring = text.Substring(i, currentLength);
                    if (codeToSymbol.ContainsKey(substring))
                    {
                        decompressedText.Append(codeToSymbol[substring]);
                        lastSubstringLength = currentLength;
                        currentLength = 0;
                    }

                    currentLength--;
                }
            }

            return decompressedText.ToString();
        }

        private string ConvertToString(byte[] sequence)
        {
            var text = new StringBuilder();
            foreach (var character in sequence)
            {
                if (character != 0 && character != 1)
                    throw new ArgumentException("Invalid value");
                text.Append(character == 0 ? "0" : "1");
            }

            return text.ToString();
        }
    }
}