using AppSupport.Project.BLL;
using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.ui.onlinetv
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            if (!IsPostBack)
            {
                string OnlineTvServerId = AppSupportSessionManager.Get("onlineTvServerId").ToString();
                if (string.IsNullOrEmpty(OnlineTvServerId))
                {
                    Response.Redirect("~/ui/onlinetv/add.aspx", true);
                }
                else
                {
                    getDetailsOnlineTvServerById(OnlineTvServerId);
                }
            }
        }

        private void getDetailsOnlineTvServerById(string OnlineTvServerId)
        {
            try
            {
                DataTable dt = new DataTable();
                onlineTvBLL onlineTvBll = new onlineTvBLL();

                dt = onlineTvBll.EditOnlineById(OnlineTvServerId);
                if (dt.Rows.Count > 0)
                {
                    OnlineTvId.Text = OnlineTvServerId;
                    OnlineTvSerVerImage.ImageUrl = "~/OnlineTVImage/" + dt.Rows[0]["onlineTvServerImage"].ToString();
                    OnlineTvServernameLbl.Text = dt.Rows[0]["onlineTvServerName"].ToString();
                    onlineTvServerLinkLbl.Text = dt.Rows[0]["onlineTvServerLink"].ToString();
                    onlineTvServerLinkLbl.NavigateUrl = dt.Rows[0]["onlineTvServerLink"].ToString();
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