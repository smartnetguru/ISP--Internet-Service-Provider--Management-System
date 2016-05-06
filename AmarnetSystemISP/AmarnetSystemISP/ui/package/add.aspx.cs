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
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    LoadBranch();
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

        protected void btnAdd_Click(object sender, EventArgs e)
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
                //else if (!decimal.TryParse(packageMaxSpd.Text.Trim(), out chkValue))
                //{
                //    msgBox.Visible = true;
                //    msgBoxTitle.Text = "Warning !!! ";
                //    msgBoxDetails.Text = "Package Minumum Speed Must be in correct Format";
                //    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                //}
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
                else if(realIpdrpDwnList.SelectedIndex == 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Real IP Must be Selected";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else if (branchWisePackage.SelectedIndex == 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!! ";
                    msgBoxDetails.Text = "Package Branch Must be Selected";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else
                {
                    packageBll.packageName = packageNameTxtBx.Text.Trim();
                    packageBll.packagePrice = Convert.ToDecimal(packagePriceMoney.Text.Trim());
                    packageBll.packageMinSpeed = 0;
                    packageBll.packageMaxSpeed = 0;
                    packageBll.YoutubeSpeed = Convert.ToDecimal(youtubeSpeedTxtxBx.Text.Trim());
                    packageBll.starNetWorkFtp = Convert.ToDecimal(starNetWorkFtpTxtBx.Text.Trim());
                    packageBll.otherFtp = 0;
                    packageBll.BdixSpd = Convert.ToDecimal(bdixSpeedTxtBx.Text.Trim());
                    packageBll.realIp = realIpdrpDwnList.SelectedValue.ToString();
                    packageBll.branch = branchWisePackage.SelectedValue.ToString();

                    st = packageBll.addPackageInfo();
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Package Created Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        initializeTxtxBx();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!! ";
                        msgBoxDetails.Text = "Package Can not be Created";
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
           // packageMaxSpd.Text = "";
            youtubeSpeedTxtxBx.Text = "";
            starNetWorkFtpTxtBx.Text = "";
           // otherFtptxtBx.Text = "";
            bdixSpeedTxtBx.Text = "";
            realIpdrpDwnList.SelectedIndex = 0;
            branchWisePackage.SelectedIndex = 0;
        }
    }
}