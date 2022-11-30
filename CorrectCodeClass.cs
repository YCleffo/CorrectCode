using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Событие нажатия на кнопку будет создавать объект класса и вызывать метод
        /// </summary>
        /// <param name="password">
        /// Метод выполняет  проверку правильности  заполнения текстового поля</param>
        /// <returns>
        /// Метод возвращает true
        /// </returns>
        public static bool IsCorrectCode(string candidate)
        {
            char[] codecanArray = candidate.ToCharArray();
            if(candidate.Length<10|!candidate.All(char.IsDigit)| candidate.Length > 10)
            {
                return false;
            }
            else
            {
                int sum = 0;
                for(int i=0; i< codecanArray.Length; i++)
                {
                    sum += codecanArray[i];
                }

                if (sum % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
