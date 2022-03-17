using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Event_Delegate
{

    delegate void onClick(string what); //델리게이트 타입 (void , parameter(string)) 대리

    class TestDel {
        public void MouseClick(string what) {
            Console.WriteLine("마우스의 {0} 버튼이 클릭",what);
        }

        public void KeyboardClick(string what)
        {
            Console.WriteLine("키보드  {0} 자판이 클릭", what);
        }

    }

    class Program
    {

        public event onClick myClick; //이벤트 onClick 델리게이트 형식을 [이벤트 핸들러]로 가진다
        static void Main(string[] args)
        {
            TestDel testDel = new TestDel();
            Program m = new Program();

            m.myClick += new onClick(testDel.MouseClick);
            //myClick 사건이 발생하면 ... onClick 델리게이트를 통해서 등록되 핸들러 함수를 호출하겠다
            //testDel.MouseClick 등록되는 함수는 형식이 onClick 이라는 형식과 동일
            // m.myClick -= new onClick(testDel.MouseClick);
            m.myClick += new onClick(testDel.KeyboardClick);

            m.myClick("왼쪽");

        }
    }
}
