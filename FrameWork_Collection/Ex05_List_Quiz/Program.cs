using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_List_Quiz
{
    /*
     Emp 클래스 생성
    사번 (empno)  정수
    이름 (ename)  문자열
    직종 (job)      문자열
    급여 (sal)       정수
    생성자를 통해서 member field 초기화
    -------------------------------------------
    List<T> 사용하여 사원 3명을 만드세요

    사원의 정보를 (사원 , 이름 , 직종 , 급여)  출력하세요
    일반  for  과 foreach



     */

    class Emp {
        private int empno;
        private string ename;
        private string job;
        private int sal;

        public Emp(int empno, string ename, string job, int sal) {
            this.empno = empno;
            this.ename = ename;
            this.job = job;
            this.sal = sal;
        }

        public  override string ToString() { //리턴 
            return this.empno + "/" + this.ename;
        }
        public void showEmp() //출력 ...
        {
            Console.WriteLine($"{empno} {ename} {job} {sal}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();
            list.Add(new Emp(101, "김", "IT", 1000));
            list.Add(new Emp(102, "이", "IT", 2000));
            list.Add(new Emp(103, "박", "IT", 3000));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
