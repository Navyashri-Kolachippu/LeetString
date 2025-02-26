using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepo._5LongestPalindromeSubstring;

namespace StringRepo._5LongestPalindromeSubstring
{
    public class LongestPalSubstring
    {

        public string LongestPalindrome(string s)
        {
            string lp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                lp = longpal(s, i, i, lp);
                lp = longpal(s, i, i + 1, lp);
            }
            return lp;
        }

        private string longpal(string s, int l, int r, string lp)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                lp = lp.Length > (r - l + 1) ? lp : s.Substring(l, (r - l + 1));
                l--;
                r++;
            }
            return lp;
        }
    }
}

//LongestPalSubstring longestPal = new LongestPalSubstring();
//var s = longestPal.LongestPalindrome("ac");
//Console.WriteLine(s); 
//Time Complexity O(n2)
//Space Complexity O(1)