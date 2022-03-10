using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_OOP_Overloading
{
    //함수 : (생성자 함수 , 일반함수)
    //생성자 overloading 가능

    class Test {
        private string name;
        private int age;

        public Test() { 
            
        } //기본 생성자 
        public Test(string name) { //오버로딩 생성자
        
        }
        public Test(string name, int age) //오버로딩 생성자
        { 

        }

        //의미 
        //오버로딩 생성자가 많으면 .. 옵션이 많다
        //자동차 영업소 방문 .... ]
        //예를) 기본형 ,  옵션 1 , 옵션 2 , 옵션 3 ... 변수의 초기화를 통해서 설정 ..



        //편하게 
        //개발자 종류별 함수를 모두 (intPrint , stringPrint)
        /*
        public void Print() {  //method  overloading
            
        }

        public void intPrint(int i) { 
        
        }

        public void stringPrint(string s) { 
        
        }
        */
        public void Print()
        {  //method  overloading

        }

        public void Print(int i)
        {

        }

        public void Print(string s)
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();
            Test test2 = new Test("기본값");
            Test test3 = new Test("기본값",100);

            test.Print(100);
            test.Print("문자");
        }
    }
}
