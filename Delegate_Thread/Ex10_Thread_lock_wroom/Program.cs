using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ex10_Thread_lock_wroom
{
    class Wroom {

        // lock문에 사용될 객체
        private object lockObject = new object();
        public void opendoor(string name) {

            //lock(this)
            lock(lockObject)
            {
                Console.WriteLine(name + "님 화장실 입장 ^^");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(name + "사용중 : " + i);
                    if (i == 10) {
                        Console.WriteLine(name + "님 끙 ~~~");
                    }
                }
                Console.WriteLine("시원하시죠 ^^!");
            }
        }
    
    }

    class User { 
        Wroom wroom;
        string who;
        public User(Wroom wroom, string who) { 
            this.who = who; 
            this.wroom = wroom;
        }
        public void run() {
            wroom.opendoor(this.who);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {

            //한강 둔치
            Wroom wroom = new Wroom();  //화장실

            //사람들
            User kim = new User(wroom, "김씨");
            User park = new User(wroom, "박씨");
            User lee = new User(wroom, "이씨");

            //배가 아파요
            //각각 Thread
            Thread kimT = new Thread(new ThreadStart(kim.run));
            Thread parkT = new Thread(new ThreadStart(park.run));
            Thread leeT = new Thread(new ThreadStart(lee.run));

            kimT.Start();
            parkT.Start();
            leeT.Start();

        }
    }
}
