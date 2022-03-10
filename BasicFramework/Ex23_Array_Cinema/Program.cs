using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            CinemaMenu menu = new CinemaMenu();
            menu.startProgram();

           
            //예약 , 예약 확인 , 취소 

            string[,] seat = new string[3,5]; //3행 5열 좌석
            //java : String[][] seat = new String[3][5];

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "__";

                }
            }
            /*
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    Console.WriteLine(seat[i, j]);

                }
            }
            */
            

            //예매정보 확인
            seat[2, 1] = "홍길동";
            seat[0, 0] = "김유신";

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    //__ 빈좌석 , 나머지 예매
                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]"); 
                   
                }
                Console.WriteLine();
            }


            int row, col;
            //예매 시작
            row = 0;
            col = 0;
            //[0,0] 예매 하겠다
            if (seat[row, col] == "__")
            {
                Console.WriteLine("예약 가능한 좌석 입니다");
            }
            else {
                Console.WriteLine("이미 예약 되었습니다");
            }

            //예매 가능 하도록 좌석 초기화

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "__";  //좌석 초기화

                }
            }


            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    //__ 빈좌석 , 나머지 예매
                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]");

                }
                Console.WriteLine();
            }

          

            //예매번호
            Random rand = new Random();
            int number = rand.Next();
            Console.WriteLine(Convert.ToString(number));


            Random rand2 = new Random();
            int number2 = rand.Next(10);
            Console.WriteLine(Convert.ToString(number2));


            Random rand3 = new Random();
            int number3 = rand.Next(6, 12);
            Console.WriteLine(Convert.ToString(number3));
       
        }
    }
}
