using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03_EmpLib;
namespace Ex02_Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Emp emp = new Emp();
            Console.WriteLine(emp.GetHashCode());
            emp.Empno = 7788;
            emp.Ename = "홍길동";
            emp.Sal = 1000;
            Console.WriteLine(emp.Empno);
            emp.EmpPrint();

        }
    }
}
