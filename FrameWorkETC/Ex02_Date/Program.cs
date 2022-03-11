using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("today : {0}",today );

            Console.WriteLine(today.Year);
            Console.WriteLine(today.Month);
            Console.WriteLine(today.Day);


            DateTime nowdate = DateTime.Now;
            Console.WriteLine("Now :{0}", nowdate);
            Console.WriteLine(nowdate.Year);
            Console.WriteLine(nowdate.Month);
            Console.WriteLine(nowdate.Day);
            Console.WriteLine(nowdate.Hour);
            Console.WriteLine(nowdate.Minute);
            Console.WriteLine(nowdate.Second);


            //날짜와 시간을 문자열로 format 제어하기
            Console.WriteLine(DateTime.Now.ToString("M/d/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("M-d-yyyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
