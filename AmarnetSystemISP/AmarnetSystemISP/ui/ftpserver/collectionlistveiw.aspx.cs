using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork.ui.ftpserver
{
    public partial class collectionlistveiw : System.Web.UI.Page
    {
        List<string> li1 = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {

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
        protected void parentCatagoryDrpDwnList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                li1.Clear();
                if (parentCatagoryDrpDwnList.SelectedIndex == 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Please Select Parent Ctagory";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Movie")
                {

                    ChildCatagoryDrpDwnList.Enabled = true;
                    ChildListItem2(parentCatagoryDrpDwnList.SelectedValue.ToString());
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Songs")
                {

                    ChildCatagoryDrpDwnList.Enabled = true;
                    ChildListItem2(parentCatagoryDrpDwnList.SelectedValue.ToString());
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Natok")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Cartoon")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Software")
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else
                {

                    ChildCatagoryDrpDwnList.Enabled = false;
                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
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



        protected List<string> ChildListItem2(string parentCatagory)
        {
            li1 = new List<string>();
            try
            {

                if (parentCatagory == "Movie")
                {
                    li1 = new List<string>();

                    li1.Insert(0, "--Select--");
                    li1.Insert(1, "Bangla");
                    li1.Insert(2, "English");
                    li1.Insert(3, "Hindi");
                    li1.Insert(4, "Tamil");

                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
                else if (parentCatagory == "Songs")
                {
                    li1.Insert(0, "--select--");

                    li1.Insert(1, "Bangla (Audio)");
                    li1.Insert(2, "Bangla (Video)");
                    li1.Insert(3, "Hindi (Audio)");
                    li1.Insert(4, "Hindi (Video)");
                    li1.Insert(5, "English (Audio)");
                    li1.Insert(6, "English (Video)");


                    ChildCatagoryDrpDwnList.DataSource = li1;
                    ChildCatagoryDrpDwnList.DataBind();
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
            return li1;
        }

        protected void btnGetList_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                if (parentCatagoryDrpDwnList.SelectedIndex == 0)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Please Select Parent Catagory";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    return;
                }
                if (parentCatagoryDrpDwnList.SelectedValue.ToString() == "Movie" || parentCatagoryDrpDwnList.SelectedValue.ToString() == "Songs")
                {
                    if (ChildCatagoryDrpDwnList.SelectedIndex == 0)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Please Select Child Catagory";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        return;
                    }
                }
                dt = ftpServerBll.getcollectionListByParentAndChildCatagory(parentCatagoryDrpDwnList.SelectedValue.ToString(), ChildCatagoryDrpDwnList.SelectedValue.ToString());
                if (dt.Rows.Count < 1)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                CollectionListGridView.DataSource = dt;
                CollectionListGridView.DataBind();

                if (CollectionListGridView.Rows.Count > 0)
                {
                    CollectionListGridView.UseAccessibleHeader = true;
                    CollectionListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        protected void btnView_OnClick(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton) sender;
                GridViewRow row = (GridViewRow) btn.NamingContainer;

                Label ftpCollectionId = (Label)CollectionListGridView.Rows[row.RowIndex].FindControl("FTPcollectionId");

                AppSupportSessionManager.Add("FtpCollectionIdForView",ftpCollectionId.Text);
                Response.Redirect("~/ui/ftpserver/collectionview.aspx",true);
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            try
            {
                bool st = false;
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label ftpCollectionId = (Label)CollectionListGridView.Rows[row.RowIndex].FindControl("FTPcollectionId");

                st = ftpServerBll.deleteFtpCollectionById(ftpCollectionId.Text);
                if (st)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text = "FTP Collection Successfully deleted";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    btnGetList_OnClick(this, null);
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "FTP Collection Can not be Deleted";
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

        protected void btnEdit_OnClick(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label ftpCollectionId = (Label)CollectionListGridView.Rows[row.RowIndex].FindControl("FTPcollectionId");

                AppSupportSessionManager.Add("FtpCollectionIdForEdit", ftpCollectionId.Text);
                Response.Redirect("~/ui/ftpserver/ftpcollectionedit.aspx", true);
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