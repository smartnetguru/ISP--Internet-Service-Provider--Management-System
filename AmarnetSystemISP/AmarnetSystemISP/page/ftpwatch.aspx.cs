using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Project.BLL;
using AppSupport.Tech;

namespace StartNetwork.page
{
    public partial class ftpwatch : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                string ContentId = (string)Request.QueryString["ID"];
                if (string.IsNullOrEmpty(ContentId))
                {
                    Response.Redirect("~/page/ftp.aspx",true);
                }
                else
                {
                    string newId = ContentId.Replace(" ", "+");
                    string ActualId = AppSupportLibraryManager.DecryptString(newId);

                    string Url = getContentUrlById(ActualId);
                    string Extension = Url.Split('.').Last();
                    if (Extension.ToLower() == "mp4")
                    {
                        loadVideoSource.Src = Url;
                       
                    }
                    else
                    {
                        loadVideoSource.Visible = false;
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Seleted File Can Not be Loaded";
                        msgBoxDetails.Text = "The Video Could Not be loaded eighter because the server or network faild. or The format is not Supported . Please Go back";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                
            }
            catch (Exception ex)
            {

                Response.Write(ex);
            }
        }
       
        private string getContentUrlById(string ActualId)
        {
            string Url = "";
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                dt = ftpServerBll.getCollectionDetailsById(ActualId);
                if (dt.Rows.Count > 0)
                {
                    Url = dt.Rows[0]["FTPcollectionFullLink"].ToString();
                }
            }
            catch (Exception ex)
            {

                Response.Write(ex);
            }
            return Url;
        }
    }
}