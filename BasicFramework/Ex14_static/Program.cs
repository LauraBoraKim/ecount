using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_static
{
    /*
    우리 회사는 비행기를 주문 제작 판매 하는 회사입니다
    우리 회사는 비행기를 생산하는 설계도를 작성 하려고 합니다
    요구사항
    1.비행기를 생산하고 비행기의 이름과 번호를 부여해야 합니다
    2.비행기가 생산되면 비행기의 이름과 번호 맞게 부여되었는 확인 하는 작업이 필요합니다 (출력정보 확인)
    3.공장장은 현재까지 만들어진 비행기의 총대수 (누적)을 확인 할 수 있습니다

    AirPlane air = new AirPlane("아시아나","707");
    AirPlane air2 = new AirPlane("아시아나","708");
    AirPlane air3 = new AirPlane("아시아나","709");
    air.출력 ..결과 ...
    air.총비행기수 ... 3개
    */
    class Airplane
    {
        public  static int totalaircount; //point (객체간 공유자원)  // Airplane.totalaircount = 10;
        private int airnum;
        private string airname;

        //public Airplane() { } //기본 생성자 함수 ...
        public Airplane(string airname , int airnum) {  //오버로딩  생성자 함수 통해서 강제로 입력 ...
            this.airname = airname;
            this.airnum = airnum;
            //누적대수
            totalaircount++; 

        }
        //기능(method)
        public void airDisplay() {
            Console.WriteLine("비행기 이름:{0} , 비행기 번호 : {1}",this.airname , this.airnum);
        }

        public void totalAirCountDisplay() {
            Console.WriteLine("비행기 총 누적 수:{0}",totalaircount);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Airplane a1 = new Airplane("대한항공",707);
            a1.airDisplay();
            a1.totalAirCountDisplay();

            Airplane a2 = new Airplane("대한항공", 708);
            a2.airDisplay();
            a2.totalAirCountDisplay();

            Airplane a3 = new Airplane("대한항공", 709);
            a3.airDisplay();
            a3.totalAirCountDisplay();

            
            //Console.WriteLine(Airplane.totalaircount);

        }
    }
}
