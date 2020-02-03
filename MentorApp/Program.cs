using System;
using System.Collections.Generic;

namespace MentorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileAdmin fileAdmin = new FileAdmin();
                DataManipulator dataManipulator = new DataManipulator();

                string pathToFile;

                // Берём путь к файлу с консоли, если массив "args" пустой
                if (args.Length.Equals(0))
                {
                    Printer.PrintInfo("Input path to file with data: ");

                    pathToFile = Console.ReadLine();
                }
                // Если же был передан параметр при вызове с командной строки, то:
                else
                {
                    pathToFile = args[0];
                }

                // Нахождение индекса строки (нач. с 0) максимальной суммы в строке
                List<int> badNumbers = new List<int>();
                
                int maxSummLine = dataManipulator.GetMaxLine(fileAdmin.GetFileLines(pathToFile), out badNumbers);
                
                Printer.PrintSuccess($"\nMax summ is in line {maxSummLine}.\n");

                // Вывод в консоль "плохих" строк
                string badLinesStr = "Bad lines:";

                foreach (int lineNum in badNumbers)
                {
                    badLinesStr += "\n" + lineNum;
                }

                Printer.PrintError(badLinesStr);
            }
            catch (Exception ex)
            {
                Printer.PrintError(ex.Message);
            }
        }
    }
}
