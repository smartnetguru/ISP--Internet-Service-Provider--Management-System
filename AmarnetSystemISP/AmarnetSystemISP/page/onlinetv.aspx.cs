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
    public partial class onlinetv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                msgBox.Visible = false;
                getAllOnlineTvServerList();
            }
        }

        private void getAllOnlineTvServerList()
        {
            try
            {
                DataTable dt = new DataTable();
                onlineTvBLL onlineTvBll = new onlineTvBLL();

                dt = onlineTvBll.getOnlineTvServerListForView();
                if (dt.Rows.Count > 0)
                {
                    onlineTvserverRepert.DataSource = dt;
                    onlineTvserverRepert.DataBind();
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