using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Ex09_Serializable
{

    [Serializable]
    class Emp {
        public int empno;
        public string ename;
        
        [NonSerialized]
        public string job = "IT";
        public Emp(int empno , string ename) {
            this.empno = empno; 
            this.ename = ename;
        }    
    
    }

    class Program { 
        static void Main(string[] args)
        {
            //직렬화 객체를 파일에 write 
            Stream stream = new FileStream("emp.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter(); //직렬화 
            Emp emp = new Emp(9000, "홍길동");

            //직렬화
            formatter.Serialize(stream, emp); //emp.txt 파일에 emp객체 직렬화해서 write
            stream.Close();

            //반드시 역직렬화 
            Stream rs = new FileStream("emp.txt", FileMode.Open);
            BinaryFormatter br =new BinaryFormatter();
            Emp empdata = (Emp)br.Deserialize(rs); //emp.txt 파일 쓰여진 자원을 다시 조립하는 것 (원본)

            Console.WriteLine("{0} , {1}", empdata.empno , empdata.ename );
            //Console.WriteLine(empdata.job);
        }
    }
}
