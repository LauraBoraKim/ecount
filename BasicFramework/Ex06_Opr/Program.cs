using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
    class Program
    {
        static void Main(string[] args)
        {
            //연습  Main 함수 안에서 작업
            Console.WriteLine(100+100);  //숫자 : 산술
            Console.WriteLine("100"+"100"); //문자열 : 결합
            Console.WriteLine("100" + 100);  //결합

            int i = 10; //지역변수 항상 초기화
            int j;
            j = i++; //후치증가
            Console.WriteLine("i:{0} , j:{1}",i , j);
            //i> 11 , j> 10
            j = ++i; //전치증가
            Console.WriteLine("i:{0} , j:{1}", i, j);
            //i> 12 , j> 12

            int k = 100;
            k++;
            ++k;
            //혼자 있으면 전치 , 후치 동일

            int sum = 0;
            int s2 = 100;
            //sum = sum + s2; // sum 이 2번 ....
            sum += s2; // 풀어서 ... sum = sum+s2

            int ysum;
            int y = 10;
            ysum = y++ + 10;
            Console.WriteLine($"y:{y} , ysum:{ysum}");

            int a = 10;
            int b = 20;
            if (a > 5 && b > 10) { //true && true
                Console.WriteLine("true");
            }

            /*
               SQL 언어
               select * from emp where sal > 1000 and job = 'IT'

               select * from emp where sal > 1000 or job = 'IT'


               0   1 조합
                       and   ,  or 
               0  0     0       0
               0  1     0       1
               1  0     0       1
               1  1     1       1  
               
              
            */


        }
    }
}
