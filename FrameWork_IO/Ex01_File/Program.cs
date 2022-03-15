using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex01_File
{

    /*
     입출력 (IO)
     1. stream (중간 매개체 , 통로)
     1.1 : Byte
     1.2 : 문자(2Byte)
     1.3 : 하나의 stream 한번에 하나 작업(입력, 출력 따로)

     2.C# : using System.IO;
     2.1 File
     2.2 Directory 
    */
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\test.txt";
            /*
             File.Create(path);

             if (File.Exists(path))
             {
                 Console.WriteLine("{0} 파일이 존재합니다", path);
             }
             else 
             {
                 Console.WriteLine("{0} 파일이 생성되지 않았습니다", path);
             }
            */
            File.AppendAllText(path, "추가추가 합니다");
            DateTime dt = File.GetCreationTime(path);
            Console.WriteLine(dt.ToLongTimeString());

            dt = File.GetLastAccessTime(path);
            Console.WriteLine("Last : {0}",dt.ToLongTimeString());

        }

    }
}
