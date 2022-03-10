using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
객체 지향 
class ==  설계도 == 데이터 타입

문제점)
설계도 1장이 아니라 여러장이 사용 ....

초가집 .... 99칸 기와집 (설계도 1장 이상 ...많이)

설계도를 나누는 기준 

관계 .....
여러장의 설계도 
is ~ a    :상속
has ~ a   :포함

상속 ....
부모   자식간의 관계 ...
1. 단일 상속 (계층적 상속)
2. 사용자가 만드는 모든 클래스는 기본적으로  Object  (root) 상속하고 있다
*/

namespace Ex01_OOP
{
    class GrandFather : Object
    { //구현 하지 않아도 default 상속 (단 접근자 public ....)
        public int Gmoney = 1000;
        private int Pmoney = 1000000; //누구에게도 [상속하지 않을] 거야
        protected int Tmoney = 2000; // protected 상속관계에서만 존재 ..
        //양면성 : 상속관계 > public
        //         객체관계(참수변수) > private  > Child child = new Child();
    }

    class Father : GrandFather {   //java >> Father extends GrandFather
        public int Fmoney = 500;
        public void print() {
            //Tmoney 각 
            Console.WriteLine("tmoney : {0}", Tmoney);
        }
    }

    class Child : Father {
        public int Cmoney = 100;

        //할아버지돈도 내돈 , 아버지돈도 내돈 , 내돈 내돈 ...
    }


    sealed class aaa
    {  //봉인된 ... 상속할 수 없는 클래스 ...

    }
    // class bbb : aaa
    // {  //sealed class aaa

    // }

    //다형성  :overloading  (하나의 이름으로 여러가지 기능) >> 함수 (생성자 함수 , 일반함수)
    //함수의 parameter [개수]와 [타입]을 다르게 하여 만드는 방법
    //목적   : 개발자의 편리성
    //상속과 무관 .... 상속이 없어도 잘 사용 ...
    class Test {
        public void method() {
            Console.WriteLine("일반함수");
        }

        //오버로딩 
        public void method(int i) {
            Console.WriteLine("i; {0}" ,i);
        }

        public void method(string i)
        {
            Console.WriteLine("i; {0}", i);
        }

        public void method(int i, int j) {
            Console.WriteLine("i+j {0}",i+j);
        }

        //순서가 다름을 인정( overloading)
        public void method(int i, string s) { 
        
        }

        public void method(string s, int i)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("Gmoney : {0}", child.Gmoney);
            Console.WriteLine("Fmoney : {0}", child.Fmoney);
            Console.WriteLine("Cmoney : {0}", child.Cmoney);
           // child에서  protected int Tmoney = 2000; 자원 접근 불가

            Test t = new Test();
            t.method("a");
           

    }
    }
}
