using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_var_List
{

    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, bool> dic
            var dic = new Dictionary<int, bool>(); 
            dic.Add(1, true);
            dic.Add(2, false);
            
            var keys = new List<int>(dic.Keys);
            foreach (var item in keys)
            {
                Console.WriteLine("key:{0}",item);
            }

            var datalist = new List<string>(new string[]{"A","B","C","D","E","F"});

            var range = datalist.GetRange(1, 2);
            //List<string> range
            foreach (var item in range)
            {
                Console.WriteLine("range : {0}",item);
            }


        }
    }
}
