using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //추가 자원
namespace Ex02_File_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\temp2";
            Directory.CreateDirectory(path);

            Console.WriteLine(Directory.Exists(path)); //true, false
           
            
            string defaultDir = Directory.GetCurrentDirectory();  //현재 실행되고 있는 파일
            Console.WriteLine("defaultDir:{0}", defaultDir);

            string[] dirs=  Directory.GetDirectories(@"D:\");
            Console.WriteLine("D:드라이브 폴더 목록");
            foreach (string dir in dirs) {
                Console.WriteLine("dir : {0}",dir);
            }


            //C:\windows  폴더  안에 있는 파일목록 출력하세요
            string[] files = Directory.GetFiles(@"C:\windows");
            foreach (string item in files)
            {
                //Console.WriteLine(item);
            }

            //문제 : Directory.GetFiles(@"C:\windows");  안에서 확장자가 .bmp 인 것들만 ...
            //GetFiles 오버로딩 ...
            string[] files_xml = Directory.GetFiles(@"C:\windows","*.log");
            foreach (string item in files_xml)
            {
                Console.WriteLine(item);
            }
        }
    }
}
