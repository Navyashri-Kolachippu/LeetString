using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepo.ReverseInteger
{
    public class ReverseInt
    {
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

//ReverseInt rev = new ReverseInt();
//var a = rev.Reverse(456);
//Console.WriteLine(a);
//Time Complexity O(n)
//Space Complexity O(1)

}
