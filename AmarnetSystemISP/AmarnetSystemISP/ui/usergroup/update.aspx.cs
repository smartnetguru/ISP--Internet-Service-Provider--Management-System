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
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
            {
            msgBox.Visible = false;
            try
            {
                if (!IsPostBack)
                {
                    string userGroupId = AppSupportSessionManager.Get("UserGroupIdForEdit").ToString();
                    if (string.IsNullOrEmpty(userGroupId))
                    {
                        Response.Redirect("~/settings/usergroup/list.aspx", true);
                    }
                    else
                    {
                        getUserGroupInfobyId(userGroupId);
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
            
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
        protected void getUserGroupInfobyId(string userGroupid)
        {
            userGroupBLL userGroupBll = new userGroupBLL();
            DataTable dt = new DataTable();
            try
            {
                dt = userGroupBll.getUseroupinfoById(userGroupid);
                if (dt.Rows.Count > 0)
                {
                    userGroupNameTxtBx.Text = dt.Rows[0]["UserGroupName"].ToString();
                    descriptionTxtBx.Text = dt.Rows[0]["Description"].ToString();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Dtata Found on Group Id" + userGroupid;
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

        protected void updateUserGroup_Click(object sender, EventArgs e)
        {
            string userGroupId = AppSupportSessionManager.Get("UserGroupIdForEdit").ToString();
            userGroupBLL userGroupBll = new userGroupBLL();
            bool status = false;
            try
            {
                userGroupBll.UserGroupName = userGroupNameTxtBx.Text.Trim();
                userGroupBll.Description = descriptionTxtBx.Text.Trim();
               status = userGroupBll.updateUserGroupById(userGroupId);
               if (status)
               {
                   msgBox.Visible = true;
                   msgBoxTitle.Text = "Success ";
                   msgBoxDetails.Text = "User Group successfully Updated.";
                   msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                   initializeTxtBx();
               }
               else
               {
                   msgBox.Visible = true;
                   msgBoxTitle.Text = "Warning !!!";
                   msgBoxDetails.Text = "User Group Can not be Updated.";
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
        protected void initializeTxtBx()
        {
            userGroupNameTxtBx.Text = "";
            descriptionTxtBx.Text = "";
        }
    }
}