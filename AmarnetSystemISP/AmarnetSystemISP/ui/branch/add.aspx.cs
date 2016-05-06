using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;
using System.Globalization;

namespace StartNetwork.ui.location
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
                    if (AppSupportSessionManager.Get("UserGroupName").ToLower() == "admin" || AppSupportSessionManager.Get("UserGroupName").ToLower() == "super admin")
                    {
                        getallBranchList();
                    }
                    else
                    {
                        Response.Redirect("~/default.aspx");
                    }
                    
                }
                if (BranchListGridView.Rows.Count > 0)
                {
                    BranchListGridView.UseAccessibleHeader = true;
                    BranchListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        private void getallBranchList()
        {
            try
            {
                DataTable dt = new DataTable();
                BranchBLL branchBll = new BranchBLL();

                dt = branchBll.GetAllBranchList();

                if (dt.Rows.Count < 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                BranchListGridView.DataSource = dt;
                BranchListGridView.DataBind();
                if (BranchListGridView.Rows.Count > 0)
                {
                    BranchListGridView.UseAccessibleHeader = true;
                    BranchListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                BranchBLL branchBll = new BranchBLL();

                branchBll.BranchName = BranchNameTxtBx.Text.Trim();
                branchBll.BranchAdd = branchAdd.Text.Trim();
                branchBll.branchCreatedDate = branchCreatedDate.Text.Trim();
                if (btnAdd.Text == "Add")
                {

                    status = branchBll.AddBranch();

                    if (status)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "Branch Created Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "Branch can not be Created";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                else
                {
                    status = branchBll.UpdateBranch(HiddenFieldForUpdate.Value);

                    if (status)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "Branch Updated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "Branch can not be Updated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                if (BranchListGridView.Rows.Count > 0)
                {
                    BranchListGridView.UseAccessibleHeader = true;
                    BranchListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
                }
                getallBranchList();
                initializeTxtBx();
                btnAdd.Text = "Add";
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void BranchListGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.Cells[4].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[4].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[4].Style.Add("font-weight", "bold");                       
                    }
                    else
                    {
                        e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[4].Style.Add("font-weight", "bold");
                    }
                    if (e.Row.Cells[5].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[5].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[5].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[5].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[5].Style.Add("font-weight", "bold");
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
               // DataTable dt = new DataTable();
                BranchBLL branchBll = new BranchBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label BranchId = (Label)BranchListGridView.Rows[row.RowIndex].FindControl("branchIdLabel");

                HiddenFieldForUpdate.Value = BranchId.Text;

                BranchNameTxtBx.Text = BranchListGridView.Rows[row.RowIndex].Cells[1].Text.ToString();
                branchAdd.Text = BranchListGridView.Rows[row.RowIndex].Cells[2].Text.ToString();
                string date = BranchListGridView.Rows[row.RowIndex].Cells[3].Text.ToString();

               // DateTime createdDate = DateTime.ParseExact(date,"dd/MM/yyyy",null);

                branchCreatedDate.Text = date;


                btnAdd.Text = "Update";
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected void initializeTxtBx()
        {
            BranchNameTxtBx.Text = "";
            branchAdd.Text = "";
            branchCreatedDate.Text = "";
        }

        protected void ActivateLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                BranchBLL branchBll = new BranchBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label BranchId = (Label)BranchListGridView.Rows[row.RowIndex].FindControl("branchIdLabel");

                status = branchBll.ActivateBranchById(BranchId.Text);
                if (status)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text = "Branch activated Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Branch can not be activated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getallBranchList();
            }
            catch (Exception ex)
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
                bool status = false;
                BranchBLL branchBll = new BranchBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label BranchId = (Label)BranchListGridView.Rows[row.RowIndex].FindControl("branchIdLabel");

                status = branchBll.DectivateBranchById(BranchId.Text);
                if (status)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text = "Branch Deactivated Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Branch can not be Deactivated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getallBranchList();
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
                bool status = false;
                BranchBLL branchBll = new BranchBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label BranchId = (Label)BranchListGridView.Rows[row.RowIndex].FindControl("branchIdLabel");

                status = branchBll.DeleteBranchById(BranchId.Text);
                if (status)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text = "Branch Deleted Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Branch can not be deleted";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getallBranchList();
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