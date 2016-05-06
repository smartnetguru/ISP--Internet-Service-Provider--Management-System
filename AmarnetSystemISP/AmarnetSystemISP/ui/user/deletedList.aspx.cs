using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VersityFinalProject.settings.user
{
    public partial class deletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
            { }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}