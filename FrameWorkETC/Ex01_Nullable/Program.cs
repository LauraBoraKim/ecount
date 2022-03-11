using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Nullable
{
    /*
        System.Nullable
        //값 타입 : int, long, double  원칙적으로 >> null (x)
        //string ,  Car   >> null (0)
        //string name = null  (참조타입)
        //Car car = null      (참조타입)

        //어느날
        //DB 설계 : table column 타입 null여부 
        create table emp (
           empno int not null,
           ename nvarchar(10) null,
           age int null
        );
        insert into emp(empno, ename, age) values(7788,'홍길동',10);
        >> 7788 / 홍길동 / 10
        insert into emp(empno) values(7902);
        >> 7902 / null / null
        
        class Emp {
          int empno;
          string ename;
          int age;
        } 
        예외가 발생 ...
        개발자 요구사항
        
        >> int age = null (안되는 것인데 .. 허용해 주세요)
        >> 새로운 문법 >>  사용하면 >> null 허용(값타입)
        >> int? i = null 가능
    */
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine("null 허용 : {0}",i);
            double? j = 1.223546;
            j = null;


            int? i2 = null;
            int j2;
            //j2 = i2;  i2 가 null 가지고 있어요 안되요

            //혼재 되어 있는 경우 사용법 1
            if (i2 == null)
            {
                j2 = 0;
            }
            else {
                j2 = (int)i2; //강제로 값타입 변환
            }
            Console.WriteLine(j2);


            //혼재 되어 있는 경우 사용법 2
            // ?? 연산자
            // ?? 연산자 >>  null 이라면 오른쪽 값을 사용
            int? i3 = null;
           // i3 = 100;
            int j3 = i3 ?? -1; //null 인 경우 -1 을 가지겠다
            Console.WriteLine("j3 : {0}", j3);

            int? i4 = null;
            int? j4 = i4 + 100;
            //과연 값은 : 
            //프로그래밍 or DB 원칙적은 같은것
            //**null 과의 모든 연산은 >> null (아무것도 없다)
            Console.WriteLine("null 과의 모든 연산 : {0}", j4);


        }
    }
}
