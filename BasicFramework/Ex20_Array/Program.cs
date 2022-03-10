using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열은 객체다 
            //1. new 통해서 생성
            //2. heap 메모리에 생성
            //3. 고정배열(정적배열) : 배열의 크기가 한번 설정되면 변경 불가 
            //4. 자료구조의 기본 


            //값 배열 
            int[] arr = new int[5]; //방의 값은 default 값으로 초기화
            Console.WriteLine(arr[0]);
            int[] arr2 = new int[5] {10,20,30,40,50}; //원하는 값으로 초기화
            Console.WriteLine(arr2[0]);
            int[] arr3 = new int[] { 1,2,3,4,5}; //좋아요
            //컴파일러 너에게 .. new int[] 알아서 생성
            int[] arr4 = {100,200,300,400,500};  //좋아요
                                                 //궁합
                                                 //for 
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(arr4[i]);
            }

            Console.WriteLine(arr4.Length);
            for (int i = 0; i < arr4.Length ; i++)
            {
                Console.WriteLine(arr4[i]);
            }

            Console.WriteLine("foreach");
            foreach (int item in arr4) //나열된 자원에 접근 순차적으로 데이터 추출 논리
            {
                Console.WriteLine("arr4 : {0}",item);
            }

            //Console.WriteLine("arr : {0}", arr);
            //배열의 할당

            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; //할당 (**주소값 할당**)
            for (int i = 0; i < ar2.Length; i++) {
                ar2[i] += i;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("ar : {0}",ar[i]);
            }

            string[] strarr = new string[] {"가","나","가나다","마" };


            int[] varray = new int[] { 12, 56, 45, 90, 56, 10 };
            Console.WriteLine("인덱스 값 : {0}", Array.IndexOf(varray,45));
            Console.WriteLine("인덱스 값 : {0}", Array.LastIndexOf(varray,56));

            Array.Sort(varray); //초급자 절대 접근 금지 .. 과제 sort 함수 쓰면 빵점
            Console.WriteLine("자동 정렬 Asc");
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varry[{0}] , {1}", i, varray[i]);
            }

            Console.WriteLine("자동 정렬 Desc >> 선행 >> sort");
            Array.Reverse(varray);
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varry[{0}] , {1}", i, varray[i]);
            }

            //초급 정렬코드 직접 구현 (swap 방식 , bubble sort)
            Console.WriteLine("Clear");
            Array.Clear(varray, 2, 3);  //[2][3][4] >> 값을 0 으로 초기화
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varry[{0}] , {1}", i, varray[i]);
            }

            int[] a = new int[] { 45, 12, 88, 97, 10 };
            int[] b = new int[5]; //방 5개 >> default 0이
            Array.Copy(a, b, 3);
            foreach (int item in b)
            {
                Console.WriteLine("b[{0}]",item);
            }

            //2차원 배열
            //행 , 열
            int[,] arr5 = new int[3,2];
            arr5[0,0] = 100;
            Console.WriteLine("arr5 : {0}",arr5[0,0]);

            int[,] arr6 = new int[3, 2] { {1,2},{3,4},{5,6} }; //2차원 배열 초기화
            //출력 
            //행을 고정 열의 바꾸어서 출력
            //무식한 방법 ....
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("arr[{0},{1}]={2}",i,j,arr6[i,j]);
                }
            }

            Console.WriteLine("행의개수 : {0}", arr6.GetLength(0)); 
            Console.WriteLine("열의개수 : {0}", arr6.GetLength(1));
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0},{1}]={2}", i, j, arr6[i, j]);
                }
            }

            //좌석배치 (영화관) , 경도 위도 , 바둑판 , .......
        }
    }
}
