﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;
using System.IO;

namespace StartNetwork.ui.ftpserver
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

                    getonlineTvServerList();
                }
                if (onlineTvListGridView.Rows.Count > 0)
                {
                    onlineTvListGridView.UseAccessibleHeader = true;
                    onlineTvListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                ftpServerBll.onlineTvName = onlineTvNameTxtBx.Text.Trim();
                ftpServerBll.onlineTvServerLInk = OnlineTvLink.Text.Trim();
                ftpServerBll.imageName = SaveOnlineTvImage(onlineTvNameTxtBx.Text);
                if (btnAdd.Text == "Add")
                {
                    if (!string.IsNullOrEmpty(ftpServerBll.imageName))
                    {
                        st = ftpServerBll.addOnlineTvServer();
                        if (st)
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Success";
                            msgBoxDetails.Text = "FTP Server Created Successfully";
                            msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                            initializeTxtBx();
                            getonlineTvServerList();
                        }
                        else
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Error !!!";
                            msgBoxDetails.Text = "FTP server Can not Created";
                            msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        }
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "Please Add an image of FTP Server";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                else
                {
                    st = ftpServerBll.updateOnlineTvserver(hiddenfieldForOnlineTvServerId.Value);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "FTP Server Updated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        initializeTxtBx();
                        getonlineTvServerList();

                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Error !!!";
                        msgBoxDetails.Text = "FTP Server Can not Updated";
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
            onlineTvNameTxtBx.Text = "";
            OnlineTvLink.Text = "";
        }
        protected string SaveOnlineTvImage(string OnlineTvServerName)
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
                        string directory = Server.MapPath("~/FtpServerImage/");
                        ImageName = OnlineTvServerName + extension;
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
        protected void getonlineTvServerList()
        {
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                dt = ftpServerBll.getOnlineTvServerList();
                if (dt.Rows.Count > 0)
                {
                    onlineTvListGridView.DataSource = dt;
                    onlineTvListGridView.DataBind();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                onlineTvListGridView.DataSource = dt;
                onlineTvListGridView.DataBind();
                if (onlineTvListGridView.Rows.Count > 0)
                {
                    onlineTvListGridView.UseAccessibleHeader = true;
                    onlineTvListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

                Label lblId = (Label)onlineTvListGridView.Rows[row.RowIndex].FindControl("OnlineTvServerIdLabel");

                AppSupportSessionManager.Add("FtpServerId", lblId.Text.Trim());
                Response.Redirect("~/ui/ftpserver/view.aspx", true);
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
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)onlineTvListGridView.Rows[row.RowIndex].FindControl("onlineTvServerIdLabel");
                hiddenfieldForOnlineTvServerId.Value = lblId.Text;

                dt = ftpServerBll.EditOnlineById(lblId.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    onlineTvNameTxtBx.Text = dt.Rows[0]["FtpServerName"].ToString();
                    OnlineTvLink.Text = dt.Rows[0]["FtpserverLink"].ToString();
                    btnAdd.Text = "Update";
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Data !!!";
                    msgBoxDetails.Text = "No Data Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getonlineTvServerList();
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
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)onlineTvListGridView.Rows[row.RowIndex].FindControl("onlineTvServerIdLabel");
                string IsActive = onlineTvListGridView.Rows[row.RowIndex].Cells[3].Text.ToString();
                if (IsActive == "Yes")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "FTP Server Is already Acticated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");

                }
                else
                {
                    st = ftpServerBll.activateOnLIneTvServerById(lblId.Text);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "FTP Server Is  Acticated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        getonlineTvServerList();
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "FTP Server  can not Acticated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }

                }
                getonlineTvServerList();
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
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)onlineTvListGridView.Rows[row.RowIndex].FindControl("onlineTvServerIdLabel");
                string IsActive = onlineTvListGridView.Rows[row.RowIndex].Cells[3].Text.ToString();
                if (IsActive == "No")
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "FTP Server Is already Deacticated";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    getonlineTvServerList();
                }
                else
                {
                    st = ftpServerBll.DeactivateOnlineTvServerById(lblId.Text);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success";
                        msgBoxDetails.Text = "FTP Server Is  Deacticated Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "FTP Server  can not Deacticated";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                getonlineTvServerList();
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
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label lblId = (Label)onlineTvListGridView.Rows[row.RowIndex].FindControl("onlineTvServerIdLabel");

                st = ftpServerBll.DeleteOnlineTvServerById(lblId.Text);
                if (st)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text = "FTP Server Is  Deleted Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    getonlineTvServerList();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "FTP Server  can not Deleted";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getonlineTvServerList();
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void onlineTvListGridView_RowDataBound(object sender, GridViewRowEventArgs e)
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