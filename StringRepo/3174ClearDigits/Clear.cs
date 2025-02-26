using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepo._3174ClearDigits;

namespace StringRepo._3174ClearDigits
{
    public class Clear
    {
        public string ClearDigits(string s)
        {
            int count = 0;
            string final = string.Empty;
            StringBuilder data = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    count++;
                    if(data.Length > 0)
                    {
                        data.Remove(data.Length - 1, 1);
                    }
                }
                else if (char.IsLetter(s[i]))
                {
                    data.Append(s[i]);
                }
            }
            if (count == 0)
            {
                return s;
            }
            else
            {
                return final = data.ToString();
            }

        }

//        Clear clear = new Clear();
//        string s = "ag3";
//        var a = clear.ClearDigits(s);
//        Console.WriteLine(a);
//        Time Complexity O(n)
//        Space Complexity O(1)
        
    }
}

