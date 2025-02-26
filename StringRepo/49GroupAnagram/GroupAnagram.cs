using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepo.GroupAnagram;

namespace StringRepo.GroupAnagram
{
    public class GroupAnagram
    {
        public string[] data = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        public IList<IList<string>> GroupAnagramValue()
        {
            Dictionary<string, List<string>> dictData = new Dictionary<string, List<string>>();

            foreach (string str in data)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (!dictData.ContainsKey(sorted))
                {
                    dictData[sorted] = new List<string>();
                }
                dictData[sorted].Add(str);
            }
            return dictData.Select(x => x.Value).ToList<IList<string>>();
        }
    }
}

//return strs
//           .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
//           .Select(g => g.ToList() as IList<string>)
//           .ToList();

//GroupAnagram groupAnagram = new GroupAnagram();
//var output = groupAnagram.GroupAnagramValue();
//foreach (var item in output)
//{
//    foreach (var item2 in item)
//    {
//        Console.Write(item2 + ",");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();
//Time Complexity O(n * m log m)
//Space Complexity O(n*m)