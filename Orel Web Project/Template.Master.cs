using Orel_Web_Project.AspPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"].ToString() == "1")//מנהל
            {
                del.Style.Add("display", "block");
                upd.Style.Add("display", "block");
                reg1.Style.Add("display", "none");
                log.Style.Add("display", "none");
                home.Style.Add("display", "block");
                search.Style.Add("display", "block");
                blist.Style.Add("display", "block");
                addapp.Style.Add("display", "block");
               
            }
            else if (Session["userName"].ToString() != "visitor")//רשום
            {
                del.Style.Add("display", "block");
                upd.Style.Add("display", "block");
                reg1.Style.Add("display", "none");
                log.Style.Add("display", "none");
                home.Style.Add("display", "block");
                search.Style.Add("display", "none");
                blist.Style.Add("display", "block");
                addapp.Style.Add("display", "block");
            }
            else//אורח
            {
                del.Style.Add("display", "none");
                upd.Style.Add("display", "none");
                reg1.Style.Add("display", "block");
                log.Style.Add("display", "block");
                home.Style.Add("display", "block");
                search.Style.Add("display", "none");
                blist.Style.Add("display", "none");
                addapp.Style.Add("display", "none");
            }
        }
    }
}