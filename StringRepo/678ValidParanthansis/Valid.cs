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
       
    }
}
