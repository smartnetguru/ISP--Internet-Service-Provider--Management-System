using AppSupport.Project.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.page
{
    public partial class torrent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                msgBox.Visible = false;
                getAllTorrentServerList();
            }
        }
        protected void getAllTorrentServerList()
        {
            try
            {
                DataTable dt = new DataTable();
                TorrentBLL torrentBll = new TorrentBLL();

                dt = torrentBll.getTorrentServerListForView();
                if (dt.Rows.Count > 0)
                {
                    torrentRepert.DataSource = dt;
                    torrentRepert.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
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