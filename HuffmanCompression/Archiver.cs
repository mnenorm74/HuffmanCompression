using System;

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
            throw new NotImplementedException();
        }
        

        private void Decompress()
        {
            throw new NotImplementedException();
        }
    }
}