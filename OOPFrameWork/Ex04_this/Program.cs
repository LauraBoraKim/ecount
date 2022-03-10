using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_this
{
    //this : 객체 자신을 가르키는 this (앞으로 생성될 객체의 주소를 가진다는 가정하에)
    //사용 : member field 와 parameter  구분
    //관용적으로  [ 함수  parameter ] 이름과 [ member field ] 이름 동일하게 ... 가독성

    //this : 생성자를 호출하는 this

    class ThisSelf {
        private string name;
        private int age;

        /*
        할당이라는 측면에서 ... 
        public ThisSelf() {
            this.name = "홍길동";   1개
            this.age = 0;
        }

        public ThisSelf(string name){ //name 사용하면 ..member field name  할당 될거야
            this.name  = name;     2개
            this.age = 0;
        }

        public ThisSelf(string name, int age) { 
            this.name = name;      3개  씩이나 가지고 있다
            this.age = age;
        }
        */


        
        public ThisSelf() : this("홍길동")
        {
            Console.WriteLine("매개변수가 없어요^^");
        }

        public ThisSelf(string name)  : this(name,0)
        { //name 사용하면 ..member field name  할당 될거야
            Console.WriteLine("매개변수가 하나 있어요 ^^");
        }

        public ThisSelf(string name, int age)
        {
            //member field   할당을 한번만 (반복적이 코드 줄임)
            this.name = name; 
            this.age = age;
            Console.WriteLine(" 매개 변수가 두개 : {0} - {1}",this.name , this.age );
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //ThisSelf ThisSelf = new ThisSelf();
            //원칙적으로 생성자 함수는 객체 생성시 1개만 호출
            //예외적으로  내부적으로  this() 구현한다면 여러개의 생성자 호출 가능

            //ThisSelf ThisSelf = new ThisSelf("김유신");

            ThisSelf ThisSelf = new ThisSelf("김유신",100);
        }
    }
}
