using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBCONNLIB;
namespace Ex03_ADO_Scalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //사원테이블에서 사원의 평균급여를 구하고 화면에 출력하세요
            SqlConnection conn = null;
            SqlCommand comm = null;
            string sql = "select avg(sal) as avgsal from emp"; // reader >>컬럼 1 개
            try
            {
                conn = new SqlConnection(DBCONN.Constr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                int avgsal = (int)comm.ExecuteScalar();

                Console.WriteLine(avgsal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {  //자원해제 보장

                conn.Close();
            }

        }
    }
}
