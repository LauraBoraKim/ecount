using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.CarInfo();

            Car car2 = new Car("기아", "pink");
            car2.CarInfo();
            Console.WriteLine("색상만 별도로 : {0}",car2.Carcolor);

        }
    }
}
