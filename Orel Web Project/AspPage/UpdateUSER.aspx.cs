using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class UpdateUSER : System.Web.UI.Page
    {
        public string message;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                s = this.update();
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
        private int update()
        {
            int success = -1;
            string fname = Request.Form["fname"].ToString();
            string password = Request.Form["Password"].ToString();
            if(fname!=null && password != null)
            {
                string sql = "UPDATE Userstbl SET Uname='" + fname + "'WHERE Password='" + password + "'";
                Helper.DoQuery(fileName, sql);
                success = 1;
            }
            return success;
        }
        }
        
    }
    
