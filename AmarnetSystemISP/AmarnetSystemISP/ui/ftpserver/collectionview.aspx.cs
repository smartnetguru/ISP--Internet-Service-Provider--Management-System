using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Tech;
using System.Data;
using AppSupport.Project.BLL;

namespace StartNetwork.ui.ftpserver
{
    public partial class collectionview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    string FtpCollectionId = AppSupportSessionManager.Get("FtpCollectionIdForView").ToString();
                    if (string.IsNullOrEmpty(FtpCollectionId))
                    {
                        Response.Redirect("~/ui/ftpserver/collectionlistveiw.aspx");
                    }
                    else
                    {
                        getCollectionDetailsById(FtpCollectionId);
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

        private void getCollectionDetailsById(string FtpCollectionId)
        {
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                dt = ftpServerBll.getCollectionDetailsById(FtpCollectionId);
                if (dt.Rows.Count > 0)
                {
                    CollectionImage.ImageUrl = "~/FtpCollectionImage/" + dt.Rows[0]["FTPcollectionImageName"].ToString();
                    ftpParentCatagoryId.Text = dt.Rows[0]["FTPcollectionParentCatagory"].ToString();
                    ftpChildCatagory.Text = dt.Rows[0]["FTPcollectionChildCatagory"].ToString();
                    titleTxtBx.Text = dt.Rows[0]["FTPcollectionTitle"].ToString();
                    descriptionLabel.Text = dt.Rows[0]["FTPcollectionDescription"].ToString();
                    ftpFullLink.Text = dt.Rows[0]["FTPcollectionFullLink"].ToString();
                    ftpFullLink.NavigateUrl = dt.Rows[0]["FTPcollectionFullLink"].ToString();
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