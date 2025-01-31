using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace Практическая_номер_2_Сулейманов
{
    internal class ProgramGeneric
    {
        string text;
        public ProgramGeneric(string text_)
        {
           text = text_;
        }
        int GetGenericElement(int numOfElement)
        {
            string[] texts = text.Split(' ');
            List<int> numbers = new List<int>();
            for (int i = 0; i < texts.Length; i++)
            {
                numbers.Add(Convert.ToInt32(texts[i]));
            }
            return numbers[numOfElement];
        }
        int GetGenericLength()
        {
            char[] chars = { ',', ' ' };
            string[] texts = text.Split(chars);
            List<int> numbers = new List<int>();
            return texts.Length;
        }
        public string GetNewList()
        {
            string newList = string.Empty;
            for (int i = 0; i < GetGenericLength(); i++)
            {
                newList += GetGenericElement(i);
                for(int j = 0; j < i; j++)
                {
                    newList += GetGenericElement(j);
                }
            }
            return newList;
        }
    }
}
