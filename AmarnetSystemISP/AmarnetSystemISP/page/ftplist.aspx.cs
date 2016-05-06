using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppSupport.Project.BLL;
using AppSupport.Tech;

namespace StartNetwork.page
{
    public partial class ftplist : System.Web.UI.Page
    {
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public List<int> PageNumbers;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                try
                {
                    string id = (string)Request.QueryString.Get("ID");

                    string NewId = id.Replace(" ", "+");

                    string ContentCottetion = AppSupportLibraryManager.DecryptString(NewId);
                    if (string.IsNullOrEmpty(ContentCottetion))
                    {
                        Response.Redirect("~/page/ftp.aspx");
                    }
                    else
                    {
                        StartPoint = 1;
                        EndPoint = 20;
                        getList(ContentCottetion, StartPoint, EndPoint);
                        BindPageNumberRepeter(ContentCottetion);
                        startPointHiddenfield.Value = Convert.ToString(StartPoint);
                        endPointHiddenField.Value = Convert.ToString(EndPoint);
                    }
                }
                catch (Exception ex)
                {
                    HeaderId.Visible = false;
                    ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert ('No Data Found. Please Go FTP Home Page')</script>");
                }
            }

        }
        protected void BindPageNumberRepeter(string Cottection)
        {
            try
            {
                int totalItem = getRowNumberbyCottetion(Cottection);

                int TotalPageNumber = totalItem / 20; // 2 Is number of collection shown in one page
                double chkLastPage = totalItem % 20;
                if (chkLastPage > 0)
                {
                    TotalPageNumber = TotalPageNumber + 1;
                }
                PageNumbers = new List<int>();
                for (int i = 1; i <= TotalPageNumber; i++)
                {
                    PageNumbers.Add(i);
                }
                pageRptr.DataSource = PageNumbers;
                pageRptr.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
        protected void getList(string QueryString, int starPoint, int EndPoint)
        {
            try
            {
                int collectionItemTotal = getRowNumberbyCottetion(QueryString);

                DataTable dt = new DataTable();
                ftpServerBLL ftpServerBll = new ftpServerBLL();
                if (starPoint == 1 || StartPoint < 1)
                {
                    previouButton.Visible = false;
                }
                else
                {
                    previouButton.Visible = true;
                }
                if (EndPoint >= collectionItemTotal)
                {
                    nextButton.Visible = false;
                }
                else
                {
                    nextButton.Visible = true;
                }
                dt = ftpServerBll.getFtpCollectionByCottetion(QueryString, starPoint, EndPoint);
                if (dt.Rows.Count > 0)
                {
                    contentListRepeter.DataSource = dt;
                    contentListRepeter.DataBind();
                }
                else
                {

                    HeaderId.Visible = false;
                    ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert ('No Data Found. Please Go FTP Home Page')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
        protected int getRowNumberbyCottetion(string Cottetion)
        {
            int rowNumber = 0;
            try
            {
                ftpServerBLL ftpserverBll = new ftpServerBLL();
                rowNumber = ftpserverBll.getRowNumberByCottetion(Cottetion);
            }
            catch (Exception ex)
            {
                HeaderId.Visible = false;
            }
            return rowNumber;
        }
        protected void btnWatchNow_OnClick(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                RepeaterItem repeaterItem = (RepeaterItem)btn.NamingContainer;

                Label collectionId = (Label)repeaterItem.FindControl("ftpCollectionId");
                string EncryptedId = AppSupportLibraryManager.EncryptString(collectionId.Text);

                Response.Redirect("~/page/ftpdetails.aspx?ID=" + EncryptedId, true);
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
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
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
                Response.Redirect("~/page/ftplist.aspx?ID=" + encrypTedCottection);
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
                if (string.IsNullOrEmpty(searchTxtBx.Text) || searchTxtBx.Text == "Search")
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

        protected void btnDetails_OnClick(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                RepeaterItem item = (RepeaterItem)btn.NamingContainer;


                Label CollectionId = (Label)item.FindControl("ftpCollectionId");
                Response.Redirect("~/page/ftpdetails.aspx?ID=" + AppSupportLibraryManager.EncryptString(CollectionId.Text), true);
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

        protected void previouButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = (string)Request.QueryString.Get("ID");

                string NewId = id.Replace(" ", "+");

                string ContentCottetion = AppSupportLibraryManager.DecryptString(NewId);
                if (string.IsNullOrEmpty(ContentCottetion))
                {
                    Response.Redirect("~/page/ftp.aspx");
                }
                else
                {
                    StartPoint = Convert.ToInt32(startPointHiddenfield.Value) - 20;
                    EndPoint = Convert.ToInt32(endPointHiddenField.Value) - 20;
                    getList(ContentCottetion, StartPoint, EndPoint);
                    if (StartPoint < 1)
                    {
                        StartPoint = 1;
                    }
                    if (EndPoint < 20)
                    {
                        EndPoint = 20;
                    }
                    startPointHiddenfield.Value = Convert.ToString(StartPoint);
                    endPointHiddenField.Value = Convert.ToString(EndPoint);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = (string)Request.QueryString.Get("ID");

                string NewId = id.Replace(" ", "+");

                string ContentCottetion = AppSupportLibraryManager.DecryptString(NewId);
                if (string.IsNullOrEmpty(ContentCottetion))
                {
                    Response.Redirect("~/page/ftp.aspx");
                }
                else
                {
                    StartPoint = Convert.ToInt32(startPointHiddenfield.Value) + 20;
                    EndPoint = Convert.ToInt32(endPointHiddenField.Value) + 20;
                    getList(ContentCottetion, StartPoint, EndPoint);
                    startPointHiddenfield.Value = Convert.ToString(StartPoint);
                    endPointHiddenField.Value = Convert.ToString(EndPoint);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void btnPageNumber_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                hiddenFieldForOnStandingPage.Value = btn.Text;

                StartPoint = ((Convert.ToInt32(hiddenFieldForOnStandingPage.Value) - 1) * 20) + 1;
                EndPoint = Convert.ToInt32(hiddenFieldForOnStandingPage.Value) * 20;

                string id = (string)Request.QueryString.Get("ID");

                string NewId = id.Replace(" ", "+");

                string ContentCottetion = AppSupportLibraryManager.DecryptString(NewId);
                if (string.IsNullOrEmpty(ContentCottetion))
                {
                    Response.Redirect("~/page/ftp.aspx");
                }
                else
                {
                    getList(ContentCottetion, StartPoint, EndPoint);
                    startPointHiddenfield.Value = Convert.ToString(StartPoint);
                    endPointHiddenField.Value = Convert.ToString(EndPoint);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}