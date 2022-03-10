using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ToString_Override
{
    //1. 사용자가 모든 클래스는 기본적으로  Object 상속받는다
    //2. FrameWork 제공하는 수많은 클래스도 Object  상속받고 필요에 따라서 재정의 구현하고 있다.

    class Product
    {
        public int price;
        public int bonuspoint;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
            this.bonuspoint = (int)(this.price / 10.0);
        }
    }

    class KtTv : Product
    {
        public KtTv() : base(500)
        {

        }

        public override string ToString()
        {
            return "KtTv";
        }

    }


    class Audio : Product
    {
        public Audio() : base(100)
        {

        }

        public override string ToString()
        {
            return "Audio";
        }
    }


    class NoteBook : Product
    {
        public NoteBook() : base(150){
           
        }

        public override string ToString()
        {
            return "NoteBook";
        }
    }

	//구매자
	class Buyer
	{
		private int money = 1000;
		private int bonuspoint;

		//구매자 구매행위 (기능)
		//구매행위 (잔액 - 제품의 가격 , 포인트 정보 갱신)
		//*************구매자는 매장에 있는 모든 물건을 구매할 수 있다 ***************

		
		public void KttvBuy(KtTv n) {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
			   if(this.money < n.price) {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
				     return; //함수 종료  (구매행위 종료)
			   }
			   //실 구매 행위
			   this.money -= n.price; //잔액
			   this.bonuspoint += n.bonuspoint; //누적
                Console.WriteLine("구매한 물건은 :" +  n.ToString());
		}

        public void AudioBuy(Audio n) {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
			   if(this.money < n.price) {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
				     return; //함수 종료  (구매행위 종료)
			   }
			   //실 구매 행위
			   this.money -= n.price; //잔액
			   this.bonuspoint += n.bonuspoint; //누적
               Console.WriteLine("구매한 물건은 :" +  n.ToString());
		}

        public void NoteBookBuy(NoteBook n) {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
			   if(this.money < n.price) {
                    Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
				     return; //함수 종료  (구매행위 종료)
			   }
			   //실 구매 행위
			   this.money -= n.price; //잔액
			   this.bonuspoint += n.bonuspoint; //누적
                    Console.WriteLine("구매한 물건은 :" +  n.ToString());
		}
		
		
	}

 class Person : Object
    {

        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            //return base.ToString();
            return "Person : " + Name + "-" + Age;
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person() { Name = "Smith", Age = 12 };
        //Console.WriteLine(person.ToString());  //Ex10_ToString_Override.Person >> Object의 ToString() 그대로
        //Console.WriteLine(person);             //Ex10_ToString_Override.Person

        Console.WriteLine(person.ToString());  //Person : Smith-12  //개발자가 목적에 따른 출력(재정의)
        Console.WriteLine(person);             //Person : Smith-12


            KtTv tv = new KtTv();
            Audio audio = new Audio();
            NoteBook notebook = new NoteBook();

            Buyer buyer = new Buyer();
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);

        }
}
}
