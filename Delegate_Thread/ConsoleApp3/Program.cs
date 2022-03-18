using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp3
{
    internal class Program
    {
        const string LINE = "----------------------------------------------";
        const int END_LINE = 42;
        const int DELAY_TIME = 200; //0.2초마다 한번씩 실행

        static int runA = 0; //1번말
        static int runB = 0; //2번말
        static int runC = 0; //3번말
        static int runD = 0; //4번말

        static void ClearScreen()
        {
            Thread.Sleep(DELAY_TIME); //딜레이
            Console.Clear(); //화면 지우기
        }
        static void Process(Random rnd)
        {
            int rndNum = rnd.Next(0, 4);
            int runRndNum = rnd.Next(0, 2);

            ++runA; //1번말 1칸앞으로
            ++runB; //2번말 1칸앞으로
            ++runC; //3번말 1칸앞으로
            ++runD; //4번말 1칸앞으로

            switch (rndNum)
            {
                case 0:
                    runA += runRndNum;
                    break;
                case 1:
                    runB += runRndNum;
                    break;
                case 2:
                    runC += runRndNum;
                    break;
                case 3:
                    runD += runRndNum;
                    break;
            }
        }
        static void UpdateScreen()
        {
            Console.WriteLine(LINE);
            for (int i = 0; i < runA; i++)
                Console.Write(" ");
            Console.Write("1■馬");
            for (int i = (END_LINE - 2) - runA; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for (int i = 0; i < runB; i++)
                Console.Write(" ");
            Console.Write("2■馬");
            for (int i = (END_LINE - 2) - runB; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for (int i = 0; i < runC; i++)
                Console.Write(" ");
            Console.Write("3■馬");
            for (int i = (END_LINE - 2) - runC; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for (int i = 0; i < runD; i++)
                Console.Write(" ");
            Console.Write("4■馬");
            for (int i = (END_LINE - 2) - runD; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            Console.WriteLine(LINE);
        }
        static bool CheckResult()
        {
            if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
            {
                int runNum = 0;
                string strResult = "결과:    !!{0} 선수 우승 !!";
                if (runA >= END_LINE)
                    runNum = 1;
                else if (runB >= END_LINE)
                    runNum = 2;
                else if (runC >= END_LINE)
                    runNum = 3;
                else
                    runNum = 4;

                Console.WriteLine(strResult, runNum);

                Console.Write("다시하시려면 0번 입력: ");
                if (0 == int.Parse(Console.ReadLine()))
                {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                ClearScreen();

                Process(rnd);

                UpdateScreen();

                if (CheckResult() == false)
                    break;
            }
        }

    }
}
