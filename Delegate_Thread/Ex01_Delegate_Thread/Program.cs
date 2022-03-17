using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Delegate_Thread
{
    //델리게이트 하나의 타입 ...
    //함수를 대리해서 실행 (함수를 감추어서 캡슐화)
    //조건 : 함수의 형식과 동일 
    //여러개의 동일한 형식의 함수를 대리 할 수 있다

    delegate void simple();
    delegate void simple2(int x);
    delegate void staticDel();
    delegate string simple3(string x);

    //함수를 대리해서 호출하는 형식(타입)을 생성

    class Test {
        public void fMethod() {
            Console.WriteLine("일반메서드");
        }

        public void fMethod2(int i) {
            Console.WriteLine("값 : {0}", i);
        }

        public static void sMethod()
        {
            Console.WriteLine("정적 메서드");
        }

        public string fMethod3(string s) {
            return s + " 입니다";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //t.fMethod();
            simple s = new simple(t.fMethod);
            s(); //대리해서 호출

            simple2 s2 = new simple2(t.fMethod2);
            s2(10);

            simple3 s3 = new simple3(t.fMethod3);
            string str = s3("대리");
            Console.WriteLine(str);

            //Test.sMethod()
        }
    }
}
