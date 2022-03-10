using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            if ('A' == 65)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");

            }
            if ('A' != 65)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");

            }

            /*
            java 코드 100;
            switch (data)
            {
                case 100:System.out.println("100입니다");
                case 90: System.out.println("90입니다");
                case 80: System.out.println("80입니다");
                default: System.out.println("default");
                break;
            }

            */

            int m = 3;
            string r = "";
            switch (m)
            {
                case 1:
                case 3:
                    Console.WriteLine(1);  //작업을 하니 다음 case 를 안되도 되잖아 .....
                    break;
                case 5:
                case 7:
                default:
                    r = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(r);


            string m2 = "F";
            string r2 = "";
            switch (m2)
            {   //조건식에  문자열 또는 한문자   switch('가') 도 가능
                case "A":
                case "B":
                case "C":
                case "D":
                case "E":
                case "F":
                case "G":
                    r2 = "ok";
                    break;
                case "H":
                case "K":
                    r2 = "no";
                    break;
                default:
                    r2 = "데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(r2);



            //사례 (switch case 가 break 를 가지지 않는 샘플)
            int month = 1;
            string res = ""; //빈 문자열로 초기화
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    res = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    res = "30";
                    break;
                case 2:
                    res = "29";
                    break;
                default:
                    res = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(res);


            //간단한 학점 계산기
            //학점 : A+  A-  B+  B- ..... F
            //데이터 점수 : 94점

            //판단기준1 :  90점  이상 >> A ..... 70 점 이상 C  나머지 F

            //판단기준2 ....
            //그런데 95점 이상 >> A+
            //아닌데 A-
            // 90(95 A+  아니면 A-)  .. 80 .. 70 나머지 F

            //결과 출력
            int score = 78;
            String grade = ""; // 문자열의 초기화
            Console.Write("당신의 점수는 :" + score);

            // 학점계산 로직
            if (score >= 90)
            {
                grade = "A";
                grade = (score >= 95) ? (grade += "+") : (grade += "-"); //if 삼항이 처리 가능
            }
            else if (score >= 80)
            {
                grade = "B";
                if (score >= 85)
                {
                    grade += "+";// grade = grade + "+";
                }
                else
                {
                    grade += "-";// grade = grade + "-";
                }
            }
            else if (score >= 70)
            {
                grade = "C";
                if (score >= 75)
                {
                    grade += "+";// grade = grade + "+";
                }
                else
                {
                    grade += "-";// grade = grade + "-";
                }
            }
            else
            {
                grade = "F";
            }

            Console.Write("당신의 점수는 :" + grade);

            //함수().함수().함수() chain : string 다루기

            //함수(함수(함수())) 무식한 방법

            // == 같다   c# (x)  ===  javascript(0)

            //for(;;) 무한루프
            //while(true) .... 탈출  어떤 조건이 맞으면 break ....

            //c# , javascript : foreach(항목 in 항목들)


            //foreach(항목 : 항목들) java코드
            //우연이 java 언어 == javascript 문법 90 % 같아요



        }
    }
}
