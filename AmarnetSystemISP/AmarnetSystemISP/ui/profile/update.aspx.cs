using AppSupport.Project.BLL;
using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.ui.profile
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    string serial = AppSupportSessionManager.Get("UserId").ToString();
                    if (!string.IsNullOrEmpty(serial))
                    {
                        
                        getuserForUpdatebySerial(serial);
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "No data Found";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
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
        private void getuserForUpdatebySerial(string serial)
        {
            DataTable dt = new DataTable();
            userBLL updateUserListBll = new userBLL();
            try
            {
                dt = updateUserListBll.getUserByID(serial);
                if (dt.Rows.Count > 0)
                {
                    NameTextBx.Text = dt.Rows[0]["Name"].ToString();
                    emailtextBX.Text = dt.Rows[0]["Email"].ToString();

                    dobTextBox.Text = dt.Rows[0]["DobUpdateFormat"].ToString();
                    genderDrpDwn.SelectedValue = dt.Rows[0]["Gender"].ToString();
                    contactNumberTxtBx.Text = dt.Rows[0]["ContactNumber"].ToString();
                    nationalityTxtBX.Text = dt.Rows[0]["Nationality"].ToString();
                    bllodGroupDrpDwn.SelectedValue = dt.Rows[0]["BloodGroup"].ToString();
                    permanentAddressTxtBx.Text = dt.Rows[0]["permanentAdd"].ToString();
                    presentAddressTxtBx.Text = dt.Rows[0]["presentAdd"].ToString();
                    nationalIdtxtBx.Text = dt.Rows[0]["nationalID"].ToString();
                    fNameTxtBox.Text = dt.Rows[0]["FathersName"].ToString();
                    mNameTextBX.Text = dt.Rows[0]["mothersName"].ToString();
                   
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Error !!!";
                    msgBoxDetails.Text = "No data Found";
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

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool st = false;

                try
                {
                    string serial = AppSupportSessionManager.Get("UserId").ToString();
                    userBLL updateUserBll = new userBLL();
                    updateUserBll.Name = NameTextBx.Text.Trim();
                    updateUserBll.Email = emailtextBX.Text.Trim();
                    updateUserBll.DOB = DateTime.ParseExact(dobTextBox.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    updateUserBll.ContactNumber = contactNumberTxtBx.Text;
                    updateUserBll.Gender = genderDrpDwn.SelectedValue.ToString();
                    updateUserBll.bloodGroup = bllodGroupDrpDwn.SelectedValue.ToString();
                    updateUserBll.nationality = nationalityTxtBX.Text.Trim();
                    updateUserBll.NationalID = nationalIdtxtBx.Text.Trim();
                    updateUserBll.perManentAdd = permanentAddressTxtBx.Text.Trim();
                    updateUserBll.presentAdd = presentAddressTxtBx.Text.Trim();
                    updateUserBll.FathersName = fNameTxtBox.Text.Trim();
                    updateUserBll.motherName = mNameTextBX.Text.Trim();
                   
                   

                    updateUserBll.profileImage = SaveImage(emailtextBX.Text);

                    st = updateUserBll.UpdateUserProfile(serial);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "User Updated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");

                        Response.Redirect("~/ui/profile/profile.aspx", true);

                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "User Can not Updated";
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
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Error !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected string SaveImage(string Email)
        {
            string fileName = "";
            try
            {
                FileUpload filePP;
                filePP = profilePicture;
                string ext = Path.GetExtension(filePP.FileName);
                if (filePP.HasFile)
                {
                    if (ext.ToLower() == ".jpg" || ext.ToLower() == ".png" || ext.ToLower() == "jpeg" || ext.ToLower() == ".gif")
                    {
                        fileName = Email + ext;
                        string directory = Server.MapPath("~/profileImage/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                            filePP.PostedFile.SaveAs(directory + fileName);
                        }
                        else
                        {
                            filePP.PostedFile.SaveAs(directory + fileName);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.InnerException.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
            return fileName;
        }
    }
}