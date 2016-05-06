using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.DLL;

namespace AppSupport.Project.BLL
{
   public class WebEssentialBLL
    {
        public string SliderTitle { get; set; }

        public string SliderMessage { get; set; }

        public string ImageName { get; set; }

        public bool addsliderImage()
        {
            bool st = false;
            WebEssentialDLL webEssentialDll = new WebEssentialDLL();
            DBplayer db = new DBplayer();

            try
            {
                db.Start();
                st = webEssentialDll.addSliderImage(db, this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public string activeSliderImage { get; set; }

        public DataTable GetAllSliderImage()
        {
            DataTable dt = new DataTable();
            WebEssentialDLL webEssentialDll = new WebEssentialDLL();
            DBplayer db = new DBplayer();

            try
            {
                db.Start();
                dt = webEssentialDll.GetSliderImage(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool DeleteSliderImageById(string ImageId)
        {
            bool st = false;
            WebEssentialDLL webEssentialDll = new WebEssentialDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = webEssentialDll.DeleteSliderImage(db, ImageId.Trim());
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool UpdatesliderImage(string ImageId)
        {
            bool st = false;
            WebEssentialDLL webEssentialDll = new WebEssentialDLL();
            DBplayer db = new DBplayer();

            try
            {
                db.Start();
                st = webEssentialDll.UpdateSliderImage(db, this,ImageId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable loadSliderForFont()
        {
            DataTable dt = new DataTable();
            WebEssentialDLL webEssentialDll = new WebEssentialDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = webEssentialDll.LoadSliderImage(db);
                db.Stop();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;
        }
    }
}
