using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP_1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] keyword = {
   "Anna"
  ,"Brittany"
  ,"Cinderella"
  ,"Diana"
  ,"Eva"
  ,"Fiona"
  ,"Gunda"
  ,"Hege"
  ,"Inga"
  ,"Johanna"
  ,"Kitty"
  ,"Linda"
  ,"Nina"
  ,"Ophelia"
  ,"Petunia"
  ,"Amanda"
  ,"Raquel"
  ,"Cindy"
  ,"Doris"
  ,"Eve"
  ,"Evita"
  ,"Sunniva"
  ,"Tove"
  ,"Unni"
  ,"Violet"
  ,"Liza"
  ,"Elizabeth"
  ,"Ellen"
  ,"Wenche"
  ,"Vicky" };

            string q = Request["word"]; 
            string hint = "";

            // lookup all hints from array if $q is different from "" 
           if (q != "")
            {
                q = q.ToLower();  //ABC >> abc
                int len = q.Length; //3
                foreach (string str in keyword)
                {  //"Anna"
                   //out.print(str.substring(0, len));

                    if (str.Substring(0, len).ToLower().Equals(q))
                    {
                        if (hint == "")
                        {
                            //out.print("data : " + hint);
                            hint = str;
                        }
                        else
                        {
                            hint += "." + str;
                        }
                    }
                }
            }
           
            Response.Write(hint);
        }
    }
}