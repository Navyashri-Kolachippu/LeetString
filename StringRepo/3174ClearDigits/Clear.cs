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
                    if (data.Length != 0)
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

        public int Reverse(int x)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = false;
            string s = x.ToString();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '-')
                {
                    flag = true;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            if (sb[0] == 0)
            {
                sb.Remove(0, 1);
            }

            if (flag)
            {
                sb.Insert(0, "-");
            }

            int final;
            int.TryParse(sb.ToString(), out final);
            return final;
        }
    }
}

//Clear clear = new Clear();
//string s = "ag3";
//var a = clear.ClearDigits(s);
//Console.WriteLine(a);