using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MentorApp
{
    public class FileAdmin
    {
        /// <summary>
        /// Метод для получения строк из файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Список строк в файле.</returns>
        public List<string> GetFileLines(string filePath)
        {
            List<string> fileContent = new List<string>();
            string tmpLine;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                while((tmpLine = reader.ReadLine()) != null)
                {
                    fileContent.Add(tmpLine);
                }
            }

            return fileContent;
        }
    }
}
