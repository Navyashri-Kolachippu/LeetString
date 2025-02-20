using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepo.StringCompression443
{
    public class StringData
    {
        public int Compress(char[] chars)
        {

            int index = 0;
            for (int i = 0; i < chars.Length;)
            {
                int count = 0;
                char ch = chars[i];
                while (i < chars.Length && chars[i] == ch)
                {
                    count++;
                    i++;
                }
                if (count == 1)
                {
                    chars[index++] = ch;
                }
                else
                {
                    chars[index++] = ch;
                    string value = count.ToString();
                    for (int j = 0; j < value.Length; j++)
                    {
                        chars[index++] = value[j];
                    }
                }
            }
            Array.Resize(ref chars, index);
            return chars.Length;
        }


    }
}
