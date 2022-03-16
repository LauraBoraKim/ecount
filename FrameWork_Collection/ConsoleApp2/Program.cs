using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\temp\test.txt";
            File.Create(path);
            bool exist = File.Exists(path);
            if (exist == true)
            {
                Console.WriteLine("{0} 존재합니다", path);
            }
            else
            {
                Console.WriteLine("{0} 생성되지 않았습니다", path);
            }
        }
    }
}
