using AppSupport.Project.BLL;
using AppSupport.Tech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartNetwork.ui.package
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            try
            {
                if (!IsPostBack)
                {
                    string packageId = AppSupportSessionManager.Get("PackageIdForView").ToString();
                    if (string.IsNullOrEmpty(packageId))
                    {
                        Response.Redirect("~/ui/package/list.aspx", true);
                    }
                    else
                    {
                        getpackageDetails(packageId);
                        AppSupportSessionManager.Remove("PackageIdForView");
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
        private void getpackageDetails(string packageId)
        {
            try
            {
                DataTable dt = new DataTable();
                PackageBLL packageBll = new PackageBLL();

                dt = packageBll.getPackageDetails(packageId);
                if (dt.Rows.Count > 0)
                {
                    packageIdLabel.Text = dt.Rows[0]["PackageId"].ToString();
                    PackagenameLabel.Text = dt.Rows[0]["PackageName"].ToString();
                    packagePriceLabel.Text = dt.Rows[0]["packagePrice"].ToString();
                    //packageMinSpdlbl.Text = dt.Rows[0]["packageMinSpd"].ToString();
                    packageMaxSpeedlbl.Text = dt.Rows[0]["packageMaxSpd"].ToString();
                    youtubeSpd.Text = dt.Rows[0]["youtubeSpeed"].ToString();
                    starNetworkSpdLbl.Text = dt.Rows[0]["starNetworkFtpSpd"].ToString();
                    //otherFtpSpdlbl.Text = dt.Rows[0]["otherFtpSpd"].ToString();
                    bdixSpdLbl.Text = dt.Rows[0]["bdixSpd"].ToString();
                    branchName.Text = dt.Rows[0]["BranchName"].ToString();
                    string realIp = dt.Rows[0]["RealIp"].ToString();

                    if (realIp == "Yes")
                    {
                        realIpLabel.Text = "Yes";
                        realIpLabel.ForeColor = System.Drawing.Color.Green;

                    }
                    else if (realIp == "No")
                    {
                        realIpLabel.Text = "No";
                        realIpLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        realIpLabel.Text = "Required";
                        realIpLabel.ForeColor = System.Drawing.Color.Red;
                    }
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