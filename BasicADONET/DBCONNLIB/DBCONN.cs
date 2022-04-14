using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCONNLIB
{
    public class DBCONN
    {
        private static string constr = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=kosaDB";
        public static string Constr
        {
            get { return constr; }
        }

        public static string getConnStrDBname(string dbname)
        {
            return @"Data Source=" + dbname + ";uid=sa;pwd=1004;database=kosaDB";
        }
    }
}
