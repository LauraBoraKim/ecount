using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{

    class Wroom
    {
       public void openDoor(String name)
        {
            //lock (this)
            //{
                Console.WriteLine(name + "님 화장실 입장 ^^");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(name + " 사용 : " + i);
                    if (i == 10)
                    {
                        Console.WriteLine(name + "님 끙 ~~");
                    }
                }
                Console.WriteLine("시원하시죠 ^^!");
           // }

        }
    }

    class User
    {
        Wroom wr;
        String who;
        public User(String name, Wroom w)
        {
            this.who = name;
            this.wr = w;
        }
        public void run()
        {
            wr.openDoor(this.who);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //한강 둔치
            Wroom w = new Wroom();

            //사람들
            User kim = new User("김씨", w);
            User park = new User("박씨", w);
            User lee = new User("이씨", w);

            //배가 아파요
            Thread kimthread = new Thread(new ThreadStart(kim.run));
            Thread parkthread = new Thread(new ThreadStart(park.run));
            Thread leethread = new Thread(new ThreadStart(lee.run));


            kimthread.Start();
            parkthread.Start();
            leethread.Start();
        }
    }
}
