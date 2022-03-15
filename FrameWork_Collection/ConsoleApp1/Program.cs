using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();
            var list = new List<string>();
            var list2 = new List<string>();

            list.Add("a");
            list.Add("b");
            list.Add("c");

            list2.Add("A");
            list2.Add("B");
            list2.Add("C");

            dic.Add("소문자", list);
            dic.Add("대문자", list2);

            //Dictionary 출력
            foreach (var kvp in dic)
            {
                Console.WriteLine($" Key : {kvp.Key} Value : {GetOutputString(kvp)}");
            }
        }

        public static string GetOutputString(KeyValuePair<string, List<string>> kvp)
        {
            var outputString = string.Empty;
            var source = new string[] { "소문자", "대문자" };

            outputString = source.Any(data => kvp.Key.Contains(data)) == true ? $"{kvp.Value[0]} {kvp.Value[1]} {kvp.Value[2]}"
                                                                              : $"{kvp.Value[kvp.Value.Count - 1]}";

            return outputString;
        }
    }
}