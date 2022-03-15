using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Ex09_generic
{
    class Person {  //DTO , VO , DOMAIN (데이터를 담을 수 있는 클래스)
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string name, string phone, string email) { 
            this.Name = name;
            this.Phone = phone; 
            this.Email = email; 
        }
        public override string ToString() { 
            return "Name : " + Name + " Phone : " + Phone + " Email : " + Email;
        }
    }

    //class List<> : IEnumerable , IEnumerator 구현했어요

    class PersonList : IEnumerable , IEnumerator{  //열거된 자원에 대해서 순차적으로 접근 데이터 read

        private ArrayList persons = new ArrayList();
        //private List<Person> persons = new List<Person>();
        private int pos = -1; //reset 값

        public void Add(Person person) {
            persons.Add(person);
        }
        public void Add(string name, string phone , string email)
        {
            persons.Add(new Person(name, phone, email));
        }
        public IEnumerator GetEnumerator() {
            //IEnumerator 상속해서 구현하고 객체의 주소를 리턴 
            return this;
        }

        //IEnumerator 구현
        public object Current { 
            get{ return persons[pos]; }  //property 구현  get 로직구현
        }  
        public bool MoveNext() {
            if (pos + 1 < persons.Count)
            {
                pos++;
                return true;
            }
            else { 
                return false;
            }        
        
        } // 구현 bool 리턴되도록 로직 구현
        public void Reset() { 
            pos = -1;
        } //실행블럭에 초기화  배열의 reset > -1
    }


    class Program
    {
        static void Main(string[] args)
        {
           //Person person = new Person(); //데이터 1건
           // List<Person> list = new List<Person>(); //데이터 여러건 
           PersonList personlist = new PersonList();
            for (int i = 0; i < 10; i++) {
                personlist.Add("Ne" + i , "Ph"+i ,"Em" + i);
            }

            //foreach (Person person in personlist)
            //foreach (var person in personlist)
            //{
                //Console.WriteLine(person.ToString());
                //public override string ToString() {재정의}
            //}

            IEnumerator ie = personlist.GetEnumerator();
            //ie >> PersonList  객체의 주소 
            Console.WriteLine(ie.MoveNext());
            while (ie.MoveNext()) {
                Console.WriteLine(ie.Current.ToString());
            }



            // Dictionary<int, string> dictionary = new Dictionary<int, string>()
            var dictionary = new Dictionary<int, string>()
            {
                {0,"value_0"},
                {1,"value_1"},
                {2,"value_2"}
            };
            //초기화

            for (int index = 0; index < dictionary.Count; index++) {
                Console.WriteLine("index:{0}-{1}",index,dictionary[index]);
            }

            foreach (var entry in dictionary) //많이 쓰이는 유형
            {
                Console.WriteLine("key:{0} , value:{1}",entry.Key , entry.Value);
                
            }

        }
    }
}
