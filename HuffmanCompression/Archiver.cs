using System;
using System.IO;
using System.Text;
using HuffmanCompression.Readers;
using HuffmanCompression.Writers;
using StringWriter = HuffmanCompression.Writers.StringWriter;

namespace HuffmanCompression
{
    public class Archiver
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Архивировать");
            Console.WriteLine("2. Дезархивировать");
            Console.Write("Выберите пункт меню: ");
            var number = int.Parse(Console.ReadLine());
            if (number != 1 && number != 2)
            {
                Console.Clear();
                Console.WriteLine("Было введено некорректное значение. Попробуйте еще раз.");
                ShowMenu();
            }

            if (number == 1)
                Compress();
            else
                Decompress();
        }

        private void Compress()
        {
            var byteWriter = new ByteWriter();
            Console.Write("Введите путь файла для архивации: ");
            var filePath = Console.ReadLine();
            var compressedResult = GetCompressedTextAndCodes(filePath);
            var fileName = Path.GetFileNameWithoutExtension(filePath);
            byteWriter.WriteToFile(filePath.Replace(fileName, $@"{fileName}Compressed"), compressedResult.Item1);
            StringWriter.WriteToFile(filePath.Replace(fileName, $@"{fileName}Keys"), compressedResult.Item2);
            Console.WriteLine("Файлы сохранены успешно!");
        }
        
        private Tuple<byte[], string> GetCompressedTextAndCodes(string filePath)
        {
            throw new NotImplementedException();
        }
        

        private void Decompress()
        {
            throw new NotImplementedException();
        }
    }
}