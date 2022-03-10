using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_static_scope
{
    public class Test { //원칙 : class 내부에서 public  , private 같이 식구 ....
        private static int i;  //private  접근자 >  클래스 이름 접근 불가  > Test.i (x)
        public static int j;   //public 접근자   >  클래스 이름 접근 가능  > Test.j (0)


        //클래스가 일반자원 과 static 자원 다가지고 있는 경우 
        //일반함수에서 static member 가지고 놀 수 있다 (메모리 생성 시점이  항상 static 우선 ...)
        //static 함수에서  일반 member 가지고 놀 수 있다 (static 은 일반자원보다 항상 우선)
        //
        public static void method() {
            i = 100;
            j = 200;
            Console.WriteLine("method => i:{0} , j:{1}", i,j);
        }

        public void gMethod() {  //일반함수 >> memory 에서 >> Test t = new Test() 실행 >> memory에
            //일바함수가 static 자원을 가지고 노는 것은 당연하다. 생성시점이 늦기 때문에 .. static 보다
            i = 111;
            j = 222;
            Console.WriteLine("gMethod => i:{0} , j:{1}", i, j);
        }
    }

    // 접근
    class Test2 {
        public static int sk;  //static variable     
        public int gk;         //instance variable , member field

        public void method() {  //일반함수
            //sk static 변수 접근 (0)
            //gk 변수 접근 (0)
            sk = 100;
            gk = 200;
        }

        public static void sMethod() {  //static 함수
            //sk static 변수 접근 (0) : 같은 식구는 static 서로 접근 가능
            //gk 변수 접근 (x) : sMethod()메모리 있을때 일반자원은 없어요 
            sk++;
           //gk++; 생성이 안되어 있어요 ...
        }
    }




    class Program
    {

        private static int sint;
        private int gint;

        static void Main(string[] args)
        {
           
            Test.method();
            //gMethod() 안되요 ... memory  올려야죠 .. new
            Test t = new Test();
            t.gMethod();    //일반자원 사용

            //1. 일반함수에서는   : 일반자원 ,  static자원 접근 모두 가능하다
            //2. static함수에서는 : static 자원만 접근 가능  


            //여기서 
            // private static int sint;
            // private int gint;

            Program.sint = 100; //접근 가능
            Program  p = new Program();
            p.gint = 100;
    }
    }
}
