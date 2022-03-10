using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //제어문과 연산자 같이 연습


            /*
            잘 사용하지 않는다
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("i : {0}", i);
            }

            Console.WriteLine("for 끝나고 : {0}",i);
            */
         
             for (int i = 0; i < 10; i++) {
                 Console.WriteLine("i : {0}",i);
             }

            for (int i = 2; i < 10; i++) {
                for (int j = 1; j < 10; j++) {
                    if (i == j) break; //현 제어구문 탈출
                    //Console.Write("{0} * {1} = {2}\t",i,j,i*j);
                    Console.Write("*");
                }
                Console.WriteLine();//엔터
            }

            Console.WriteLine();
            
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue; //skip 해라 (아래문장을 ...)
                    Console.Write("{0} * {1} = {2}\t",i,j,i*j);
                   
                }
                Console.WriteLine();//엔터
            }

            int result;
            Console.Write("숫자값을 입력하세요:");
            result = int.Parse(Console.ReadLine()); //정수값으로 변환

            switch (result) {
                case 1: Console.WriteLine(result);
                    break;
                case 2: Console.WriteLine(result);
                    break;
                case 3: Console.WriteLine(result);
                    break;
                case 4: Console.WriteLine(result);
                    break;
                case 5: Console.WriteLine(result);
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }


            //1~100까지 합을 구하세요
            //while(조건){}
            int k = 1;
            int ksum = 0; //지역변수 사용전에 초기화 반드시(^^)
            while (k <= 100) {

                //ksum = ksum + k;
                ksum += k;
                //반드시 내부에서 증가감을 처리
                k++;
            }
            Console.WriteLine("누적합:{0} , k:{1}",ksum,k);

            //1~100까지 홀수의 합
            int y = 1;
            int ysum = 0;
            while (y <= 100) {

                if (y % 2 == 0) {
                    y++;
                    continue; //skip 아래 구문  
                }
                ysum += y;
                y++;
                
            }
            Console.WriteLine("홀수합:{0} , y:{1}", ysum, y);


            int even = 0; // (짝수)
            int odd = 0;  // (홀수)
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                { // 짝수 조건식
                    even += i; // even = even + i;
                }
                else
                { // 홀수 조건식 : i%2==1 또는 i%2!=0;
                    odd += i; // odd = odd + i;
                }
            }
            Console.WriteLine("짝수 :{0} , 홀수 :{1}",even,odd);

            //Q: 지정된 계정:admin 암호:1234 가 있다 
            //두값을 console에서 받아서 두값이 모든 일치하는 경우 "성공"출력
            //하나라도 값이 일치하지 않는 경우 "넌 누구냐 " 출력하세요(if사용)

            //Console.ReadLine()
            Console.Write("사용자 ID:");
            string id = Console.ReadLine();
            Console.Write("사용자 PWD:");
            string pwd = Console.ReadLine();

            // if(i < 10 && j < 20 && k < 100 .....
            // if(i < 10 || j < 20 || k < || .....
            if (id == "admin" && pwd == "1234")//id == "admin" 거짓이면 false
            {
                Console.WriteLine("관리자 방가");
            }
            else {
                Console.WriteLine("넌 누구냐");
            }
            /*
            if ('A' != 65) { //같지 않니
                Console.WriteLine("FALSE");
            }
            else
            {
                //어 같아
                Console.WriteLine("FALSE");
            }
            */

            //연산자  중에서 암기(Today point) : 삼항연산자
            int p2 = 10;
            int k2 = -10;

            int result2 = (p2 == k2) ? p2 : k2;

            Console.WriteLine("result2:{0}",result2);

            //if 문으로
            if (p2 == k2)
            {

            }
            else { 
            
            }

            int x1 = 3;
            int x2 = 5;

            //비트 연산
            //3 십진수 값을 이진수(0,1)
            //128 64 32 16 8 4 2 1   (2의 배수)
            //             0 0 1 1   십진수 3의 2진수
            //             0 1 0 1   십진수 5의 2진수
            //AND          0 0 0 1   3과5의 AND 연산  > 십진수 > 1     
            //OR           0 1 1 1   3과5의 OR  연산  > 십진수 > (1+2+4) > 7
            Console.WriteLine(x1&x2); //1
            Console.WriteLine(x1|x2); //7


        }
    }
}
