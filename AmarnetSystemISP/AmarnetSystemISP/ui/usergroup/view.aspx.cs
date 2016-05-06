﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace VersityFinalProject.settings.usergroup
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    string userGroupId = (string)AppSupportSessionManager.Get("UserGroupIdForView");

                    if (string.IsNullOrEmpty(userGroupId))
                    {
                        Response.Redirect("~/settings/usergroup/viewlist.aspx", true);
                    }
                    else
                    {
                        getUserGroupDetails(userGroupId);
                    }
                }
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
        protected void getUserGroupDetails(string GroupId)
        {
            DataTable dt = new DataTable();
            try
            {
                userGroupBLL usergroupBll = new userGroupBLL();
                dt = usergroupBll.getUserDetailById(GroupId);
                if (dt.Rows.Count > 0)
                {
                    userGroupIdLabel.Text = dt.Rows[0]["UserGroupId"].ToString();
                    UserGroupnameLabel.Text = dt.Rows[0]["UserGroupName"].ToString();
                    descripTionLabel.Text = dt.Rows[0]["Description"].ToString();
                    createdByLabel.Text = dt.Rows[0]["NameCreatedBy"].ToString();
                    createdDateLabel.Text = dt.Rows[0]["Date"].ToString();
                    if (dt.Rows[0]["IsActive"].ToString() == "Yes")
                    {
                        IsActiveLabel.Text = dt.Rows[0]["IsActive"].ToString();
                        IsActiveLabel.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        IsActiveLabel.Text = dt.Rows[0]["IsActive"].ToString();
                        IsActiveLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dt.Rows[0]["IsDeleted"].ToString() == "Yes")
                    {
                        IsDeletedLabael.Text = dt.Rows[0]["IsDeleted"].ToString();
                        IsDeletedLabael.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        IsDeletedLabael.Text = dt.Rows[0]["IsDeleted"].ToString();
                        IsDeletedLabael.ForeColor = System.Drawing.Color.Red;
                    }
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
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
    }
}