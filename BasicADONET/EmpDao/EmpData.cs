using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBCONNLIB;
using System.Data;
using System.Data.SqlClient;
namespace EmpDao
{
    public class EmpData
    {
        private string constr;
        public EmpData() {
            constr = DBCONN.Constr;
        }

        //연결객체(pool)

        //CRUD 함수
        //전체조회(select detpno , dname , loc from dept)
        //public SqlDataReader getEmpAllList() { return null; }  //1번
        public List<Dept> getDeptList() { return null; }  //2번


        //부분조회 (select deptno , dname ,loc from dept where deptno=@deptno) >> 오라클 where deptno=?
        public Dept getDeptListByDeptno(int deptno) { return null; }
        
        //삽입 (insert into dept(deptno, dname, loc) values(@deptno, @dname, @loc)
        public int insertDept(Dept dept) { return 0; }  
        

        //삭제 (delete from dept where deptno=@deptno)
        public int deleteDept(int deptno) { return 0; } 

        
        //수정 (update dept set dname=@dname , loc=@loc where deptno=@deptno)
        public int updateDept(Dept dept) { return 0; }  



    }

    public class Emp { 
    
    }
    public class Dept {
        public int deptno { get; set; }
        public string dname { get; set; }
        public string loc { get; set; }

    }

}
