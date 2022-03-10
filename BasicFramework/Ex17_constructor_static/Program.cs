using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_constructor_static
{
    public class Test {
      //public static int staticint = 0; //  초기화하는 것보다는 
      
      //생성자를 통해서 초기화 ...  
      public static int staticint;

      static Test() { //static 생성자  >> static member field 가 메모리에 올라가고 나서 바로 자동 호출
            staticint = 100;
            //제어 로직 
        }
        public static void print() {
            Console.WriteLine("staticint value : {0}",staticint);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Test.print();
        }
    }
}
