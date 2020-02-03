using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentorApp
{
    class DataManipulator
    {
        /// <summary>
        /// Метод получения строки с максимальным значением.
        /// </summary>
        /// <param name="data">Список строк.</param>
        /// <param name="badLines">Выходной список плохих строк.</param>
        /// <returns>Возвращает индекс строки с максимальным значением.</returns>
        public int GetMaxLine(List<string> data, out List<int> badLines)
        {
            badLines = new List<int>();
            bool isBad;
            List<int> tmpList = new List<int>();

            for(int i = 0; i < data.Count; i++)
            {
                tmpList.Add(GetStrSumm(GetStringElems(data[i]), out isBad));

                if(isBad)
                {
                    badLines.Add(i);
                }
            }

            return tmpList.IndexOf(tmpList.Max());
        }

        /// <summary>
        /// Метод для разбивания строки на элементы по разделителям.
        /// </summary>
        /// <param name="str">Входная строка.</param>
        /// <param name="delimeters">Массив разделителей.</param>
        /// <returns>Возвращает список элементов.</returns>
        private List<string> GetStringElems(string str, char[] delimeters = null)
        {
            // На случай, если захотим передать свой массив разделителей
            return str.Split(delimeters == null ? new char[] { '/', '\\', '.', ',' } : delimeters).ToList();
        }

        /// <summary>
        /// Метод для получения суммы целочисленных элементов.
        /// </summary>
        /// <param name="elements">Входящий список элементов.</param>
        /// <param name="isBad">Выходной флаг про строку с "плохим" значением.</param>
        /// <returns>Возвращает сумму элементов в списке.</returns>
        private int GetStrSumm(List<string> elements, out bool isBad)
        {
            int tmpNum, summ = 0;
            isBad = false;

            foreach (string elem in elements)
            {
                if(Int32.TryParse(elem, out tmpNum))
                {
                    summ += tmpNum;
                }
                else
                {
                    isBad = true;
                }
            }
            
            return summ;
        }
    }
}
