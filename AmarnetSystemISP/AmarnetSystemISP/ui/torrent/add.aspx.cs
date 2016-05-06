using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Tech;
using AppSupport.Project.BLL;
using System.IO;
using System.Data;

namespace StartNetwork.ui.torrent
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
                    getTorrentServerList();

                }
                if (torrentServerList.Rows.Count > 0)
                {
                    torrentServerList.UseAccessibleHeader = true;
                    torrentServerList.HeaderRow.TableSection = TableRowSection.TableHeader;
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
                bool st = false;
                TorrentBLL torrentBll = new TorrentBLL();

                torrentBll.torrentServerName = torrentServerNameTxtBx.Text;
                torrentBll.torrentServerLInk = torrentServerLink.Text;
                torrentBll.imageName = SaveTorrentImage(torrentServerNameTxtBx.Text);
                if (btnAdd.Text == "Add")
                {
                    if (!string.IsNullOrEmpty(torrentBll.imageName))
                    {
                        st = torrentBll.addTorrentServer();
                        if (st)
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Success";
                            msgBoxDetails.Text = "Torrent Server Created Successfully";
                            msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                            initializeTxtBx();
                            getTorrentServerList();
                        }
                        else
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Error !!!";
                            msgBoxDetails.Text = "Torrent Can not Created";
                            msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        }
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "Please Add an image of Torrent Server";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                else
                {
                    st = torrentBll.updateTorrentserver(hiddenfieldForTorrentServerId.Value);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "Torrent Server Updated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        initializeTxtBx();
                        getTorrentServerList();

                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "Torrent Can not Updated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
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

        private void initializeTxtBx()
        {
            torrentServerNameTxtBx.Text = "";
            torrentServerLink.Text = "";
        }
        protected string SaveTorrentImage(string TorrentServerName)
        {
            string ImageName = "";
            try
            {
                FileUpload uploadImage;
                uploadImage = imageUpload;
                if (uploadImage.HasFile)
                {
                    string extension = Path.GetExtension(uploadImage.FileName);
                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".gif")
                    {
                        string directory = Server.MapPath("~/TorrentImage/");
                        ImageName = TorrentServerName + extension;
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                            uploadImage.PostedFile.SaveAs(directory + ImageName);
                        }
                        else
                        {
                            uploadImage.PostedFile.SaveAs(directory + ImageName);
                        }
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "Please Add image only jpg , jpeg , png or gif file";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Error !!!";
                    msgBoxDetails.Text = "Please Add an image of Torrent Server";
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
            return ImageName;
        }
        protected void getTorrentServerList()
        {
            try
            {
                DataTable dt = new DataTable();
                TorrentBLL torrentBll = new TorrentBLL();

                dt = torrentBll.getTorrentServerList();
                if (dt.Rows.Count > 0)
                {
                    torrentServerList.DataSource = dt;
                    torrentServerList.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                torrentServerList.DataSource = dt;
                torrentServerList.DataBind();
                if (torrentServerList.Rows.Count > 0)
                {
                    torrentServerList.UseAccessibleHeader = true;
                    torrentServerList.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        protected void ViewLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {

                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)torrentServerList.Rows[row.RowIndex].FindControl("torrentServerIdLabel");

                AppSupportSessionManager.Add("TorrentServerId", lblId.Text.Trim());
                Response.Redirect("~/ui/torrent/view.aspx", true);
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
                DataTable dt = new DataTable();
                TorrentBLL torrentBll = new TorrentBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)torrentServerList.Rows[row.RowIndex].FindControl("torrentServerIdLabel");
                hiddenfieldForTorrentServerId.Value = lblId.Text;

                dt = torrentBll.EditTorrentById(lblId.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    torrentServerNameTxtBx.Text = dt.Rows[0]["TorrentServerName"].ToString();
                    torrentServerLink.Text = dt.Rows[0]["TorrentServerLink"].ToString();
                    btnAdd.Text = "Update";
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getTorrentServerList();
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
                bool st = false;
                TorrentBLL torrentBll = new TorrentBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)torrentServerList.Rows[row.RowIndex].FindControl("torrentServerIdLabel");
                string IsActive = torrentServerList.Rows[row.RowIndex].Cells[3].Text.ToString();
                if (IsActive == "Yes")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Torrent Server Is already Acticated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");

                }
                else
                {
                    st = torrentBll.activateTorrentById(lblId.Text);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success !!!";
                        msgBoxDetails.Text = "Torrent Server Is  Acticated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        getTorrentServerList();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Torrent Server  can not Acticated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }

                }
                getTorrentServerList();
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
                bool st = false;
                TorrentBLL torrentBll = new TorrentBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)torrentServerList.Rows[row.RowIndex].FindControl("torrentServerIdLabel");
                string IsActive = torrentServerList.Rows[row.RowIndex].Cells[3].Text.ToString();
                if (IsActive == "No")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Torrent Server Is already Deacticated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    getTorrentServerList();
                }
                else
                {
                    st = torrentBll.DeactivateTorrentById(lblId.Text);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success !!!";
                        msgBoxDetails.Text = "Torrent Server Is  Deacticated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "Torrent Server  can not Deacticated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                getTorrentServerList();
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
                bool st = false;
                TorrentBLL torrentBll = new TorrentBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)torrentServerList.Rows[row.RowIndex].FindControl("torrentServerIdLabel");

                st = torrentBll.DeleteTorrentById(lblId.Text);
                if (st)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success !!!";
                    msgBoxDetails.Text = "Torrent Server Is  Deleted Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    getTorrentServerList();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Torrent Server  can not Deleted";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getTorrentServerList();
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void torrentServerList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.Cells[3].Text.ToString() == "Yes")
                    {
                        e.Row.Cells[3].ForeColor = System.Drawing.Color.Green;
                        e.Row.Cells[3].Style.Add("font-weight", "bold");
                    }
                    else
                    {
                        e.Row.Cells[3].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[3].Style.Add("font-weight", "bold");
                    }
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