using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //추가
namespace Ex04_File_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            if (args.Length < 1) {
                Console.WriteLine("사용법: 파일.exe [디렉토리 경로]");
                return;
            }

            DirectoryInfo dirinfo = new DirectoryInfo(args[0]); //C:\window
            if (dirinfo.Exists) {
                DirectoryInfo[] dirs = dirinfo.GetDirectories();
                foreach (DirectoryInfo dir in dirs) { //C:\window\temp > 파일 존재
                    
                    FileInfo[] files = dir.GetFiles();
                    Console.WriteLine("디렉토리:{0} , 파일수 :{1}" , dir.FullName , files.Length);

                    int index = 0;
                   
                    foreach (FileInfo file in files) { //test.txt or a.jpg
                        string str = string.Format("[{0}] : Name:{1} , Extention:{2} , size:{3}",++index,file.Name,file.Extension,file.Length);
                        Console.WriteLine(str);
                    }

                }
            }
        }
    }
}

/*
 간단 도스만들기  
  
         if (args.Length < 2)
            {
                Console.WriteLine("사용법: 파일.exe [옵션]  [디렉토리명]");
                Console.WriteLine("[옵션] : -m 디렉토리 만들기");
                Console.WriteLine("[옵션] : -rr 하위 디렉토리와 파일까지 삭제");
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(args[1]);
            if (args[0].Trim() == "-m"){
               디렉토리 생성....
            }

cd   디렉토리 간의 이동

dir  목록보기

type  디렉토리의 내용보기

copy  복사하기

md   디렉토리 만들기

del    파일 지우기

rd   디렉토리 지우기


>help

>mkdir /?
 
 */
