using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork.ui.torrent
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            if (!IsPostBack)
            {
                string torrentServerId = AppSupportSessionManager.Get("TorrentServerId").ToString();
                if (string.IsNullOrEmpty(torrentServerId))
                {
                    Response.Redirect("~/ui/torrent/add.aspx",true);
                }
                else
                {
                    getDetailsTorrentServerById(torrentServerId);
                }
            }
        }
        protected void getDetailsTorrentServerById(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                TorrentBLL torrentBll = new TorrentBLL();

                dt = torrentBll.EditTorrentById(ID);
                if (dt.Rows.Count > 0)
                {
                    torrentServerId.Text = ID;
                    TorrentImage.ImageUrl = "~/TorrentImage/" + dt.Rows[0]["TorrentServerImage"].ToString();
                    torrentServernameLbl.Text = dt.Rows[0]["TorrentServerName"].ToString();
                    TorrentServerLinkLbl.Text = dt.Rows[0]["TorrentServerLink"].ToString();
                    TorrentServerLinkLbl.NavigateUrl = dt.Rows[0]["TorrentServerLink"].ToString();
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