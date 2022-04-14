using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Data
using System.Data;
using System.Data.SqlClient;


namespace Ex01_ADO_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string strConn = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=kosaDB";

            //연결객체 생성
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConn;
            conn.Open(); //연결시도

            Console.WriteLine("연결상태 : {0}", conn.State);
            Console.WriteLine("연결DB : {0}", conn.Database);
            Console.WriteLine("연결서버버전 : {0}", conn.ServerVersion);

            //명령객체 생성
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select empno , ename, job , sal from emp";
            comm.CommandType = CommandType.Text; //생략 가능
           //comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;

            //명령 실행
            //comm.ExecuteNonQuery(); //DML (insert , update ,delete) >> 데이터 집합을 만들지 않는 작업
            //comm.ExecuteReader();   //select >>select empno ,(다중행 , 멀티컬럼)
            //comm.ExecuteScalar();   //select  (단일행 , 단일컬럼) >> select sum(sal) , select count(sal),
            
            //명령처리하기
            //select  ( 출력)
            //dml     (조건처리)

            SqlDataReader dr = comm.ExecuteReader(); //데이터 접근 read하는 객체 SqlDataReader

            while (dr.Read()) {
                Console.WriteLine("사번:{0} , 이름:{1} , 직종:{2} , 급여:{3}", dr["empno"], dr["ename"], dr["job"], dr["sal"]);
            }

            dr.Close();
            conn.Close();
            Console.WriteLine("연결상태 : {0}", conn.State);
            */

            string strConn = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=kosaDB";
            SqlConnection conn = null;
            SqlDataReader dr = null;
            SqlCommand comm = null;
            string sql = "select empno , ename, job , sal from emp";
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("사번:{0} , 이름:{1} , 직종:{2} , 급여:{3}", dr["empno"], dr["ename"], dr["job"], dr["sal"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {  //자원해제 보장
                dr.Close();
                conn.Close();
            }

          
        }
    }
}
/*
using(SqlConnection conn = new SqlConnection(strConn))
{
   conn.Open();
    // TSQL문장과 Connection 객체를 지정   
   SqlCommand cmd = new SqlCommand(sql, conn);
   // 데이타는 서버에서 가져오도록 실행
   SqlDataReader rdr = cmd.ExecuteReader();
} 
 */ 