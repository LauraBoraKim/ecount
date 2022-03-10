using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Interface
{
    /*
    인터페이스 : 표준 , 약속 , 규칙 , 규약을 만드는 행위
    1. 소프트웨어 설계 최상위 단계
    2. 게임 >> run()  달린다 ,  move(int x, int y) 표준
    
    **초급 개발자**
    1. 인터페이스를 [다형성] 입장에서 접근 사용 (Interface 부모타입)
    2. 서로 연관성이 없는 클래스를 하나로 묶어주는 기능 (같은 부모를 가지게)
    3. C# 제공하는 수 많은 API (Collection) >>인터페이스 활용 >>사용방법 >> 다형성 
    4. ~able ... I~  수리 할 수 있는 , 날 수 있는 의미 접근
    5. 객체간 연결 고리 (객체간 소통) >> 다형성 

    문법)
    1. 인터페이스는 모든 멤버가 구현부를 가지지 않는다
    2. 인터페이스는 상속을 통한 강제 구현을 목적으로 한다
    3. 모든 접근자는 public ... 코드에서 사용할 필요가 (x)
    4. 멤버필드를 가지지 않는다
    5. 유일하게 다중상속을 지원  (여러개의 약속을 강제 구현 ... 인터페이스는 작은 단위로 설계)

    */

    interface Ia { //Irunable  Icloneable
        //default public
        void m(); //자동 public virtual
        int Count //자동 public virtual 강제로 property get구현하도록
        {
            get;
        }
    }

    interface Ib {
        void m2();
    }

    abstract class Abclass {
        public void run() { }  //완성된자원 + 
        public abstract void move(); //미완성 자원 
    }

    //java  >> class Child extends Abclass implements Ia ,Ib
    //C#    >> Child : Abclass ,Ia,Ib
    class Child : Abclass ,Ia,Ib { 
        public override void move() { //추상 클래스 추상 함수 구현
            Console.WriteLine("Abclass.move()");
        } 
        
        public int Count
        {  //Ia 추상 property  Count   //override 없이 구현
            get { return 100; }
        }

        public void m()
        {   //override 없이 구현
            Console.WriteLine("Ia.m()");
        }

        public void m2()
        {   //override 없이 구현
            Console.WriteLine("Ib.m2()");
        }
    }

    #region
    //인퍼페이스 
    //4. ~able ... I ~수리 할 수 있는 , 날 수 있는 의미 접근
    //5. 객체간 연결 고리(객체간 소통) >> 다형성

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 

    interface Irepairable { } //할 수 있는 (하나의 의미로)

    class Unit {
        public int hitpoint; //기본 에너지
        public readonly int MAXHP; //최대 에너지
        public Unit(int hp) {
            this.MAXHP = hp;            
        }   
    }

    //지상유닛
    class GroundUnit : Unit {
        public GroundUnit(int hp) : base(hp) { // Unit 생성자 호출(부모)
        
        }
    }

    class AirUnit : Unit {
        public AirUnit(int hp) : base(hp) { // Unit 생성자 호출(부모)
        
        }
    }

    class CommandCenter : Irepairable
    { 
            //수리하는 방법이 다르다
    }

    class Tank : GroundUnit , Irepairable
    {  //Irepairable >>  부모타입
        public Tank() : base(50) { 
        
        }

        public override string ToString() {
            return "Tank";
        }
    }

    class Marine : GroundUnit
    {
        public Marine() : base(50)
        {

        }

        public override string ToString()
        {
            return "Marine";
        }
    }

    class Scv : GroundUnit , Irepairable
    {
        public Scv() : base(50)
        {

        }
        public override string ToString()
        {
            return "Scv";
        }

        //수리하다
        //scv 구체화되고 특수화된 기능 
        //repair
        //repair : Tank , Scv , CommandCenter

        /*
        public void repair(Tank t) {
            if (t.hitpoint != t.MAXHP) 
            {
                t.hitpoint += 5;
            }
        }

        public void repair(Scv s)
        {
            if (s.hitpoint != s.MAXHP)
            {
                s.hitpoint += 5;
            }
        }

        public void repair(CommandCenter c)
        {

        }
        */
        /*
        1. Unit 개수가 증가하면 repair  함수의 개수도 같이 증가한다
        2. 한개의  repair 모든 수리를 하고 싶다 
        ex)  public void repair(Unit unit) {   }  //Marine repair 대상이 아닌데  ... 
             public void repair(GroundUnit unit) {} // //Marine repair 대상이 아닌데  ...
         

             Marine , Scv , Tank , commandCenter 서로 연관성이 없다 
             //서로 연관성이 없는 자원들을 .... 묶어주기 ....
             
             //수리 가능한 , 수리 할 수 있는   (~able) : interface  >> interface Irepairable { }
             
             //class CommandCenter : Irepairable
             //class Scv : GroundUnit , Irepairable
             //class Tank : GroundUnit , Irepairable
             
            


        */
        public void repair(Irepairable repairunit)  //Irepairable 부모타입 : CommandCenter,Scv,Tank
        {
            //수리하는 방법 (HP) ...
            //CommandCenter,Scv,Tank 
            //고민
            //repairunit 이 무었인지 판단 로직 다르게 ....

            //코드의 문제는  repairunit >> CommandCenter 오면

            //이문제를 해결하는 코드를 만드세요
            /*
            Unit unit = (Unit)repairunit;  //downcasting
            if (unit.hitpoint != unit.MAXHP)
            {
                unit.hitpoint += 5;
            }
           
            Console.WriteLine(unit.GetType());
            Console.WriteLine(typeof(Unit));
            Console.WriteLine(repairunit.GetType());
            Console.WriteLine(repairunit.GetType()  == typeof(Tank));
            */

            /*
            if (repairunit.GetType() == typeof(Tank) || repairunit.GetType() == typeof(Scv))
            {
                Unit unit = (Unit)repairunit;  //downcasting
                if (unit.hitpoint != unit.MAXHP)
                {
                    unit.hitpoint = unit.MAXHP;
                    Console.WriteLine("unit 를 수리 했습니다 :{0} - {1}",unit.hitpoint , unit.ToString());
                }
            }
            else {
                Console.WriteLine("CommandCenter 를 수리 했습니다");
            }
            */

            //hint) 타입비교
            // 또는 if(repairunit.GetType() == typeof(Unit))
            if (repairunit is Unit)
            {
                Unit unit = (Unit)repairunit;  //downcasting
                if (unit.hitpoint != unit.MAXHP)
                {
                    unit.hitpoint += 5;
                    Console.WriteLine("unit 를 수리 했습니다 :{0} - {1}", unit.hitpoint, unit.ToString());
                }
            }
            // 또는 else if(repairunit.GetType() == typeof(CommandCenter))
            else if (repairunit is CommandCenter)
            {
                CommandCenter cc = (CommandCenter)repairunit;
                Console.WriteLine("I'm CommandCenter");
            }
        }
    }


    //공중유닛

    //건물 



    #endregion








    class Program
    {
        static void Main(string[] args)
        {
            /*
            Child child = new Child();
            child.m();
            child.m2();
            child.move();
            Console.WriteLine(child.Count);
            */

            Tank tank = new Tank();
            Scv scv = new Scv();
            CommandCenter commandcenter = new CommandCenter();
            tank.hitpoint = 5;
            scv.hitpoint = 0;
            scv.repair(tank);
            scv.repair(scv);
            scv.repair(commandcenter);
        }
    }
}
