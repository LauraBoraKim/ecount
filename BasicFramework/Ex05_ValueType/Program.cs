using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region +값 타입 : 구조체  : 작은 타입을 모아서 의미있는 집합 
    struct Book {
        public string name;
        public int price;

        public Book(string _name, int _price) {  //생성자 함수 //Book 이 가지는 member 를 초기화 
            name = _name;
            price = _price;
        }
    }

    struct Human {
        public string ename;
        public int age;
    }
    #endregion


    #region  +열거형  : 하나의 값타입 : 개발자 
    enum mycolor {black , white , red , green , blue };  //열거 타입 //내부적으로 상수값 0  >  ++1 자동 설정
    enum week { mon , tue = 101 , sat , sun} //명시적으로 상수값 설정 ...
    #endregion
    class Car { 
        public string name;
        public int price;
        public Car(string _name, int _price) { //생성자 함수 member 를 초기화
            name = _name;
            price = _price;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //value type
            int i = 100;
            float f = 3.14f;
            //***~~~
            //[구조체]에서 [new 는 객체를 생성하는 연산자가 아니고] 단지 [초기화(생성자)]만 한다
            Book book = new Book("홍길동전",10000);
            //Book 구조체가 값 타입임을 증명하세요
            Book book2 = book;  //만약에 book주소를 할당 했다면 ......
                                //구조체의 할당은 새로운 구조체를 하나 더 만드는 것이다 ...

            book2.name = "NEW";
            book2.price = 2000;

            Console.WriteLine("book  {0},{1}", book.name , book.price);
            Console.WriteLine("book2 {0},{1}", book2.name, book2.price);


            //---------------------------------------------------------------------

            Car car = new Car("GV80",1000);
            //new 라는 연산자는 [객체를 생성하는 연산자] (new 를 통해서 만들어진 객체는  heap  에 생성)

            Car car2 = car; //1. car2 와 car 는 같은 객체를 본다
            car2.name = "NEW_CAR";
            car2.price = 6000;

            Console.WriteLine("car  {0},{1}", car.name, car.price);
            Console.WriteLine("car2 {0},{1}", car2.name, car2.price);


            Human h;
            h.ename = "홍길동";    //초기화 하고 사용하는 것은 동일
            h.age = 100;          //초기화 하고 사용하는 것은 동일 
                                  //그럼 생성자로 초기화 하지 ^^
            Console.WriteLine(h.ename);
            Console.WriteLine(h.age);


            //열거타입
            mycolor m;
            //m 열거 타입 변수는 열거형 중에 하나를 가질 수 있다
            m = mycolor.black;
            Console.WriteLine(m);
            Console.WriteLine((int)m); //casting

            //시스템이 제공하는 열거타입 : ConsoleColor.Magenta
            Console.BackgroundColor = ConsoleColor.Magenta;

            week w;
            w = week.sat; //개발자는 문자열 형태로 코드 해석 편하게 작업 가능
            Console.WriteLine($"여기에 표현 하겠다 : {w}");


            int a = 10;
            int b = 20;

            Console.WriteLine($"string example1 : {a} + {b} = {a + b}");
            Console.WriteLine("string example1 : {0} + {1} = {2}",a,b,a+b);

            const double PI = 3.14; //상수 : 관용적 표현 : 상수의 이름 대문자 
            //PI = 3.192; 변경불가

            //형변환  (KEY POINT)
            int num = 1234;
            long lon = num; //long은 int 크기가 크다 
            //long lon = (long)num; 내부적으로 컴파일러가 수행   (암시적 형변환)

            //명시적 형변환 (개발자가 의도를 가지고 ...실제 코드로 작업)
            long lon2 = 100000; 
            int num2 = (int)lon2;  //값으로 보지 말고 가지고 있는 타입으로 보셔야 합니다
            //다행이도 형변환한 값이  int 범위라면 손실없이  값을 가질 수 있다
            Console.WriteLine(num2);


            //데이터 손실
            long lon3 = 10000000000;
            int num3 = (int)lon3;  //값으로 보지 말고 가지고 있는 타입으로 보셔야 합니다
            //다행이도 형변환한 값이  int 범위라면 손실없이  값을 가질 수 있다
            Console.WriteLine(num3); //쓰레기 값 발생 .... 손실 ....

            //결론 : 큰타입을 작은 타입으로 넣는 것은 (형변환) 손실을 가만 하여야 한다...

            int x = 254;
            byte y = (byte)x;   //byte 0 ~ 255
            Console.WriteLine("y : {0}",y);


            int x1 = 258;
            byte y1 = (byte)x1;   //byte 0 ~ 255
            Console.WriteLine("y1 : {0}", y1); //원하는 값이 아니다 .... 

            //현재는 그냥 재미로
            var name = "문자열"; //string
            Console.WriteLine(name.GetType());
            var version = 8.0; //double
            Console.WriteLine(version.GetType());
            //System.String
            //System.Double

            //참고
            int i2 = default; //타입이 가지는 기본 값을 ...
            Console.WriteLine(i2);
            double d2 = default;
            Console.WriteLine(d2);

        }
    }
}
