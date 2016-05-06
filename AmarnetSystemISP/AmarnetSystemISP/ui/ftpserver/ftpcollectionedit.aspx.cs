using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Project.BLL;
using AppSupport.Tech;

namespace StartNetwork.ui.ftpserver
{
    public partial class ftpcollectionedit : System.Web.UI.Page
    {
        List<string> li1 = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                string FtpCollectionId = AppSupportSessionManager.Get("FtpCollectionIdForEdit").ToString();
                if (string.IsNullOrEmpty(FtpCollectionId))
                {
                    Response.Redirect("~/ui/ftpserver/collectionlistveiw.aspx", true);
                }
                else
                {
                    if (!IsPostBack)
                    {
                        HiddenFieldForUpdate.Value = FtpCollectionId;
                        getFtpCollectionDetailsById(FtpCollectionId);
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

        private void getFtpCollectionDetailsById(string FtpCollectionId)
        {

            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                dt = ftpServerBll.getCollectionDetailsById(FtpCollectionId);
                if (dt.Rows.Count > 0)
                {
                    parentCatagoryDrpDwnList.SelectedValue = dt.Rows[0]["FTPcollectionParentCatagory"].ToString();
                    ChildListItem2(parentCatagoryDrpDwnList.SelectedValue.ToString());
                    ChildCatagoryDrpDwnList.SelectedValue = dt.Rows[0]["FTPcollectionChildCatagory"].ToString();
                    TileTxtBx.Text = dt.Rows[0]["FTPcollectionTitle"].ToString();
                    descriptionTxtBx.Text = dt.Rows[0]["FTPcollectionDescription"].ToString();
                    ftpIpTxtBx.Text = dt.Rows[0]["FTPcollectionFTPlink"].ToString();
                    ftpMovieLocation.Text = dt.Rows[0]["FTPcollectionLink"].ToString();
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
        protected void parentCatagoryDrpDwnList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                li1.Clear();
                if (parentCatagoryDrpDwnList.SelectedIndex == 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Please Select Parent Ctagory";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Movie")
                {

                    ChildCatagoryDrpDwnList.Enabled = true;
                    ChildListItem2(parentCatagoryDrpDwnList.SelectedValue.ToString());
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Songs")
                {

                    ChildCatagoryDrpDwnList.Enabled = true;
                    ChildListItem2(parentCatagoryDrpDwnList.SelectedValue.ToString());
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Natok")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Cartoon")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Software")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
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



        protected List<string> ChildListItem2(string parentCatagory)
        {
            li1 = new List<string>();
            try
            {

                if (parentCatagory == "Movie")
                {
                    li1 = new List<string>();

                    li1.Insert(0, "--Select--");
                    li1.Insert(1, "Bangla");
                    li1.Insert(2, "English");
                    li1.Insert(3, "Hindi");
                    li1.Insert(4, "Tamil");

                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagory == "Songs")
                {
                    li1.Insert(0, "--select--");

                    li1.Insert(1, "Bangla (Audio)");
                    li1.Insert(2, "Bangla (Video)");
                    li1.Insert(3, "Hindi (Audio)");
                    li1.Insert(4, "Hindi (Video)");
                    li1.Insert(5, "English (Audio)");
                    li1.Insert(6, "English (Video)");


                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
            return li1;
        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    bool status = false;
                    ftpServerBLL ftpServerBll = new ftpServerBLL();

                    string imageName = CollectionImageName(TileTxtBx.Text);
                    if (parentCatagoryDrpDwnList.SelectedIndex == 0)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Please select Parent catagory";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        return;
                    }
                    if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Movie" || parentCatagoryDrpDwnList.SelectedValue.ToString() == "Songs")
                    {
                        if (ChildCatagoryDrpDwnList.SelectedIndex == 0)
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Warning !!!";
                            msgBoxDetails.Text = "Please select Child catagory";
                            msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                            return;
                        }
                    }
                    if (string.IsNullOrEmpty(TileTxtBx.Text))
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Please Enter Title";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        return;
                    }
                    if (string.IsNullOrEmpty(ftpIpTxtBx.Text))
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Please Enter FTP IP address";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        return;
                    }

                    if (string.IsNullOrEmpty(ftpMovieLocation.Text))
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Please Enter FTP folder location correctly";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        return;
                    }
                    else
                    {
                        ftpServerBll.parentCatagory = parentCatagoryDrpDwnList.SelectedValue.ToString();
                        ftpServerBll.childCatagory = ChildCatagoryDrpDwnList.SelectedValue.ToString();
                        ftpServerBll.ftpcollectionTitle = TileTxtBx.Text.Trim();
                        ftpServerBll.ftpcollectionDescription = descriptionTxtBx.Text.Trim();
                        ftpServerBll.ftpIp = ftpIpTxtBx.Text.Trim();
                        ftpServerBll.ftpMovieLocation = ftpMovieLocation.Text.Trim();
                        ftpServerBll.ftpMovieFullLink = string.Concat(ftpIpTxtBx.Text.Trim() + ftpMovieLocation.Text.Trim());
                        ftpServerBll.ftpCollectionImageName = imageName;

                        status = ftpServerBll.UpdateFtpCollection(HiddenFieldForUpdate.Value);
                        if (status)
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Success";
                            msgBoxDetails.Text = "FTP Collection Updated Successfully";
                            msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                            initialize();
                        }
                        else
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Warning !!!";
                            msgBoxDetails.Text = "FTP Collection can not be Updated";
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
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected string CollectionImageName(string Title)
        {
            string finalImageName = "";
            try
            {
                FileUpload image;
                image = imageUpload;
                string extension = Path.GetExtension(image.FileName);

                if (image.HasFile)
                {
                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png" || extension.ToLower() == ".gif")
                    {
                        FileInfo getImageInfo = new FileInfo(image.FileName);

                        finalImageName = Title + extension;
                        string path = Server.MapPath("~/FtpCollectionImage/");
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                            image.PostedFile.SaveAs(path + finalImageName);
                        }
                        else
                        {
                            image.PostedFile.SaveAs(path + finalImageName);
                        }
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
            return finalImageName;
        }

        protected void initialize()
        {
            parentCatagoryDrpDwnList.ClearSelection();
            ChildCatagoryDrpDwnList.ClearSelection();
            TileTxtBx.Text = "";
            descriptionTxtBx.Text = "";
            ftpMovieLocation.Text = "";
            li1.Clear();
        }
    }
}