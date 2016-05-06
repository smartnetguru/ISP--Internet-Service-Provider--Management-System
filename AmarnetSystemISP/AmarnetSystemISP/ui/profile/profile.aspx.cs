using AppSupport.Project.BLL;
using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.ui.profile
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            if (!IsPostBack)
            {
                string Serial = AppSupportSessionManager.Get("UserId").ToString();
                if (string.IsNullOrEmpty(Serial))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "Exception !!!! No data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else
                {
                    getuserDetailbyID(Serial);
                }
            }
        }
        private void getuserDetailbyID(string Serial)
        {
            try
            {
                userBLL userviewBll = new userBLL();
                DataTable dt = new DataTable();

                dt = userviewBll.getUserDetailsbyID(Serial);
                if (dt.Rows.Count > 0)
                {
                    profileImage.ImageUrl = "~/profileImage/" + dt.Rows[0]["profilePicName"].ToString();
                    nameLabel.Text = dt.Rows[0]["Name"].ToString();
                    EmailLabel.Text = dt.Rows[0]["Email"].ToString();


                    GenderLabel.Text = dt.Rows[0]["Gender"].ToString();
                    ContactNumberLabel.Text = "+880" + dt.Rows[0]["ContactNumber"].ToString();
                    FataherNameLabel.Text = dt.Rows[0]["FathersName"].ToString();
                    MothernameLabel.Text = dt.Rows[0]["mothersName"].ToString();
                    NationalityLabel.Text = dt.Rows[0]["Nationality"].ToString();
                    nationalIDLabel.Text = dt.Rows[0]["nationalID"].ToString();
                    permanentAddlabel.Text = dt.Rows[0]["permanentAdd"].ToString();
                    presentAddLabel.Text = dt.Rows[0]["presentAdd"].ToString();
                    userRoleLabel.Text = dt.Rows[0]["userGroup"].ToString();
                    
                    BloodGroupLabel.Text = dt.Rows[0]["BloodGroup"].ToString();
                    DOBLabel.Text = dt.Rows[0]["DOB"].ToString();
                   
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No data Found";
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/ui/profile/update.aspx",true);
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/ui/profile/changepassword.aspx", true);
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