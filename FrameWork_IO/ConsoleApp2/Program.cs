using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\aa.txt";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("쓰기 작업");
            sw.WriteLine("정마로~~");
            sw.WriteLine("안녕");
            sw.Close();

            file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.WriteLine("[위치를 통한 출력]");
            sr.BaseStream.Seek(3, SeekOrigin.Begin);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            file.Close();
        }
    }
}
