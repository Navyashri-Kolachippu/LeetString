using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepo.ValidAnagram
{
    public class ValidAnagram
    {
        public bool CheckValidAnagram(string s,string t)
        {
            bool result = false;
            if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return result;
            if (s.Length == t.Length)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i]))
                    {
                        dict.Add(s[i], 1);
                    }
                    else
                    {
                        dict[s[i]]++;
                    }
                }

                for (int i = 0; i < t.Length; i++)
                {
                    if (dict.ContainsKey(t[i]) && dict[t[i]] > 0)
                    {
                        dict[t[i]]--;
                    }
                    else
                    {
                        return result;
                    }
                }

                result =  !dict.Values.Any(x => x != 0);
            }
            return result;
        }
    }
}

//ValidAnagram validAnagram = new ValidAnagram();
//bool val = validAnagram.CheckValidAnagram("anagram", "nagaram");
//Console.WriteLine(val);
//Time Complexity O(n)
//Space Complexity O(1)