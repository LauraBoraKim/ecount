using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Singleton
{
    class Test {
        //객체를 안 만들고 ... static
        private static Test instance;  //instance member field 주소값 없어요(메모리)

        private Test() {  //싱글톤 : 객체를 한개만 생성
        }  

        public static Test getInstance() {  //public .. 통해서 객체를 얻어 내겠다
            if (instance == null) { 
                instance = new Test();  //객체 생성
            }
            return instance;    
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            //당신이 한개의 객체만을 가지고 노는 것을 보장
            // Test test = new Test();   private Test()
            Test t =  Test.getInstance();
            Test t2 = Test.getInstance();
            Test t3 = Test.getInstance();

            Console.WriteLine(t == t2);
            Console.WriteLine(t2 == t3);
            Console.WriteLine(t.GetHashCode() + "/" + t2.GetHashCode() +"/" + t3.GetHashCode());
        }
    }
}
