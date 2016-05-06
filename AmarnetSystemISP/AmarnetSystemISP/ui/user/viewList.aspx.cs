using AppSupport.Project.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Tech;

namespace VersityFinalProject.settings.user
{
    public partial class viewList : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
            {
            msgBox.Visible = false;
            if (!IsPostBack)
            {
                getALlUserList();
            }
            if (userListGridView.Rows.Count > 0)
            {
                userListGridView.UseAccessibleHeader = true;
                userListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }

        private void getALlUserList()
        {
            DataTable dt = new DataTable();
            userBLL userListBll = new userBLL();
            try
            {
                dt = userListBll.getALLUserListbyType();
                if (dt.Rows.Count > 0)
                {
                    userListGridView.DataSource = dt;
                    userListGridView.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }

            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Error !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label id = (Label)userListGridView.Rows[row.RowIndex].FindControl("serialLabel");
                AppSupportSessionManager.Add("UserSerialNumberForView", id.Text);
                Response.Redirect("~/ui/user/view.aspx", true);
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Error !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
    }

}