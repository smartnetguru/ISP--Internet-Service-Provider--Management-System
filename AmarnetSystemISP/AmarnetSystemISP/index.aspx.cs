using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace StartNetwork
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadSlider();
            }
        }
        protected void loadSlider()
        {
            try
            {
                DataTable dt = new DataTable();
                WebEssentialBLL webEssentialBll = new WebEssentialBLL();

                dt = webEssentialBll.loadSliderForFont();
                if (dt.Rows.Count > 0)
                {
                    sliderRepeter.DataSource = dt;
                    sliderRepeter.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}