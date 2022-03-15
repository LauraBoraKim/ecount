using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;
namespace Ex07_Stack
{
    //
    //LIFO
    //
    class MyStack {

        object[] items; //저장 구조(타입)
        int stackpointer=0; // 정적 배열의 위치 정보를 저장 [0][1][2][3][4]
        readonly int s_size;

        public MyStack() : this(100) { 
        
        }
        public MyStack(int size) { 
            this.s_size = size; 
            this.items = new object[this.s_size]; //저장소 생성   size 가 3이면 [0][1][2]
        }

        public void Push(object item) {
            //..
            if (stackpointer >= s_size) {
                throw new InvalidOperationException("stack Full");
            }
            items[stackpointer] = item;
            stackpointer++; //이동
        }

        public object Pop() {
            stackpointer--;
            if (stackpointer >= 0)
            {
                return items[stackpointer];
            }
            else { 
                stackpointer = 0;  //포인터 초기화
                throw new InvalidOperationException("stack empty");
            }

            
        }
    }

    //제너릭 클래스 만들기 
    //GStack<string> 
    //GStack<int>
    class GStack<T>
    {

        T[] items; //저장 구조(타입)
        int stackpointer = 0; // 정적 배열의 위치 정보를 저장 [0][1][2][3][4]
        readonly int s_size;

        public GStack() : this(100)
        {

        }
        public GStack(int size)
        {
            this.s_size = size;
            this.items = new T[this.s_size]; //저장소 생성   size 가 3이면 [0][1][2]
                                             //this.items = new int[this.s_size];  
                                             //this.items = new string[this.s_size];  
        }

        public void Push(T item)
        {
            //..
            if (stackpointer >= s_size)
            {
                throw new InvalidOperationException("stack Full");
            }
            items[stackpointer] = item;
            stackpointer++; //이동
        }

        public T Pop()
        {
            stackpointer--;
            if (stackpointer >= 0)
            {
                return items[stackpointer];
            }
            else
            {
                stackpointer = 0;  //포인터 초기화
                throw new InvalidOperationException("stack empty");
            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Stack 클래스 C#  API 제공 해주는 자원
            //내부적인 구현방법 이해 ....
            Stack stack = new Stack();  //C# API
            MyStack stack2 = new MyStack(); //개발자가 직접 생산한 Stack
            // Stack 동일하게 push() , pop()



            MyStack s = new MyStack(3);
            s.Push(20);
            s.Push(30);
            s.Push(40);
           // s.Push(50);
           
            int number =  (int)s.Pop();  //[object][object][object] 
            Console.WriteLine(number);   //다운 캐스팅 ....
            int number2 = (int)s.Pop();
            Console.WriteLine(number2);
            int number3 = (int)s.Pop();
            Console.WriteLine(number3);
         
            
            GStack<int> gstack = new GStack<int>(5);
            gstack.Push(10);
            gstack.Push(20);
            gstack.Push(30);
            gstack.Push(40);

            int data = gstack.Pop();    //casting  ...
            Console.WriteLine("data : {0}",data);
        }
    }
}
