using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{


    delegate void onClick();
    delegate void doubleClick(int nNum);
    delegate void MultiParam(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            onClick click = () => Console.WriteLine("AAAA");  // () => 실행
            click();

            doubleClick dbclick = (v) => Console.WriteLine(v);
            dbclick(100);

            MultiParam paramadd = (v1, v2) => { int result = v1 + v2; Console.WriteLine(result); };
            paramadd(20, 40);


            MultiParam paramminus = (v1, v2) => { int result = v1 - v2; Console.WriteLine(result); };
            paramminus(10, 20);

        }
    }
}

