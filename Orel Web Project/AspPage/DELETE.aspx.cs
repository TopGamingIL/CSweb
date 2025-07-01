using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class DELETE : System.Web.UI.Page
    {
        public string message;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                s = this.Delete1();
                if (s > 0)
                {
                    message = "Delete success";
                }
                else
                {
                    message = "Delete failed";
                }
            }

        }
        private int Delete1()
        {
            int success = -1;
           
            string password = Request.Form["Password"].ToString();
            if ( password != null)
            {
                string sql = "DELETE FROM Userstbl WHERE Password='" + password + "'";
                Helper.DoQuery(fileName, sql);
                success = 1;
            }
            return success;
        }
    }

}

