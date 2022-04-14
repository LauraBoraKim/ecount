using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DBCONNLIB;

namespace Ex05_ADO_PROC_DML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DML 
            using (SqlConnection conn = new SqlConnection(DBCONN.Constr))
            {
                SqlCommand cmd = new SqlCommand("usp_updateEmpList", conn);
				cmd.CommandType = CommandType.StoredProcedure;

				int empno = 7788;
				string ename ="아무개";
				int sal = 5555;

				//parameter  설정하기
				//cmd.Parameters.Add()
				cmd.Parameters.AddWithValue("@empno", empno);
				cmd.Parameters.AddWithValue("@ename", ename);
				cmd.Parameters.AddWithValue("@sal", sal);

				//return  값 처리  (return  , output)
				cmd.Parameters.Add("@return", SqlDbType.Int);
				cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
				//////////////////////////////////////////////////////////////////////

				conn.Open();
				cmd.ExecuteNonQuery();

				int result = (int)cmd.Parameters["@return"].Value;
				Console.WriteLine("result : " + result);
			}
        }
    }
}

/*
create proc usp_updateEmpList
(
	@empno int,
	@ename varchar(Max),
	@sal int
)
as
	declare @result int
	begin try
		update emp 
		set ename=@ename , sal = @sal
		where empno = @empno
		set @result = @@ROWCOUNT
	end try
	begin catch
		set @result = -1
	end catch
	return @result  
  
 */
