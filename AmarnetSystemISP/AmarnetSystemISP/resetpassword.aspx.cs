using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork
{
    public partial class resetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string UniqueId = Request.QueryString.Get("RPID");
                if (string.IsNullOrEmpty(UniqueId))
                {
                    Response.Redirect("~/login.aspx");
                }
                if (!chkValidityOfUniqueId(UniqueId))
                {
                    AppSupportSessionManager.Add("ErrorMsg", "Reset Password Link Validity Expires");
                    Response.Redirect("~/error.aspx");
                }
            }
        }
        protected bool chkValidityOfUniqueId(string ID)
        {
            bool st = false;
            try
            {
                DataTable dt = new DataTable();
                LogInBLL loginBll = new LogInBLL();
                dt = loginBll.ChkvalidityOfUniqueId(ID);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ValidUniqueId"].ToString() == "1")
                    {
                        st = true;
                        AppSupportSessionManager.Add("ResetPassUserId", dt.Rows[0]["UserId"].ToString());
                        AppSupportSessionManager.Add("ResetPassUserEmail", dt.Rows[0]["Email"].ToString());
                    }
                    else
                    {
                        st = false;
                    }
                }
            }
            catch (Exception ex)
            {
                AppSupportSessionManager.Add("ErrorMsg", ex.Message.ToString());
                Response.Redirect("~/error.aspx");
            }
            return st;
        }

        protected void resetPassBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(NewPassTxtBx.Text))
                {
                    logInErrorMsg.Text = "Enter Passwoprd";
                }
                else if (string.IsNullOrEmpty(ReTypePasswordTxtBX.Text))
                {
                    logInErrorMsg.Text = "Enter Re-Type Password";
                }
                else if (NewPassTxtBx.Text != ReTypePasswordTxtBX.Text)
                {
                    logInErrorMsg.Text = "Password and Re-Type Password Must Be same";
                }
                else
                {
                    if (ChangePass(NewPassTxtBx.Text))
                    {
                        logInErrorMsg.Text = "Password Successfully changed";
                        logInErrorMsg.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        logInErrorMsg.Text = "Password can Not Changed";
                    }
                }
            }
            catch (Exception ex)
            {
                AppSupportSessionManager.Add("ErrorMsg", ex.Message.ToString());
                Response.Redirect("~/error.aspx");
            }
        }
        protected bool ChangePass(string NewPass)
        {
            bool status = false;
            try
            {
                string UniqueId = Request.QueryString.Get("RPID");
                ChangeUserPassBLL changePssBll = new ChangeUserPassBLL();
                changePssBll.newPass = NewPass.Trim();
                string ID = AppSupportSessionManager.Get("ResetPassUserId").ToString();
                string Email = AppSupportSessionManager.Get("ResetPassUserEmail").ToString();

                status = changePssBll.resetUserPss(UniqueId, ID, Email);
                AppSupportSessionManager.Abandon();
            }
            catch (Exception ex)
            {
                AppSupportSessionManager.Add("ErrorMsg", ex.Message.ToString());
                Response.Redirect("~/error.aspx");
            }
            return status;
        }
    }
}