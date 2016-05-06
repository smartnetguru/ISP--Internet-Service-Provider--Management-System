using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;
using System.IO;

namespace StartNetwork.ui.webessential
{
    public partial class sliderimage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                msgBox.Visible = false;
                if (!IsPostBack)
                {
                    getAllSliderImage();
                }
                if (SliderImageListGridView.Rows.Count > 0)
                {
                    SliderImageListGridView.UseAccessibleHeader = true;
                    SliderImageListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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
        protected void getAllSliderImage()
        {
            try
            {
                DataTable dt = new DataTable();
                WebEssentialBLL webEssentilBll = new WebEssentialBLL();

                dt = webEssentilBll.GetAllSliderImage();
                if (dt.Rows.Count < 1)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "No Slider Image Found";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }

                SliderImageListGridView.DataSource = dt;
                SliderImageListGridView.DataBind();

                if (dt.Rows.Count > 0)
                {
                    bool activeImage = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["sliderActiveImage"].ToString() == "active")
                        {
                            activeImage = true;
                            break;
                        }
                       
                    }
                    if (activeImage)
                    {
                        checkPoint.Visible = false;
                    }
                }
                if (SliderImageListGridView.Rows.Count > 0)
                {
                    SliderImageListGridView.UseAccessibleHeader = true;
                    SliderImageListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
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

        protected void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                Random randomNumber = new Random();
                double number =Convert.ToDouble(randomNumber.Next(100, int.MaxValue));
                bool st = false;
                WebEssentialBLL webEssentialBll = new WebEssentialBLL();

                webEssentialBll.SliderTitle = sliderMainTxtBx.Text.Trim();
                webEssentialBll.SliderMessage = sliderMsgTxtBx.Text.Trim();
                webEssentialBll.activeSliderImage = ImageIsActive.SelectedValue.Trim();
                webEssentialBll.ImageName = addImage(number);

                if (btnAddImage.Text == "Add Slider Image")
                {

                    if (string.IsNullOrEmpty(webEssentialBll.ImageName))
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning !!!";
                        msgBoxDetails.Text = "You must be add An Image in  PNG, GIF , JPG or JPEG format ";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                    else
                    {
                        //if (sliderImage.HasFile)
                        //{
                        //    if (sliderImage.Height.Value == 400 && sliderImage.Width == 1170)
                        //    {
                        st = webEssentialBll.addsliderImage();
                        if (st)
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Success ";
                            msgBoxDetails.Text = "Imgae added to slider Successfully";
                            msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                        }
                        else
                        {
                            msgBox.Visible = true;
                            msgBoxTitle.Text = "Warning ";
                            msgBoxDetails.Text = "Imgae can not added to slider Successfully";
                            msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                        }
                    }
                    //    else
                    //    {
                    //        msgBox.Visible = true;
                    //        msgBoxTitle.Text = "Warning ";
                    //        msgBoxDetails.Text = "Imgae Height and width must be 1170 X 400";
                    //        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    //    }
                    //}
                    //else
                    //{
                    //    msgBox.Visible = true;
                    //    msgBoxTitle.Text = "Warning ";
                    //    msgBoxDetails.Text = "Add Image PLease";
                    //    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    //}
                }
                else
                {
                    st = webEssentialBll.UpdatesliderImage(HiddenFieldforUpdateSliderImageId.Value);
                    if (st)
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Success ";
                        msgBoxDetails.Text = "Imgae updated to slider Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    }
                    else
                    {
                        msgBox.Visible = true;
                        msgBoxTitle.Text = "Warning ";
                        msgBoxDetails.Text = "Imgae can not updated to slider Successfully";
                        msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                    }
                }
                getAllSliderImage();
                initializeTxtBx();
                btnAddImage.Text = "Add Slider Image";
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.Message.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected string addImage(double ImageSerial)
        {
            string fileName = "";
            try
            {
                FileUpload filePP;
                filePP = sliderImage;
                string ext = Path.GetExtension(filePP.FileName);
                if (filePP.HasFile)
                {
                    if (ext.ToLower() == ".jpg" || ext.ToLower() == ".png" || ext.ToLower() == "jpeg" || ext.ToLower() == ".gif")
                    {
                        fileName = ImageSerial + ext;
                        string directory = Server.MapPath("~/SliderImgae/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                            filePP.PostedFile.SaveAs(directory + fileName);
                        }
                        else
                        {
                            filePP.PostedFile.SaveAs(directory + fileName);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.InnerException.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
            return fileName;
        }

        protected void EditLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WebEssentialBLL webEssentialBll = new WebEssentialBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label ImageId = (Label)SliderImageListGridView.Rows[row.RowIndex].FindControl("sliderImageSerialLbl");

                HiddenFieldforUpdateSliderImageId.Value = ImageId.Text.Trim();

                sliderMainTxtBx.Text = SliderImageListGridView.Rows[row.RowIndex].Cells[1].Text.ToString();
                sliderMsgTxtBx.Text = SliderImageListGridView.Rows[row.RowIndex].Cells[2].Text.ToString();
                string isActive = SliderImageListGridView.Rows[row.RowIndex].Cells[3].Text.ToString();

                if (isActive == "active")
                {
                    ImageIsActive.SelectedValue = isActive;
                    checkPoint.Visible = true;
                }

                btnAddImage.Text = "Update Slider Image";
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.InnerException.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }

        protected void DeleteLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool st = false;
                WebEssentialBLL webEssentialBll = new WebEssentialBLL();
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                Label ImageId = (Label)SliderImageListGridView.Rows[row.RowIndex].FindControl("sliderImageSerialLbl");

                st = webEssentialBll.DeleteSliderImageById(ImageId.Text.Trim());
                if (st)
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Success";
                    msgBoxDetails.Text ="Slider Image deleted Successfully";
                    msgBox.Attributes.Add("Class", "alert alert-success alert-block fade in");
                    getAllSliderImage();
                }
                else
                {
                    msgBox.Visible = true;
                    msgBoxTitle.Text = "Warning !!!";
                    msgBoxDetails.Text = "Slider Image Can Not be Deleted";
                    msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
                }
                getAllSliderImage();
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.InnerException.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
        protected void initializeTxtBx()
        {
            sliderMainTxtBx.Text = "";
            sliderMsgTxtBx.Text = "";
            ImageIsActive.ClearSelection();
        }

        protected void SliderImageListGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if(e.Row.Cells[3].ToString()=="active")
                    {
                        e.Row.Cells[3].Text = "Active";
                    }
                }
            }
            catch (Exception ex)
            {
                msgBox.Visible = true;
                msgBoxTitle.Text = "Warning !!!";
                msgBoxDetails.Text = ex.InnerException.ToString();
                msgBox.Attributes.Add("Class", "alert alert-danger alert-block fade in");
            }
        }
    }
}