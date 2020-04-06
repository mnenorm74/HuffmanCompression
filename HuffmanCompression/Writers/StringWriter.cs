using System;
using System.IO;

namespace HuffmanCompression.Writers
{
    public static class StringWriter
    {
        public static void WriteToFile(string filePath, string content)
        {
            FileStream stream;
            try
            {
                stream = new FileStream(filePath, FileMode.Create);
                stream.Close();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Не удалось создать файл", e);
            }
            File.WriteAllText (filePath, content);
        }
    }
}