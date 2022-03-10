using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_abstract_class
{
    /*
        1.추상 클래스 (미완성 클래스)
        1.1 미완성 (완성 + 미완성) >> 함수를 구현 > {  } .... 함수를 구현하지 않으면 > { 실행블럭(x) }...

        2.목적 : 상속관계 : [강제구현] 목적으로 한다 (method)

        3.특징 : 1. 스스로 객체 생성 불가 
                 2. 상속관계에서 구현
                 3. abstract method  반드시 구현 해야 한다 
                 4. abstract method (자동  virtual) 반드시 override  구현 (재정의)
                 5. abstract property {get; set;} 구현은 추상함수동일
    */

    abstract class AbstractClass {
        public void print() {
            Console.WriteLine("완성된 코드 ...");
        }

        public abstract void abMethod();   // { 실행블럭이 없어요 >> 상속관계 >> 강제적 구현 }

      
    }

    class Dummy : AbstractClass {

        public override void abMethod() {  //강제 구현 >> { 실행블럭 만들기 }
            Console.WriteLine("추상 메서드 구현");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();  
            dummy.abMethod();
            dummy.print();
        }
    }
}
