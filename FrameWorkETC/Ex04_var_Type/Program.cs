using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_var_Type
{
    class Human {
        public string Name;
        public List<string> hobby = new List<string>();//취미가 여러가지
    }



    class Program
    {
        static void Main(string[] args)
        {

            //List<Human> Friend
            var Friend = new List<Human>
            {
                //초기화 (생성자 ... property 초기화)
                new Human {Name="이",hobby={"농구","야구","축구"}},
                new Human {Name="김",hobby={"농구","야구"}},
                new Human {Name="박",hobby={"농구"}},
            };

            Console.WriteLine(Friend[0].Name + "/" + Friend[0].hobby);
            foreach (var item in Friend[0].hobby)
            {
                Console.WriteLine("hobby : " + item);
            }

            //https://cafe.naver.com/eount/210
            //https://cafe.naver.com/eount/227


            ////////////////////////////////////////////////////////////
            var x = 10;  //int
            var y = 5;   //int
            var str = "문자열";  //string

            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>{"가","나","다" };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //익명타입 (이름 없는 클래스) >> 1회성 >> 재사용이 안되요

            //사실은
            /*
            class Member{
                private string name;
                private int age;
                
                public Member(name , age){
                   this.name =name;
                   this.age =age;
                }
            }

            var member = new Member("홍길동",100);
            var member2 = new Member("홍길동2",100);
            */

            //LINQ (데이터)
            var lee = new {name="홍길동",age=100};
            Console.WriteLine(lee.name);
            Console.WriteLine(lee.age);



        }
    }
}
