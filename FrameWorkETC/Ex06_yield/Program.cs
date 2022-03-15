using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_yield
{
    class Program
    {
        static IEnumerable<int> GetNumber() {


            //IEnumerable 상속하고 있는 모든 자원 return 의 대상
            //return new[] { 1, 2, 3, 4, 5};
            //return new List<int>() {1,2,3,4,5};
            yield return 10; //처음 호출 리턴 
            yield return 20;
            yield return 30;
        }

        static IEnumerable<int> GetNumber2()
        {

            Console.WriteLine("GetNumber2 호출");
            //IEnumerable 상속하고 있는 모든 자원 return 의 대상
            return new[] { 1, 2, 3, 4, 5};
            //return new List<int>() {1,2,3,4,5};

        }
        static void Main(string[] args)
        {
            foreach (var item in GetNumber2())
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetNumber())
            {
                Console.WriteLine("GetNumber:{0}",item);
            }
        }
    }
}
