using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex03_FileInfo_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files\Internet Explorer");
            if (dirInfo.Exists)
            {
                Console.WriteLine("전체경로:{0}", dirInfo.FullName);
                Console.WriteLine("디렉토리이름:{0}", dirInfo.Name);
                Console.WriteLine("생성일:{0}", dirInfo.CreationTime);
                Console.WriteLine("디렉토리속성:{0}", dirInfo.Attributes);
                Console.WriteLine("루트경로:{0}", dirInfo.Root);
                Console.WriteLine("부모 디렉토리:{0}", dirInfo.Parent);
            }
            else {
                Console.WriteLine("없어요 ....");
            }

            FileInfo finfo = new FileInfo(@"D:\temp\test.txt");
            if (finfo.Exists)
            {
                Console.WriteLine("폴더이름:{0}", finfo.Directory);
                Console.WriteLine("파일이름:{0}", finfo.Name);
                Console.WriteLine("확장자:{0}", finfo.Extension);
                Console.WriteLine("생성일:{0}", finfo.CreationTime);
                Console.WriteLine("파일크기:{0}byte", finfo.Length);
                Console.WriteLine("파일속성:{0}", finfo.Attributes);
            }
            else
            {
                Console.WriteLine("없어요 ....");
            }
        }
    }
}
