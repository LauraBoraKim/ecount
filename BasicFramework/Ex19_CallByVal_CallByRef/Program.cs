using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallByVal_CallByRef
{
    /*
    class Test {

        public void print() {
            printdata();
        }

        private int printdata() { //함수를  의미 (0) 
            //1. 클래스 내부에서 사용 가능
            //2. 다른 함수를 도와줄 목적
            //3. 공통함수 (출력)
            return 10;
        }

        public void method(Car c) { //주소
        
        }

        public void method2(int i) { //값
        
        }
    }

    class Car { 
    }
    */

    class Car {
        public int speed;
        public void run(int data) {
            speed += data;
            data = 100;
  
        }

       
    }

    class Car2
    {
        public int speed;
        public void run(ref int data)  //xx주소
        {
            speed += data;
            data = 50;
            //xx주소 값을 50
        }
    }

    class Car3
    {
        public int speed;
        public void run(out int data)  //xx주소
        {
            data = 100;
            speed += data;
            data = 50;
            //xx주소 값을 50
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();
            //t.printdata();

            Car car = new Car();
            int data2 = 20;
            car.run(data2); //data2 변수가 가지는 값을 전달
           
            Console.WriteLine(car.speed);
            Console.WriteLine("data2 :{0}",data2);
            /////////////////////////////////////////////////////////
            Car2 car2 = new Car2();
            int data3 = 20;  //xx번지 
            car2.run(ref data3); //data2 변수가 가지는 값을 전달 
   
            Console.WriteLine(car2.speed);
            Console.WriteLine("data3 :{0}", data3);

            /////////////////////////////////////////////////////////
            ///

            Car3 car3 = new Car3();
            int data4;  //xx번지 
            car3.run(out data4); //data2 변수가 가지는 값을 전달 

            Console.WriteLine(car3.speed);
            Console.WriteLine("data4 :{0}", data4);
        }
    }
}
