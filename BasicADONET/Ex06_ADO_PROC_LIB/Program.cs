using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDao;
namespace Ex06_ADO_PROC_LIB
{

    /*
        public SqlDataReader getEmpAllList() { return null; }  //1번
        public List<Emp> getEmpList() { return null; }  //2번 .. 
     */
    public  class Program
    {
        static void Main(string[] args)
        {
            EmpData empdata = new EmpData();

            //insert 
            int result =  empdata.insertDept(new EmpDao.Dept() {deptno=50,dname="IT",loc="SEOUL" });
            Console.WriteLine(result);

            //update
            result = empdata.updateDept(new EmpDao.Dept(){deptno=50,dname="IT TEAM" , loc = "BUSAN" });
            Console.WriteLine(result);


            //select
            List<Dept> list = empdata.getDeptList();
            foreach (Dept d in list) { 
              //d.deptno , d.name , d.loc  출력
            }  


            //select 조건 조회
            Dept dept = empdata.getDeptListByDeptno(10);
            //dept.deptno , dept.name , dept.loc  출력


            //delete
            result = empdata.deleteDept(10);
            Console.WriteLine(result);


            //순으로 구현하세요


        }
    }

}
