using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepo._678ValidParanthansis
{
    public class Valid
    {
        public bool CheckValidString(string s)
        {
            bool flag = false;

            int max = 0, min = 0;
            if (s.Length == 1 & s[0] != '*')
            {
                return flag;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        max += 1;
                        min += 1;
                    }
                    else if (s[i] == ')')
                    {
                        max -= 1;
                        min -= 1;
                    }
                    else
                    {
                        max += 1;
                        min -= 1;
                    }
                    if (min < 0) min = 0;
                    if (max < 0) return flag;
                }

                if (min == 0)
                {
                    flag = true;
                }
                return flag;

            }

        }
        public bool IsValid(string s)
        {
            bool flag = false;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int countb1 = 0, countb2 = 0, countb3 = 0;
            foreach (char c in s)
            {
                if (c == '[' && !dict.ContainsKey('['))
                {
                    dict.Add('[', countb1++);
                }
                else if (c == '(' && !dict.ContainsKey('('))
                {
                    dict.Add('(', countb2++);
                }
                else if (c == '{' && !dict.ContainsKey('{'))
                {
                    dict.Add('{', countb3++);
                }
                else if (c == ']')
                {
                    if (countb1 != 0)
                    {
                        countb1--;
                    }
                    else if (!dict.ContainsKey('['))
                    {
                        return flag;
                    }
                }
                else if (c == ')')
                {
                    if (countb2 != 0)
                    {
                        countb2--;
                    }
                    else if (!dict.ContainsKey('('))
                    {
                        return flag;
                    }
                }
                else
                {
                    if (countb3 != 0)
                    {
                        countb3--;
                    }
                    else if (!dict.ContainsKey('('))
                    {
                        return flag;
                    }
                }
            }

            if (countb1 == 0 && countb2 == 0 && countb3 == 0) flag = true;
            return flag;

        }
    }
}
