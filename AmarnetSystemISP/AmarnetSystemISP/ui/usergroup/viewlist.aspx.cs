using AppSupport.Project.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Tech;

namespace VersityFinalProject.settings.usergroup
{
    public partial class viewlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
            {

            msgBox.Visible = false;
            if (!IsPostBack)
            {
                getuserGroupList();
            }
            if (userGroupListGridView.Rows.Count > 0)
            {
                userGroupListGridView.UseAccessibleHeader = true;
                userGroupListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
        protected void getuserGroupList()
        {
            DataTable dt = new DataTable();
            userGroupBLL userGroupbll = new userGroupBLL();
            try
            {
                dt = userGroupbll.getUserGroupList();
                if (dt.Rows.Count > 0)
                {
                    userGroupListGridView.DataSource = dt;
                    userGroupListGridView.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No User group Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                if (userGroupListGridView.Rows.Count > 0)
                {
                    userGroupListGridView.UseAccessibleHeader = true;
                    userGroupListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected void userGroupListGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.Cells[3].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[3].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[3].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[3].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[3].Style.Add("font-weight", "bold");
                    }

                    if (e.Row.Cells[4].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[4].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[4].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[4].Style.Add("font-weight", "bold");
                    }
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblSerial = (Label)userGroupListGridView.Rows[row.RowIndex].FindControl("userGroupIdLabel");

                AppSupportSessionManager.Add("UserGroupIdForView",lblSerial.Text);
                Response.Redirect("~/ui/usergroup/view.aspx",true);
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
    }
}