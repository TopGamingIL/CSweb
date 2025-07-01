using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class AddApp : System.Web.UI.Page
    {
        public string message;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                s = this.Insert();
                if (s > 0)
                {
                    message = "add app success";
                }
                else
                {
                    message = "add app failed";
                }
            }

        }

        private int Insert()
        {
            int success = -1;
            string fname = Request.Form["fname"].ToString();
            string barbername = Request.Form["barber"].ToString();
            string date = Request.Form["appdate"].ToString();
            int hour = int.Parse(Request.Form["hour"].ToString());

            if (fname != null && barbername != null)
            {//המרנו את המייל למספר טלפון כי האתר עוסק במספרה
                string sql = "INSERT INTO AppTable(ClientName,BarberName,AppDate,AppHour) VALUES('" + fname + "','" + barbername + "','" + date+ "','" + hour + "')";
                Helper.DoQuery(fileName, sql);
                success = 1;
            }
            return success;
        }
    }
}