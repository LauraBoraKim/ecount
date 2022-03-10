using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_override
{
    /*
        [상속관계] 에서 override : 상속관계에서 자식이 부모의 자원을 재정의  (자원 : member field , method)
        상속관계에서 자식클래스가 부모클래스의 method(함수) 내용만 바꾼다 
        재정의 : 틀의 변화는 없고 (내용만) { 안쪽 ..수정  }  >> 함수의 이름이 타입을 바꾸는 것이 아니고요 

        1. 부모함수 이름 동일
        2. 부모함수 parameter 동일
        3. 부모함수 return type 형식 동일
        4. 결국 { 실행블럭 안에 코드만 변경 }

        new (상위자원 무시하기) , virtual (재정의 해주었으면 좋겠어 : 강한 의지) , override (재정의)


        Tip) java 는
        @override
        public void  재정의() {}
    */

    public class BaseC
    {
        public int x = 100;
        public void Invoke() {
            Console.WriteLine("부모함수");
        }
    }
    public class DerivedC : BaseC
    {
        new public int x = 111;
        new public void Invoke() {
            Console.WriteLine("자식함수");
        }
    }

    class Father
    {
        public int Fmoney = 1000;
        public void Fprint()
        {
            Console.WriteLine("Fmoney:{0}", Fmoney);
        }

        public virtual void Vprint()
        {
            //자식아 Vprint 재정의 했으면 좋겠어 (안하면 말고 ...)
            //이름은 그대로 Vprint 인데 ... [ 다른 내용일거야 그러니 바꾸어 ]...
            Console.WriteLine("부모 함수 Vprint");
        }

        

    }

    class Child : Father {
        public override void Vprint()
        {
            //base.Vprint();
            Console.WriteLine("부모의 뜻을 받들어 재정의 합니다^^");
        }

        //상속관계에서 재정의한 부모함수를 부르는 유일한 방법은
        //base 상속관계에서 this
        //base() 상속관계에서 this() 
        //Tip) 자바는 :  super
        public void FatherMethod() { 
            base.Vprint(); //상위자원으로 가서 함수 호출 
        }
    }

    //간단한 문제
    class Point2 {  //한 점을 가지는 클래스
        public int x = 4;
        public int y = 5;

        public virtual string getPosition() { 
            return this.x + ":" + this.y;
        }
    }

    class Point3D : Point2 {
        public int z = 6;

        //안 좋은 방법 (상속관계)
        //string getPosition3D() {
        //    return this.x + ":" + this.y + ":" + this.z;        
        //}

        //권장하는 방법 ..추가적인 내용에 대한 출력 ...
        public override string getPosition()
        {
            return this.x + ":" + this.y + ":" + this.z;  //base.getPosition();
        }
    }


    //Point3D p = new Point3D();
    //p.getPosition();  >> x,y 


    class Program
    {
        static void Main(string[] args)
        {
            DerivedC derivedC = new DerivedC();
            derivedC.Invoke();
            Console.WriteLine(derivedC.x);


            Child child = new Child();  
            child.Fprint();
            child.Vprint();

            //문제
            //부모가 정의한 Vprint 함수는 호출 할 수 없나요
            //부모의  Vprint() 를 ...

            //상속관계에서 부모가 heap 올라가고 따라서 자식이 heap

            //child 타입은  heap에 있는 Father, Child 객체에 접근 가능 (상속)
            //부모가 가지는 함수를 자식이 재정의 했다면 ... child 재정의 한 자원만 접근 가능
            //***************다형성 ***********************
            //부모타입은 자식타입의 주소를 가질 수 있다

            Father f = child; //자식이 가지고 있는 주소를 부모 타입의 f변수에 할당 (단 상속관계)

            //****** 부모타입으로 접근 하더라도 재정의가 되어있다면 자식쪽으로 넘겨 버린다********
            f.Vprint(); //Father 가지고 있는 .. (x)

            child.FatherMethod(); //부모함수 부르는 유일한 방법(재정의 되어 있다면)

        }
    }
}
