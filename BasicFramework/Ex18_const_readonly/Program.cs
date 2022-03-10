using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_const_readonly
{
    class Test {
        //const 상수 생성시
        //1. 객체간 공유자원 > 자동 static 
        //2. 의무적 (강제) 초기화
        public const int MAXVALUE=10000;
        //readonly 상수 생성시
        //1. 반드시 초기화 할 필요없다
        //2. 생성자에서 딱 한번 값을 할당 할 수 있다 (변경 불가)
        public readonly int readdata;

        public Test(int data) { 
            readdata = data; // new 통한 생성시 객체마다 다른 상수값을 가지게 할 수 있다
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            //const
            Console.WriteLine(Test.MAXVALUE); //모든 객체의 공유자원

            Test t  = new Test(10);
            Console.WriteLine("t.readdata : {0}",t.readdata);
            Test t2 = new Test(20);
            Console.WriteLine("t2.readdata : {0}", t2.readdata);
            //t2.readdata = 100; //이미 값을 가지고 있다 ...변경 불가 ... read만 가능
        }
    }
}
