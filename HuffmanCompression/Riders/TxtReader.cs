using System;
using System.IO;
using System.Text;

namespace HuffmanCompression.Readers
{
    public class TxtReader
    {
        public string ReadFile(string filePath, Encoding encoding)
        {
            FileStream stream;
            try
            {
                stream = new FileStream(filePath, FileMode.Open);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Не удалось прочитать файл", e);
            }
            using (var streamReader = new StreamReader(stream, encoding))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}