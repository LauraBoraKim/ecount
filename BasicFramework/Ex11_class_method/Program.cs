using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
   public  class Member {
        private string name;

        public Member() { 
        
        }
        public Member(string name) { 
            this.name = name;   
        }
    }
    //Member  클래스의 객체 생성시 default 생성자를 사용수 [있다] or  [없다]
    //Member member = new Member();  생성하지 마세요



    //설계도 : 속성 + 기능

    //기능 == 행위 == method(함수)
    //method 하나당 기능 하나 
    class Test {
        private int i; //instance variable , member field

        //행위 기능
        //method 는 누군가 이름을 부르면 실행 (method call 되면 실행)
        //4가지
        //void , parameter(x)     : public void m(){ 실행코드; } 
        //void , parameter(0)     : public void m(int i) { 실행코드; }
        //return , parameter(x)   : public int m(){ return 값; }
        //return , parameter(0)   : public int m(int i) {return i;}


        //parameter  인수 , 인자 , 매개값(변수)
        public void callMethod() {  //실행블럭
            Console.WriteLine("일반함수");
        }
        public void callMethod2(int i) {
            //개발자 마음
            if (i < 10)
            {
                Console.WriteLine("...");
            }
            else {
                Console.WriteLine("<<<<<");
            }
        }

        public string callMethod3() { // return type 함수의 결과 string  같은 타입을 전달
            return "타입만 동일";
        }

        public string callMethod4(string str) {
            return str + "방가";
        }

        //추가적으로
        public int callMethod5(int i, int j, int k) { 
            return i + j + k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //함수는 호출에 의해서 실행
            test.callMethod();
            test.callMethod2(5);

            string result = test.callMethod3();
            Console.WriteLine(result);

            result = test.callMethod4("친구야!");
            Console.WriteLine(result);

            Member member = new Member(); //생성자 함수 중에서 >  public Member()
            Member member2 = new Member("홍길동"); //생성자 함수 중에서 > public Member(string name) 
        }
    }
}
