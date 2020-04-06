using System;
using System.IO;

namespace HuffmanCompression.Writers
{
    public class ByteWriter
    {
        public void WriteToFile(string filePath, byte[] content)
        {
            FileStream stream;
            try
            {
                stream = new FileStream(filePath, FileMode.Create);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Не удалось создать файл", e);
            }

            using (stream)
            {
                for (var i = 0; i < content.Length; i++)
                {
                    byte value = 0;
                    for (byte Mask = 1; i < content.Length; Mask <<= 1, i++)
                    {
                        if (content[i] == 1)
                            value |= Mask;
                        if (Mask == 0x80)
                            break;
                    }
                    
                    stream.WriteByte(value);
                }
            }
        }
    }
}