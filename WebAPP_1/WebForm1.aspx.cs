using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP_1
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int no = int.Parse(Request["no"]);
			string[,] arr ={ 
				             { "컴퓨터", "노트북", "테블릿" },
							 {"java" , "jquery" , "oracle"},
							 {"AA" , "BB" , "CC"}
						   };
			string str = "";
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				
				if (i < arr.GetLength(0) - 1)
				{
					str += arr[no,i] + ",";
				}
				else
				{
					str += arr[no,i];
				}
			}
			Response.Write(str);
		}
	}
}