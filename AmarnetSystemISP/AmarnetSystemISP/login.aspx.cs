using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;
using System.Net.Mail;
using System.Text;

namespace StartNetwork
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIdTxtBx.Text))
                {
                    logInErrorMsg.Text = "Email Field Required";
                }
                else if (string.IsNullOrEmpty(passwordTxtBX.Text))
                {
                    logInErrorMsg.Text = "Password Field Required";
                }
                else if (string.IsNullOrEmpty(userIdTxtBx.Text) && string.IsNullOrEmpty(passwordTxtBX.Text))
                {
                    logInErrorMsg.Text = "Emaqil and Password Field Required";
                }
                else
                {
                    DataTable dt = new DataTable();
                    LogInBLL loginBll = new LogInBLL();
                    loginBll.userEmail = userIdTxtBx.Text.Trim();
                    loginBll.passWord = passwordTxtBX.Text.Trim();

                    dt = loginBll.userLogin();
                    if (dt.Rows.Count > 0)
                    {
                        if (rememberMeChkBox.Checked)
                        {
                            Response.Cookies["UserEmail"].Value = userIdTxtBx.Text;
                            Response.Cookies["UserPW"].Value = passwordTxtBX.Text;
                            Response.Cookies["UserEmail"].Expires = DateTime.Now.AddDays(30);
                            Response.Cookies["UserPW"].Expires = DateTime.Now.AddDays(30);
                        }
                        else
                        {
                            Response.Cookies["UserEmail"].Expires = DateTime.Now.AddDays(-1);
                            Response.Cookies["UserPW"].Expires = DateTime.Now.AddDays(-1);
                        }
                        AppSupportSessionManager.Add("UserName", dt.Rows[0]["Name"].ToString());
                        AppSupportSessionManager.Add("UserEmail", dt.Rows[0]["Email"].ToString());
                        AppSupportSessionManager.Add("UserId", dt.Rows[0]["Serial"].ToString());
                        AppSupportSessionManager.Add("UserRole", dt.Rows[0]["userRole"].ToString());
                        AppSupportSessionManager.Add("UserGroupName", dt.Rows[0]["UserGroupName"].ToString());
                        AppSupportSessionManager.Add("ProfileImageName", dt.Rows[0]["profilePicName"].ToString());

                        Response.Redirect("~/default.aspx", true);
                    }
                    else
                    {

                        logInErrorMsg.Text = "Email or password do not match";
                    }
                }
            }
            catch (Exception ex)
            {
                logInErrorMsg.Text = ex.Message.ToString();
            }
        }

        protected void forGotPassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(forgorPassEmailTxtBx.Text))
                {
                    logInErrorMsg.Text = "Please Enter Email address to reset password";
                }
                else
                {
                    DataTable dt = new DataTable();
                    LogInBLL loginBll = new LogInBLL();

                    loginBll.ResetUserEmail = forgorPassEmailTxtBx.Text.Trim();

                    dt = loginBll.getUniqueIdForSendEmail();
                    if (dt.Rows.Count > 0)
                    {
                        string id = dt.Rows[0]["Returncode"].ToString();
                        if (id == "1")
                        {
                            string Name = dt.Rows[0]["Name"].ToString();
                            string Email = dt.Rows[0]["Email"].ToString();
                            string UniqueId = dt.Rows[0]["uniqueId"].ToString();

                            SendEmailForResetPass(Email, Name, UniqueId);
                            forgorPassEmailTxtBx.Text = "";
                        }
                        else
                        {
                            logInErrorMsg.Text = "Invalid User Email For Reset Password";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logInErrorMsg.Text = ex.Message.ToString();
            }
        }
        private void SendEmailForResetPass(string UserEmail,string Name , string UniqueIdForReset)
        {
            try
            {
                string host = HttpContext.Current.Request.Url.Host;
                MailMessage mailMessage = new MailMessage("aamarnets@gmail.com",UserEmail);

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear "+Name+ " <br/><br/>");
                sb.Append("Please click on the following link to reset your password");
                sb.Append("<br/>");
                sb.Append("http://"+host+"/resetpassword.aspx?RPID=" + UniqueIdForReset);
                sb.Append("</br/>");
                sb.Append("<br/>");
                sb.Append("Star Network");


                mailMessage.IsBodyHtml = true;

                mailMessage.Body = sb.ToString();

                mailMessage.Subject = "Reset Password";
                
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "aamarnets@gmail.com",
                    Password = "@m@rnetsystem"
                };

                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
           
            }
            catch (Exception ex)
            {
                logInErrorMsg.Text = ex.Message.ToString();
            }
        }
    }
}
