using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_static
{
    /*
        static 자원
        1. 객체 생성 이전에 메모리에 올라가는 자원
        2. 객체를 생성하지 않고도 직접적인 접근 (사용) 가능한 자원
        3. 종류 : static class , static field (Point !) , static constructor , static method(Point !)
        4. static 한 단어로 : 공유자원(단 객체간)
        5. static 자원 접근(사용) 방법 ...

        class Sample{
         public static int s;

         public static void print(){
            //static method  하는데 WHY 만들어서 사용 
            //얻는 이점 
            // new 하지 않고도 사용할 수 있는 함수

            //[자주 사용]하는 함수니까 ....[ 편하게 사용 ] 
         }
         
         static 자원은 성능 향상에 도움이 [된다] ,[아니다] 질문 
         static 소멸시점 App종료될때 ....



        }
        

    */
    public class Sample {
        public static int s; //static variable
        public int i; //instance variable ( new Sample() 하면  heap  생성되고 사용 가능

        public void print() {
            int l=100; //local variable (함수 호출되면 생성 되고 함수가 끝나면 같이 죽어요)
        }
        public void printstatic() {
            Console.WriteLine("static s : {0}",s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample.s = 100;//static  자원은 클래스 이름으로 접근

            //원칙적으로 클래스는 반드시 new  통해서 메모리에 road 하고 사용
            //Sample sample = new Sample(); ...
            Sample sa = new Sample();
            sa.printstatic();
            Sample sa1 = new Sample();
            sa1.printstatic();
            Sample sa2 = new Sample();
            sa2.printstatic();

            //Tip)
            //java 와의 차이점
            //java 는 참조변수로 static 자원에 접근 가능  : java 코드 : sa.s = 200;가능


            //c# 참조변수로 접근 불가  (누구의 것도 아니다)  :sa.s =200 불가능:클래스 이름으로 접근


        
        }
    }
}
