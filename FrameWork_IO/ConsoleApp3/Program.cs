using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    delegate void onClick(string what);
    class TestDelegate
    {
        public void MouseClick(string what)
        {
            Console.WriteLine("마우스의 {0} 버튼이 클릭", what);
        }
        public void KeyBoardClick(string what)
        {
            Console.WriteLine("키보드의 {0} 자판이 클릭", what);
        }

    }
    class Program
    {
        public event onClick myClick;
        static void Main(string[] args)
        {
             
        TestDelegate td = new TestDelegate();
            Program m = new Program();
            m.myClick += new onClick(td.MouseClick);
            m.myClick += new onClick(td.KeyBoardClick);
            m.myClick("왼쪽");
            // this.button1.Click += new System.EventHandler(this.button1_Click);

        }
    }
}
