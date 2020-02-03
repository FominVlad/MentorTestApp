using System;

namespace MentorApp
{
    public static class Printer
    {
        /// <summary>
        /// Метод печати в консоль сообщения об успехе.
        /// </summary>
        /// <param name="text">Текст для вывода в консоль.</param>
        public static void PrintSuccess(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Метод печати в консоль сообщения об ошибке.
        /// </summary>
        /// <param name="text">Текст для вывода в консоль.</param>
        public static void PrintError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Метод печати в консоль информации.
        /// </summary>
        /// <param name="text">Текст для вывода в консоль.</param>
        public static void PrintInfo(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
