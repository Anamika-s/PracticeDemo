using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringFunctions
    {
        public int GetStringLength(string Sentence)
        {
            return Sentence.Length;
        }
        public string JoinStrings(string str1 , string str2)
        {
            return str1 + " " + str2;
        }
    }
}
