using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex06_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList   list = new ArrayList(); 
            List<string> list2 = new List<string>();    

            //Stack (FILO)
            Stack stack = new Stack();
            stack.Push("aaa");
            stack.Push("bbb");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop()); 

            Stack<int> stack2 = new Stack<int>();
            stack2.Push(1); //[0]
            stack2.Push(1); //[2]
            stack2.Push(1); //[3]
                            

            //Queue (FIFO)
           Queue queue = new Queue();    
           queue.Enqueue(100);
           queue.Enqueue(200);
           queue.Enqueue(300);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            // Console.WriteLine(queue.Dequeue());

            Queue<string> queue2 = new Queue<string>();


            Hashtable ht = new Hashtable();
            ht.Add("A", "사과는 맛있어");
            ht.Add("B", "바나나 맛있어");
            ht.Add("O", "오렌지 맛있어");

            //ht.Add("O", "오렌지 맛있어"); 
            // System.ArgumentException: 항목이 이미 추가되었습니다. 사전에 있는 키: 'O'  추가되는 키: 'O'

            Console.WriteLine(ht.ContainsKey("O"));
            ICollection ic = ht.Keys;//Keys property (get) 가 내부적으로  new list() 객체 생성하고 주소값을 리턴
            foreach (string key in ic) {
                Console.WriteLine(key);
            }

            //key , value 모두를 한번에 보고 싶어요

            foreach (DictionaryEntry item in ht)  // Hashtable ht = new Hashtable();  //DictionaryEntry : key ,value
            {
                Console.WriteLine("key:{0} , value:{1}", item.Key, item.Value);
            }
           


            Dictionary<string, string> ht2 = new Dictionary<string, string>();

            ht2.Add("A", "사과는 ");
            ht2.Add("B", "바나나 ");
            ht2.Add("O", "오렌지 ");


            foreach(KeyValuePair<string, string> item in ht2)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
            }

            //개발 var
            foreach (var item in ht2)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
            }

            ////////////////////////////////////////////////////////////
            // 게시판   댓글
            /*
                 1 , 홍길동 , 방가방가
                 2 , 김유신 , 방가

                 댓글
                 1 , 1 , 나도방가
                 2 , 1 , 정말방가
                 
                 Dictionary<1, List<>> 

            */
            //1  List<>
            //2. Dictionary<int,Book> 


            //내부적으로 데이터가 들어올때 정렬제공 (key 정렬)
            SortedList so = new SortedList();
            SortedList<int, string> so2 = new SortedList<int, string>();
            so.Add(10, "F");
            so.Add(3, "D");
            so.Add(31, "K");
            so.Add(1, "A");
            Console.WriteLine(so.GetKey(0));
            Console.WriteLine(so.IndexOfValue("D"));
            IList sollist = so.GetKeyList();
            foreach (int item in sollist)
            {
                Console.WriteLine(item);
            }
            sollist = so.GetValueList();

            foreach (string item in sollist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
/*
1. ArrayList   >> List<T>   **
2. Stack       >> Stack<T>  기본
3. Queue       >> Queue<T>  기본 
4. HashTable   >> Dictionary<T,V>  **
5. SortedList  >> SortedList<T,V>
6. linkedList 


 */ 