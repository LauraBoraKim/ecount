using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex04_Dos
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length < 2)
            {
                Console.WriteLine("사용법: 파일.exe [옵션]  [디렉토리명]");
                Console.WriteLine("[옵션] : -m 디렉토리 만들기");
                Console.WriteLine("[옵션] : -rr 하위 디렉토리와 파일까지 삭제");
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(args[1]);
            if (args[0].Trim() == "-m")
            {
                if (dir.Exists)
                {
                    Console.WriteLine("{0} 디렉토리 이미 존재합니다", args[1]);
                }
                else
                {
                    dir.Create();
                    Console.WriteLine("{0}디렉토리생성", args[1]);
                }
            }
            else if (args[0].Trim() == "-rr")
            {
                if (dir.Exists)
                {
                    dir.Delete(true); //하위 ....delete
                    Console.WriteLine("{0}삭제되었습니다", args[1]);
                }
                else
                {
                    Console.WriteLine("{0}디렉토리 존재하지 않습니다", args[1]);
                }

            }
            else
            {
                Console.WriteLine("잘못된 옵션입니다");
                return;
            }

        }
    }
}
