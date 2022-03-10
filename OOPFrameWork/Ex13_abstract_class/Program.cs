using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_abstract_class
{
    abstract class EmptyCan {
        public int count;
        public abstract int Count {  //강제 구현(property) 
            get;  //return  구현
            set;  //value parameter 사용 구현
        }

        public void speak() {
            Console.WriteLine("speak!!");
        }

        public abstract void sound();//강제 구현
        public abstract void who(); //강제 구현 
    }

    class BearCan : EmptyCan { 
    
        public override int Count  //추상 property 구현
        {
            get { 
                return this.count;
            }

            set {
                this.count = value;
            }
        }

        public override void sound() {
            Console.WriteLine("깡깡깡 ....");
        }

        public override void who() {
            Console.WriteLine("홍길동");
        }
    }


    class cyderCan : EmptyCan
    {

        public override int Count  //추상 property 구현
        {
            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }
        public override void sound()
        {
            Console.WriteLine("윙윙윙 ....");
        }
        public override void who()
        {
            Console.WriteLine("아무개");
        }

        //필요하다면 함수 더 구현  (개발자 마음)
        public void where() {
            Console.WriteLine("공원에서 ....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            BearCan bearcan = new BearCan();
            bearcan.speak();
            bearcan.sound();
            bearcan.who();

            cyderCan can = new cyderCan();
            can.speak();
            can.sound();
            can.who();
            can.where();    
        }
    }
}
