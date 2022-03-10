using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    //요구사항
    //자동차는 이름을 가지고 있다 , 자동차는 색상을 가지고 있다
    //자동차는 기본 이름과 색상을 가지고 있고 요구에따라 이름과 색상을 옵션으로 선택할 수 있다
    //자동차를 생성하고 자동차의 이름과 색상 정보를 확인 할 수 있다
    //자동차 생성 후에는 자동차의 이름과 색상을 변경 할 수 없습니다, 단 이름과 색상의 별도 조회는 가능
    public class Car
    {
        private string carname;
        private string carcolor;

        public Car() { 
            this.carname = "현대";
            this.carcolor = "blue";
        }
        public Car(string carname, string carcolor) { 
            this.carname= carname;
            this.carcolor= carcolor; 
        }
        public string Carname  //read
        {
            get { return this.carname; }
        }
        public string Carcolor
        {
            get { return this.carcolor; }
        }
        public void CarInfo() {
            Console.WriteLine("Carname : {0} , CarColor : {1}" , this.carname , this.Carcolor);
        }
    }
}
