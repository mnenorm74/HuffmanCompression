using System;
using System.Collections;
using System.IO;

namespace HuffmanCompression.Readers
{
    public class ByteReader
    {
        public BitArray ReadFile(string filePath)
        {
            try
            {
                return new BitArray(File.ReadAllBytes(filePath));
            }
            catch (Exception e)
            {
                throw new ArgumentException("Не удалось прочитать файл", e);
            }
        }
    }
}