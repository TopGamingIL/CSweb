using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class SearchPage : System.Web.UI.Page
    {
        public string msg = "";//טבלת הנתונים
        public string msg1 = "";// שגיאה הודעת 
        public string sqlSelect;//פקודה לביצוע

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["admin"].ToString() == "1")//***
            //{//***
            string fileName = General.FileName;//שם מסד נתונים
            string name =string.Empty;//לשנות
            string date=string.Empty;//לצורך זיהוי 
            if (this.IsPostBack)//הסבר נוסף יבוא
            {

                 name = Request.Form["barber"].ToString();//לשנות
                 date = Request.Form["appdate"].ToString();//לצורך זיהוי 
            }
                sqlSelect = "SELECT * FROM AppTable WHERE BarberName = '"+name+ "' AND AppDate ='"+date+"' ";
            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);
            int length = table.Rows.Count;
            if (length == 0) msg1 = " אין תורים ";
            else
            {
                GetAllApp(table, length);
                msg1 = " אנשים" + length + " נרשמו";
            }
            /*}*///***
                 //else//***
                 //{//***
                 //    msg1 = " sorry , you are not admin! ";//***
                 //}//***

        }



        private void GetAllApp(DataTable table, int length)
        {




            msg = "<table border='2'  class='tables'> <tr>";
            msg += "<td> Client Name</td>";
            msg += "<td> Hour</td>";
            //***
            //  msg += "<td> update user </td>";
            msg += "</tr>";
            // Response.Write("</tr>");
            for (int i = 0; i < length; i++)
            {
                msg += "<tr>";
                msg += "<td>" + table.Rows[i]["ClientName"].ToString() + "</td> ";
                msg += "<td>" + table.Rows[i]["AppHour"].ToString() + "</td> ";
                //***
                //    msg += "<td> <a href = 'DelMngr.aspx?pass=" + table.Rows[i]["password"] + "'>del</a></td> ";//***
                msg += "</tr>";
            }
            msg += "</table>";


        }
    }
}