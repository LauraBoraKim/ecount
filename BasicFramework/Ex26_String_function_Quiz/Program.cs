using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
//주민번호 : 뒷번호 첫자리 : 1,3 남자 , 2,4 여자 라고 출력 ... 하는 문제

//main 함수    주민번호 입력받고
//앞:6자리     뒷:7자리
//입력값 : 123456-1234567 

//함수 3개를 static 
//1. 자리수 체크 (기능)함수 (14 ok)  return true , false 
//2. 뒷번호 첫번째 자리값 1~4까지의 값만 허용 기능함수  return true, false
//3. 뒷번호 첫번째 자리값을 가지고 1,3 남자 , 2,4 여자 출력 기능함수  void  출력
*/

namespace Ex26_String_function_Quiz
{
   class Program
    {
        static void juminDisplay(string ssn)
        {
            /*
            string gender= ssn.Replace("-","").Substring(6,7);
            int numgender = int.Parse(gender);
            if (numgender % 2 == 0) Console.WriteLine("여자");
            if(numgender % 2 == 1) Console.WriteLine("남자");
            */
            // CASE2 >
            string cgen = ssn.Replace("-", "").Substring(6, 7);
            // 123456-1234567 -> 1234561234567 > 123456[1]234567 추출> '1'
            switch (cgen)
            {
                case "1": // break 생략
                case "3":
                    Console.WriteLine("남자^^");
                    break;
                case "2": // break 생략
                case "4":
                    Console.WriteLine("여자^^");
                    break;
                default:
                    Console.WriteLine("^^");
                    break;
            }
        }

        static bool juminFirstNumber(string str) {
            bool numcheck = false;
            //Console.WriteLine(str.Substring(7, 1));
            int num = int.Parse(str.Substring(7, 1));
            if (num > 0 && num < 5)
            {
                numcheck = true;
            }
            return numcheck;
        }

        static bool juminCheck(string str) {
           return str.Length == 14 ? true : false;
        }

        static void Main(string[] args)
        {
            string ssn = "";
            do
            {
                Console.Write("주민번호 입력:");
                ssn = Console.ReadLine();
            } while (!juminCheck(ssn) || !juminFirstNumber(ssn));
            // 둘다 true 인경우  > false || false 탈출
            // !true || !true => false || false 탈출
            juminDisplay(ssn);

        }
    }
}
