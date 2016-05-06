using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork.ui.package
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgBox.Visible = false;
            try
            {
                if (!IsPostBack)
                {
                    string packageId = AppSupportSessionManager.Get("PackageIdForEdit").ToString();
                    if (string.IsNullOrEmpty(packageId))
                    {
                        Response.Redirect("~/ui/package/list.aspx", true);
                    }
                    else
                    {
                        getpackageDetails(packageId);
                        LoadBranch();
                        AppSupportSessionManager.Remove("PackageIdForEdit");
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
        protected void LoadBranch()
        {
            try
            {
                DataTable dt = new DataTable();
                PackageBLL packageBll = new PackageBLL();

                dt = packageBll.loadBranch();

                if (dt.Rows.Count < 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Branch Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                branchWisePackage.DataSource = dt;
                branchWisePackage.DataTextField = "BranchName";
                branchWisePackage.DataValueField = "branchId";


                branchWisePackage.DataBind();

                branchWisePackage.Items.Insert(0, "--Select--");
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
                    hiddenVieldForPackageId.Value = dt.Rows[0]["PackageId"].ToString();
                    packageNameTxtBx.Text = dt.Rows[0]["PackageName"].ToString();
                    packagePriceMoney.Text = dt.Rows[0]["packagePrice"].ToString();
                   // packageMinimumSpeed.Text = dt.Rows[0]["packageMinSpd"].ToString();
                    packageMaxSpd.Text = dt.Rows[0]["packageMaxSpd"].ToString();
                    youtubeSpeedTxtxBx.Text = dt.Rows[0]["youtubeSpeed"].ToString();
                    starNetWorkFtpTxtBx.Text = dt.Rows[0]["starNetworkFtpSpd"].ToString();
                    //otherFtptxtBx.Text = dt.Rows[0]["otherFtpSpd"].ToString();
                    bdixSpeedTxtBx.Text = dt.Rows[0]["bdixSpd"].ToString();
                    realIpdrpDwnList.SelectedValue = dt.Rows[0]["RealIp"].ToString();
                    branchWisePackage.SelectedValue = dt.Rows[0]["BranchId"].ToString();
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool st = false;
                PackageBLL packageBll = new PackageBLL();

                decimal chkValue;
                if (!decimal.TryParse(packagePriceMoney.Text.Trim(), out chkValue))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Price Money Must be in correct Format";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                //else if (!decimal.TryParse(packageMinimumSpeed.Text.Trim(), out chkValue))
                //{
                //    msgBox.Visible = true;
                //    msgBoxTitle.Text = "Warning !!! ";
                //    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                //    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                //}
                else if (!decimal.TryParse(packageMaxSpd.Text.Trim(), out chkValue))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else if (!decimal.TryParse(youtubeSpeedTxtxBx.Text.Trim(), out chkValue))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else if (!decimal.TryParse(starNetWorkFtpTxtBx.Text.Trim(), out chkValue))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                //else if (!decimal.TryParse(packageMinimumSpeed.Text.Trim(), out chkValue))
                //{
                //    msgBox.Visible = true;
                //    msgBoxTitle.Text = "Warning !!! ";
                //    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                //    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                //}
                //else if (!decimal.TryParse(otherFtptxtBx.Text.Trim(), out chkValue))
                //{
                //    msgBox.Visible = true;
                //    msgBoxTitle.Text = "Warning !!! ";
                //    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                //    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                //}
                else if (!decimal.TryParse(bdixSpeedTxtBx.Text.Trim(), out chkValue))
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }

                else
                {
                    packageBll.packageName = packageNameTxtBx.Text.Trim();
                    packageBll.packagePrice = Convert.ToDecimal(packagePriceMoney.Text.Trim());
                    packageBll.packageMinSpeed = 0;
                    packageBll.packageMaxSpeed = Convert.ToDecimal(packageMaxSpd.Text.Trim());
                    packageBll.YoutubeSpeed = Convert.ToDecimal(youtubeSpeedTxtxBx.Text.Trim());
                    packageBll.starNetWorkFtp = Convert.ToDecimal(starNetWorkFtpTxtBx.Text.Trim());
                    packageBll.otherFtp = 0;
                    packageBll.BdixSpd = Convert.ToDecimal(bdixSpeedTxtBx.Text.Trim());
                    packageBll.realIp = realIpdrpDwnList.SelectedValue.ToString();
                    packageBll.branch = branchWisePackage.SelectedValue.ToString();

                    st = packageBll.updatePackageInfoById(hiddenVieldForPackageId.Value);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Package Updated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        initializeTxtxBx();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!! ";
                        msgBoxDetails.Text = "Package Can not be Updated";
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
        protected void initializeTxtxBx()
        {
            packageNameTxtBx.Text = "";
            packagePriceMoney.Text = "";
           // packageMinimumSpeed.Text = "";
            packageMaxSpd.Text = "";
            youtubeSpeedTxtxBx.Text = "";
            starNetWorkFtpTxtBx.Text = "";
           // otherFtptxtBx.Text = "";
            bdixSpeedTxtBx.Text = "";
            realIpdrpDwnList.SelectedIndex = 0;
            branchWisePackage.SelectedIndex = 0;
        }
    }
}