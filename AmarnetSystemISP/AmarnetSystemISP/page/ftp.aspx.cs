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
    public partial class ftp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    getLatestMovieCoillection();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        private void getLatestMovieCoillection()
        {
            try
            {
                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();

                dt = ftpServerBll.getLatestMovieCollection();
                if (dt.Rows.Count < 1)
                {
                    return;
                }
                LatesMovieRepeter.DataSource = dt;
                LatesMovieRepeter.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void btnWatchNow_OnClick(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                RepeaterItem repeaterItem = (RepeaterItem)btn.NamingContainer;

                Label collectionId = (Label)repeaterItem.FindControl("ftpCollectionId");
                string EncryptedId = AppSupportLibraryManager.EncryptString(collectionId.Text);

                Response.Redirect("~/page/ftpwatch.aspx?ID=" + EncryptedId, true);
            }
            catch (Exception ex)
            {

                Response.Write(ex);
            }
        }

        protected void BanglaMovie_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("BM");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection,true);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void HindiMovie_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("HindiMovie");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection,true);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void EnglishMovie_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("EM");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void BanlaAudioSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("BSA");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void BanglaVedioSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("BSVedio");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void HindiAudioSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("HSA");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void HindiVideoSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("HSV");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void EnglishAudioSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("ESA");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void EnglishVideoSongs_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("ESV");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Software_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("Software");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Cartoon_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("Cartoon");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void PcGams_OnClick(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("Games");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void searchButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(searchTxtBx.Text) || searchTxtBx.Text == "Search:")
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert ('Please enter search Text')</script>");
                }
                else
                {
                    Response.Redirect("~/page/ftpsearch.aspx?search=" + searchTxtBx.Text);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void TamilMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("TM");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Natok_Click(object sender, EventArgs e)
        {
            try
            {
                string encrypTedCottection = AppSupportLibraryManager.EncryptString("Natok");
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}