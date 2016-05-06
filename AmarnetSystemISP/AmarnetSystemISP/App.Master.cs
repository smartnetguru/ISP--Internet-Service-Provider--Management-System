using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Tech;

namespace StartNetwork
{
    public partial class app : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string UserName = AppSupportSessionManager.Get("UserName").ToString();
            string Email = AppSupportSessionManager.Get("UserEmail").ToString();
            string UserRole = AppSupportSessionManager.Get("UserRole").ToString();
            string usergroup = AppSupportSessionManager.Get("UserGroupName").ToString();
            string imageName = AppSupportSessionManager.Get("ProfileImageName").ToString();
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(UserRole))
            {
                Response.Redirect("~/login.aspx");
            }
            else
            {
                if (usergroup.ToLower() == "admin" || usergroup.ToLower() == "super admin")
                {
                    userMenu.Visible = true;
                    userGroupMenu.Visible = true;
                    UserBranch.Visible = true;
                }
                else
                {
                    userMenu.Visible = false;
                    userGroupMenu.Visible = false;
                    UserBranch.Visible = false;
                }
                userName.Text = UserName;
                proFileImage.ImageUrl = "~/profileImage/" + imageName;
            }
        }
    }
}