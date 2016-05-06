using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork.page
{
    public partial class package : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    LoadBranch();
                    getPackageList(branchWisePackage.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning";
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
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected void getPackageList(string branchId)
        {
            try
            {
                DataTable dt = new DataTable();
                PackageBLL packageBll = new PackageBLL();

                //string branchId = branchWisePackage.SelectedValue.ToString();

                dt = packageBll.getAllpackageforView(branchId);
                if (dt.Rows.Count <= 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Packages data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                packageReperter.DataSource = dt;
                packageReperter.DataBind();
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void branchWisePackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                getPackageList(branchWisePackage.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
    }
}