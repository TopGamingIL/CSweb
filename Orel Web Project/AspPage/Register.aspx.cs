using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class Register : System.Web.UI.Page
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
                    message = "register success";
                }
                else
                {
                    message = "register failed";
                }
            }

        }

        private int Insert()
        {
            int success = -1;
            string fname = Request.Form["fname"].ToString();
            string password = Request.Form["password"].ToString();
            int isbarber = int.Parse(Request.Form["barber"].ToString());
            string phoneNumber= Request.Form["phone"].ToString();
            
            if(fname!=null&& password!=null)
            {//המרנו את המייל למספר טלפון כי האתר עוסק במספרה
                string sql = "INSERT INTO Userstbl(Uname,Password,Mail,BornYear) VALUES('" + fname + "','" + password + "','" + phoneNumber + "','" + isbarber+ "')";
                Helper.DoQuery(fileName, sql);   
                success = 1;
            }
            return success;
        }
    }
}
