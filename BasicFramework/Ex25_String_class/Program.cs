using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_String_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "가";
            string b = "나";
            string c = a + b;
            Console.WriteLine("c : {0}", c);

            string[] strarr = new string[] {"가" , "나" , "다" , "라" , "마" };
            foreach (string to in strarr) {
                Console.WriteLine("to : {0}", to);
            }

            //주의 사항 : string  은 int , double 처럼 사용하시면 됩니다 (값타입 처럼)

            string str = "가나다라마가나";
            int loc = str.IndexOf("다");
            Console.WriteLine("loc : {0}" , loc);


            int lastloc = str.LastIndexOf("가");
            Console.WriteLine("Lastloc : {0}", lastloc);  //5

            string strinsert = str.Insert(2, "H");
            Console.WriteLine("Insert : {0}" , strinsert);

            string strremove = str.Remove(0,3);
            Console.WriteLine("Remove : {0}", strremove);

            string strreplace = str.Replace("라", "NEW");
            Console.WriteLine("replace : {0}" ,strreplace);

            string strsubstring = str.Substring(0,1); //자기자신값 
            Console.WriteLine("substring : {0}", strsubstring);

            //문제
            string super = "슈퍼맨/팬티.노랑색/우하하-우하하";
            //슈퍼맨    팬티    노랑색   우하하  우하하 각각을 추출하고 싶어요
            //함수 찿아보시고 적용하세요
            //https://docs.microsoft.com/ko-kr/dotnet/api/system.string.substring?view=net-6.0#system-string-substring(system-int32-system-int32)

            char[] ch = new char[] { '/','.','-'};
            //super.Split('/','.','-')
            string[] strarray = super.Split(ch);
            foreach (var item in strarray)
            {
                Console.WriteLine("super array : {0}", item);
            }

            int sum = 0;
            string[] numarr = { "1", "2", "3", "4", "5" };
            //문제1): 배열에 있는 문자값들의 합을 sum 변수에 담아서 출력 : 결과 15
            foreach (string s in numarr)
            {
                sum += int.Parse(s);
            }
            Console.WriteLine("sum : " + sum);


            string jumin = "123456-1234567";
            //문제2)  주민번호의 합을 구하세요_1  (string char[] 이다)

            //hint) jumin[i]  >> return char  >> 정수 >> 문자열 >> 정수


            int sum2 = 0;
            for (int i = 0; i < jumin.Length; i++)
            {
                //Console.WriteLine(jumin[i]);
                if (jumin[i].ToString() == "-") {
                      continue;
                } 
                sum2 += int.Parse(jumin[i].ToString());
            }

            Console.WriteLine("sum2 : {0}", sum2);  //49

            /*
            string s = "You win some. You lose some.";

            string[] subs = s.Split(' ');

            foreach (string sub in subs)  //var sub in subs
            {
                Console.WriteLine($"Substring: {sub}");
            }
            */


            #region  + 듣고 나서 기억에서 지우세요
            string strA = "Hello";
            Console.WriteLine(strA.GetHashCode());

            string strB = "Hello";
            Console.WriteLine(strB.GetHashCode());
            //같은 주소

            string strC = strA;
            Console.WriteLine(strC.GetHashCode());
            ////////////////////////////////////////////

            strC = "World";
            Console.WriteLine(strC.GetHashCode());

            string strD = "가";
            Console.WriteLine("가 :{0} ", strD.GetHashCode());
            strD += "나";
            Console.WriteLine("나 :{0} ", strD.GetHashCode());
            strD += "다";
            Console.WriteLine("다 :{0} ", strD.GetHashCode());
            strD += "라";
            Console.WriteLine("라 :{0} ", strD.GetHashCode());
            strD += "마";
            Console.WriteLine("마 :{0} ", strD.GetHashCode());
            Console.WriteLine("strD : {0}" ,strD);

            //why : 문자열의 누적 >> string 으로 누적작업 ..바보 ...

            StringBuilder sb = new StringBuilder();
            sb.Append("가");
            Console.WriteLine("sb : {0}", sb.GetHashCode());
            sb.Append("나");
            Console.WriteLine("sb : {0}", sb.GetHashCode());
            //문자열의 누적 (데이터 량 많은 경우) 
            Console.WriteLine("sb : {0}" , sb);

            #endregion



        }
    }
}
