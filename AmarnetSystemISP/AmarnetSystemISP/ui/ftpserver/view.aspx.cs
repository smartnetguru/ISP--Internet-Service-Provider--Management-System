using AppSupport.Project.BLL;
using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.ui.ftpserver
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            if (!IsPostBack)
            {
                string ftpserverId = AppSupportSessionManager.Get("FtpServerId").ToString();
                if (string.IsNullOrEmpty(ftpserverId))
                {
                    Response.Redirect("~/ui/ftpserver/add.aspx", true);
                }
                else
                {
                    getDetailsOnlineTvServerById(ftpserverId);
                }
            }
        }
        private void getDetailsOnlineTvServerById(string ftpserverId)
        {
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpserverBll = new ftpServerBLL();

                dt = ftpserverBll.EditOnlineById(ftpserverId);
                if (dt.Rows.Count > 0)
                {
                    OnlineTvId.Text = ftpserverId;
                    OnlineTvSerVerImage.ImageUrl = "~/FtpServerImage/" + dt.Rows[0]["FtpServerImage"].ToString();
                    OnlineTvServernameLbl.Text = dt.Rows[0]["FtpServerName"].ToString();
                    onlineTvServerLinkLbl.Text = dt.Rows[0]["FtpserverLink"].ToString();
                    onlineTvServerLinkLbl.NavigateUrl = dt.Rows[0]["FtpserverLink"].ToString();
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