using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.BLL;

namespace AppSupport.Project.DLL
{
   public class WebEssentialDLL
    {
        internal bool addSliderImage(DBplayer db, WebEssentialBLL webEssentialBLL)
        {
            bool st = false;
            try
            {
                db.AddParameters("@SliderTitle", webEssentialBLL.SliderTitle.Trim());
                db.AddParameters("@sliderMsg", webEssentialBLL.SliderMessage.Trim());
                db.AddParameters("@sliderImgName", webEssentialBLL.ImageName.Trim());
                db.AddParameters("@ActiveSliderImage", webEssentialBLL.activeSliderImage.Trim());
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate", DateTime.Today);

                db.ExecuteNonQuery("ADD_SLIDER_IMAGE", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable GetSliderImage(DBplayer db)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = db.ExecuteDataTable("GET_SLIDER_IMAGE", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool DeleteSliderImage(DBplayer db, string ImageId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@ImageId", ImageId.Trim());
                db.ExecuteNonQuery("DELETE_SLIDER_IMAGE", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool UpdateSliderImage(DBplayer db, WebEssentialBLL webEssentialBLL,string ImageId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@ImageId", ImageId.Trim());
                db.AddParameters("@SliderTitle", webEssentialBLL.SliderTitle.Trim());
                db.AddParameters("@sliderMsg", webEssentialBLL.SliderMessage.Trim());
                db.AddParameters("@sliderImgName", webEssentialBLL.ImageName.Trim());
                db.AddParameters("@ActiveSliderImage", webEssentialBLL.activeSliderImage.Trim());
                
                db.ExecuteNonQuery("UPDATE_SLIDER_IMAGE", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable LoadSliderImage(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("LOAD_SLIDER_IMAGE", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
