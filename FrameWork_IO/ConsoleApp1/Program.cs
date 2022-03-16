using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!"; 
            FileStream fs = new FileStream("test.txt", FileMode.Create); 
            StreamWriter sw = new StreamWriter(fs); 
            sw.Write(value);
            sw.Write(value2); 
            sw.Write(str1); 
            sw.Close();


            using (StreamWriter sww = new StreamWriter(new FileStream("text2.txt", FileMode.Create)))
            { 
                sww.WriteLine(value); sww.WriteLine(value2); sww.WriteLine(str1); 
            
            }

    

        }
    }
}
