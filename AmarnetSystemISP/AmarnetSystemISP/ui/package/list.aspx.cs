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
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    getallPackageList();
                }
                if (packageListGridView.Rows.Count > 0)
                {
                    packageListGridView.UseAccessibleHeader = true;
                    packageListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        private void getallPackageList()
        {
            try
            {
                DataTable dt = new DataTable();
                PackageBLL packageBll = new PackageBLL();

                dt = packageBll.getAllPackageList();
                if (dt.Rows.Count > 0)
                {
                    packageListGridView.DataSource = dt;
                    packageListGridView.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Package data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                if (packageListGridView.Rows.Count > 0)
                {
                    packageListGridView.UseAccessibleHeader = true;
                    packageListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        protected void packageListGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.Cells[10].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[10].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[10].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[10].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[10].Style.Add("font-weight", "bold");
                    }
                    if (e.Row.Cells[9].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[9].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[9].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[9].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[9].Style.Add("font-weight", "bold");
                    }
                    if (e.Row.Cells[11].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[11].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[11].Style.Add("font-weight", "bold");
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

        protected void ActivateLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PackageBLL packageBll = new PackageBLL();
                bool status = false;
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label packageId = (Label)packageListGridView.Rows[row.RowIndex].FindControl("packageId");
                string IsActive = packageListGridView.Rows[row.RowIndex].Cells[10].Text.ToString();

                if (IsActive == "Yes")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Package is already Activated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else
                {
                    status = packageBll.activePackageById(packageId.Text);
                    if (status)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Package Activated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        getallPackageList();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Package can not be Activated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
            }
            catch(Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void DeactivateLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PackageBLL packageBll = new PackageBLL();
                bool status = false;
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label packageId = (Label)packageListGridView.Rows[row.RowIndex].FindControl("packageId");
                string IsActive = packageListGridView.Rows[row.RowIndex].Cells[10].Text.ToString();

                if (IsActive == "No")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Package is already Dectivated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else
                {
                    status = packageBll.DeactivePackageById(packageId.Text);
                    if (status)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Package Deactivated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        getallPackageList();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Package can not be Deactivated";
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

        protected void DeleteLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PackageBLL packageBll = new PackageBLL();
                bool status = false;
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label packageId = (Label)packageListGridView.Rows[row.RowIndex].FindControl("packageId");
                string isDelete = packageListGridView.Rows[row.RowIndex].Cells[11].Text.ToString();

                if (isDelete == "Yes")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Package is already Deleted";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else
                {
                    status = packageBll.DetelePackageById(packageId.Text);
                    if (status)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Package Deleted Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        getallPackageList();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Package can not be Deleted";
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

        protected void EditLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label packageId = (Label)packageListGridView.Rows[row.RowIndex].FindControl("packageId");
                AppSupportSessionManager.Add("PackageIdForEdit", packageId.Text.Trim());
                Response.Redirect("~/ui/package/edit.aspx",true);
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void ViewLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label packageId = (Label)packageListGridView.Rows[row.RowIndex].FindControl("packageId");
                AppSupportSessionManager.Add("PackageIdForView", packageId.Text.Trim());
                Response.Redirect("~/ui/package/view.aspx", true);
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