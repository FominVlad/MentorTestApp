using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MentorApp
{
    class FileAdmin
    {
        /// <summary>
        /// Метод для получения строк из файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Список строк в файле.</returns>
        public List<string> GetFileLines(string path)
        {
            List<string> fileContent = new List<string>();
            string tmpLine;

            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default))
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
