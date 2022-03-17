using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Multi_Delegate
{
    delegate void MulDel(string str);
    delegate string MulDel2(string str);
    delegate int MulDel3(int x , int y);

    class Test {
        public void mul_1(string str) {
            Console.WriteLine("1번 : {0}",str);
        }
        public void mul_2(string str)
        {
            Console.WriteLine("2번 : {0}", str);
        }
        public string mul_3(string str)
        {
            return "결과 : " + str;
        }

        public int mul_4(int x, int y) { 
            return x + y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            MulDel m = new MulDel(t.mul_1);
            MulDel m2 = new MulDel(t.mul_2);
            //m("출발");
            //m2("나도 출발");

            //단 조건은 형식이 같아야 한다
            MulDel m3;
            m3 = m;
            m3 += m2;

            m3("전체 출발");

            MulDel3 m4 = new MulDel3(t.mul_4);
            int result = m4(10, 20);
            Console.WriteLine(result);
        }
    }
}
