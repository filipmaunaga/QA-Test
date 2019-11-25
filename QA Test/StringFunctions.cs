using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Test
{
    class StringFunctions
    {
        public static int CountWords(string tekst)
        {
            int count = 0;
            bool inWord = false;

            foreach (char t in tekst)
            {
                if (char.IsWhiteSpace(t))
                {
                    inWord = false;
                }
                else
                {
                    if (!inWord) count++;
                    inWord = true;
                }
            }
            return count;

        }
        public static int CountSpaces(string tekst)
        {
            int count = 0;
            string str1;
            for (int i = 0; i < tekst.Length; i++)
            {
                str1 = tekst.Substring(i, 1);
                if (str1 == " ")
                    count++;
            }
            return count;
        }
    }
}
