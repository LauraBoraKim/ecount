using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Inheritance_Composition
{
    /*
      개발환경에서 업무가 복잡하다 (도메인 지식)
      쇼핑몰
      회원관리 , 주문관리 , 상품관리 , 배송관리 ......각가의 업무 독립적인 것 보다는 ...관계를 가지고 있다
    
      여러개의 설계도는 관계를 가져야 한다

      1. 상속 (is ~ a) 은 ~ 이다 명제가 성립되면 90% 상속.... (원은 도형이다 , 강아지는 동물이다)
      2. 포함 (has ~ a) 은 ~ 을 가지고 있다  (자동차는 엔진을 가지고 있다 , 경찰은 권총을 가지고 있다)

      원 - 도형간의 관계
      원은 도형이다 
      
      원  - 점과의 관계
      원은 점이다  (X)
      원은 점을 가지고 있다 (0)
      class 원 { 점 자원을 가지고 있다 } 

      경찰  권총
      class 경찰 { 권총 자원을 가지고 있다}
     
      ex) 원 , 삼각형 , 사각형 설계도 제작 
      ex) 도형
      
      원은 도형이다
      삼각형은 도형이다
      사각형은 도형이다 
    
      도형 : 추상화 , 일반화  : 그리다 , 색상  >> 공통자원
      (원 , 삼각형, 사각형의 공통 분모)  
      원 : 구체화 ,특수화 (반지름, 한점) >> 본인만이 가지는 특징  >> 부품속성(한점은 (x,y))
     
      class Shape {색상 ,그리다}  >> 부모
      class Point {좌표값} >> 부품 >> 포함
    
      
      class Circle : Shape { Point   나머지는 특수하고 구체화 된것 구현}


     */
    class Shape { //공통속성 , 공통함수
        public string color = "gold";
        public virtual void draw() {
            Console.WriteLine("도형을 그리다");
        }
    }
    /*
    class Point {
        public int x; //public 은 아니지만 출력해볼려고 잠시 .... 원칙 : private
        public int y;

        public Point() { //기본점  //안 좋아 보여요 (할당 2번) 추후에  this() 생성자 호출 할당 1개 줄인다
            x = 1;
            y = 1;
        }
        public Point(int x, int y) {  //원하는 점
            this.x = x;
            this.y = y; 
        }
    }
    */
    class Point {
        public int x; //public 은 아니지만 출력해볼려고 잠시 .... 원칙 : private
        public int y;

        public Point():this(1,1)
        { //기본점  //안 좋아 보여요 (할당 2번) 추후에  this() 생성자 호출 할당 1개 줄인다
            
        }
        public Point(int x, int y) {  //원하는 점
            this.x = x;
            this.y = y; 
        }
    }

    //문제 
    //원을 만드세요 (원의 정의 : 원은 한점과 반지름을 가지고 있다)
    //1. 원은 도형이다 
    //2. 원은 점을 가지고 있다
    //3. 원은 반지름을 가지고 있다(특수성)
    //3.1 원의 반지름은 초기값 10을 가지고 있다
    //3.2 점의 좌표는 초기값 (10,15) 가지고 있다
    //기본 (초기값)을 설정하지 않으면 반지름과 점의 값을 입력받을 수 있다 (원이 만들어 질때)


    //Shape , Point 클래스 활용
    /*
    class Circle : Shape { //상속
        private Point point; //포함 (다른 클래스 타입을 member field 로 가지는 것) ******
        private int r; //특수화

        //문제점 : 각각의 생성자에 member field 에 할당 작업을 반복적으로 하고 있다 .... 고민.....
        //답안지 : this 

        public Circle()
        { 
            this.r = 10;
            this.point = new Point(10,15);
        }

        public Circle(int r , Point point) { 
            this.r = r;
            this.point = point; 
        }

        public void circlePrint() {
            Console.WriteLine("반지름 : {0} , 좌표값 : {1},{2}", r , point.x, point.y);
        }

    }
    */
    class Circle : Shape
    { //상속
        private Point point; //포함 (다른 클래스 타입을 member field 로 가지는 것) ******
        private int r; //특수화

        //문제점 : 각각의 생성자에 member field 에 할당 작업을 반복적으로 하고 있다 .... 고민.....
        //답안지 : this 

        public Circle() : this(10, new Point(10, 15))
        {
           //
        }

        public Circle(int r, Point point)
        {
            this.r = r;
            this.point = point;
        }

        public void circlePrint()
        {
            Console.WriteLine("반지름 : {0} , 좌표값 : {1},{2}", r, point.x, point.y);
        }

        public override void draw()
        {
            //base.draw();
            Console.WriteLine("원을 그리다");
        }

    }

    //문제2)
    //삼각형 클래스를 만드세요
    //삼각형의 정의는 [ 3개의 점 ]과 색상과 그리다는 기능을 가지고 있다
    //Shape  , Point 클래스는 제공을 받는다
    //default 값으로 삼각형을 그릴수 있고 3개의 좌표값 모두를 입력받아서 삼각형을 그릴 수 있다

    //60점
    /*
    class Triangle : Shape {
        Point x; //변형  한점
        Point y;
        Point z;

        Triangle()
        {
            x = new Point(1, 2);
            y = new Point(3, 4);
            z = new Point(5, 6);
        }

        Triangle(Point x, Point y, Point z) {
            this.x = x;
            this.y = y; 
            this.z = z; 
        }
    }
    */
    class Triangle : Shape
    {
        Point[] pointarray; //변형  한점
 
        public Triangle()
        {
           pointarray = new Point[3] {new Point(1,2), new Point(3, 4), new Point(5, 6)};
           
        }
        public Triangle(Point[] pointarray)
        {
            this.pointarray =  pointarray;  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle();
            c.draw();
            c.circlePrint();
            c.draw();

            //내가 반지름 과  좌표값을 ...
            //Point p = new Point(6,9);
            //Circle c2 = new Circle(5,p);
            // c.draw();

           
            Circle c2 = new Circle(5, new Point(6,9));
            c2.draw();
            c2.circlePrint();


            Triangle t =  new Triangle();


            Point[] pointarray = new Point[] { new Point(10, 20), new Point(30, 40), new Point(50, 60) };
            Triangle t2 = new Triangle(pointarray);

            Triangle t3 = new Triangle(new Point[] { new Point(10, 20), new Point(30, 40), new Point(50, 60) });
        }
    }
}
/*

상속의 진정한 의미 : 재사용성 (부모)
상속은 좋은 것일까 : 초기 설계 비용 많아요 , 상속 (부모 자식 관계) ... >> 현대에 >> interface 느슷한 관계


  
*/  