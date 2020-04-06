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
    }
}