using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class BarberList : System.Web.UI.Page
    {
        public string msg = "";//טבלת הנתונים
        public string msg1 = "";// שגיאה הודעת 
        public string sqlSelect;//פקודה לביצוע

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["admin"].ToString() == "1")//***
            //{//***
            string fileName = General.FileName;//שם מסד נתונים
            string tableName = "Userstbl";//שם טבלה
            int b = 1;
            sqlSelect = "SELECT * FROM Userstbl WHERE BornYear = 1";
            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);
            int length = table.Rows.Count;
            if (length == 0) msg1 = "אין נרשמים";
            else
            {
                GetAllUsers(table, length);
                msg1 = " אנשים" + length + " נרשמו";
            }
            /*}*///***
                 //else//***
                 //{//***
                 //    msg1 = " sorry , you are not admin! ";//***
                 //}//***

        }



        private void GetAllUsers(DataTable table, int length)
        {




            msg = "<table border='2'  class='tables'> <tr>";
            msg += "<td> Barber Name</td>";
            msg += "<td> Phone Number</td>";
           //***
                                         //  msg += "<td> update user </td>";
            msg += "</tr>";
            // Response.Write("</tr>");
            for (int i = 0; i < length; i++)
            {
                msg += "<tr>";
                msg += "<td>" + table.Rows[i]["Uname"].ToString() + "</td> ";
                msg += "<td>" + table.Rows[i]["Mail"].ToString() + "</td> ";
               //***
                                                                                                            //    msg += "<td> <a href = 'DelMngr.aspx?pass=" + table.Rows[i]["password"] + "'>del</a></td> ";//***
                msg += "</tr>";
            }
            msg += "</table>";


        }
    }
}