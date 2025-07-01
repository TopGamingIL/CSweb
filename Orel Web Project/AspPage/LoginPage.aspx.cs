using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class LoginPage : System.Web.UI.Page
    {
        public string msg;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)//הסבר נוסף יבוא
            {

                string name = Request.Form["fname"].ToString();//לשנות
                string pass = Request.Form["password"].ToString();//לצורך זיהוי 

                if (name != null && pass != null)

                {
                    string loginsql = "SELECT * FROM Userstbl WHERE Uname = '" + name + "' AND Password = '" + pass + "'";
                    if (Helper.IsExist(fileName, loginsql))
                    {
                        DataTable table = Helper.ExecuteDataTable(fileName, loginsql);
                        int length = table.Rows.Count;
                        if (length == 0)
                        {
                            msg = "אין נרשמים";
                            Response.Redirect("LoginPage.aspx");
                        }
                        else
                        {
                            // msg = "welcome " + fname;
                            Session["UserName"] = table.Rows[0]["Uname"].ToString();//לדייק מול הבסיס נתונים 
                            Session["Admin"] = table.Rows[0]["Admin"].ToString();
                            //??
                            if (Session["Admin"].ToString() == "1")
                            {
                                msg = "welcome administrator " + Session["UserName"].ToString();
                            }
                            else
                            {
                                msg = "welcome " + Session["UserName"].ToString();
                            }
                            //  Response.Redirect("UpdateUser.aspx");
                        }
                    }
                }
            }
        }
    }
}