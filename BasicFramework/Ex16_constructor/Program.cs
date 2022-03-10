using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_constructor
{
    /*
            생성자 함수(특수한) : member field  초기화 목적
            생성방법 : 함수의 이름 > class 이름과 동일 , 접근자 public , 리턴타입 없어요 (void) 
            종류 : default constructor (parameter (x)) , overloding constructor (parameter 개수와 타입을 달리해서)
            실행시점 : 객체 생성과 동시에 호출되는 함수 (new Test() , new Test(100,200)) > 생성자가 호출되기 전에 당근
                      member field 먼저 memory 에 있다.

    */
    class Test { 
        //1. 생성자를 구현하지 않으면 컴파일러가 자동으로 생성자 하나 만든다
        // Test(){} 자동 생성
    }

    class Test2 {
        public Test2(){  //default ..
            //어떤 자원 초기화 필요하면 ..... 
        }
    }

    class Test3 {
        public Test3() { }  //default

        public Test3(int i) { //overloading
        
        }
    }

    class Test4 {
        private int data;
        public Test4(int i) { //overloding 만 생성
            data = i;   
        }
        //overloading 생성자 하나라도 존재하면 ... default 는 반드시 구현을 통해서 사용 가능 
        //개발자 의도 : 당신 객체 생성시 반드시 parameter 1개를 가지고 생성하세요 ... 

        //Test4 t = new Test4(100);
    }

    class Test5 {
        public Test5(int i)
        { //overloding 만 생성

        }

        public Test5(int i , int j)
        { //overloding 만 생성

        }


        public Test5(int i , int j , int k)
        { //overloding 만 생성

        }

    }

    class Book {
        private string bname;
        private int price;

        // public Book() { }
        
        //사실은 [안좋은 코드 할당]을 하는 코드 3번 반복
        //개발자의 의도는 옵션 3가지
        public Book(string bname)
        {
            this.bname = bname;
            this.price = 1000;
           
        }

        public Book(int price)
        {
            this.bname = "무제";
            this.price = price;
        }
        public Book(string bname, int price) {
            this.bname = bname;
            this.price = price;
        }
    
    }



    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
        }
    }
}
