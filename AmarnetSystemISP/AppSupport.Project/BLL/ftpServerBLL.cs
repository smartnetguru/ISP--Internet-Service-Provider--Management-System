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
    public class ftpServerBLL
    {
        public string onlineTvName { get; set; }

        public string onlineTvServerLInk { get; set; }

        public string imageName { get; set; }

        public bool addOnlineTvServer()
        {
            bool st = false;
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = ftpServerDll.addOnlineTvServer(db, this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool updateOnlineTvserver(string OnlienTvServerId)
        {
            bool st = false;
            ftpServerDLL onlienTvDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = onlienTvDll.UpdateOnlineTvServerByID(db, this, OnlienTvServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable getOnlineTvServerList()
        {
            DataTable dt = new DataTable();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = ftpServerDll.getOnlineTvServerList(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable EditOnlineById(string OnlineTvserverId)
        {
            DataTable dt = new DataTable();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = ftpServerDll.EditOnlineTvServerDetailsById(db, OnlineTvserverId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool activateOnLIneTvServerById(string onlineTvServerId)
        {
            bool st = false;
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = ftpServerDll.ActivateOnlineTvServer(db, onlineTvServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeactivateOnlineTvServerById(string OnlineTvServerId)
        {
            bool st = false;
            ftpServerDLL onlienTvDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = onlienTvDll.DeactivateOnlineTvServer(db, OnlineTvServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeleteOnlineTvServerById(string onlineTvServerId)
        {
            bool st = false;
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = ftpServerDll.deleteOnlineTvServerById(db, onlineTvServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable getOnlineTvServerListForView()
        {
            DataTable dt = new DataTable();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = ftpServerDll.getOnlineTvServerListForView(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public string parentCatagory { get; set; }

        public string childCatagory { get; set; }

        public string ftpcollectionTitle { get; set; }

        public string ftpcollectionDescription { get; set; }

        public string ftpMovieFullLink { get; set; }

        public string ftpCollectionImageName { get; set; }

        public bool saveFtpCollection()
        {
            bool status = false;
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                status = ftpServerDll.saveFtpCollection(db, this);
                db.Stop();
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        public DataTable getcollectionListByParentAndChildCatagory(string ParentCatagory, string ChildCatagory)
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();

            try
            {
                db.Start();
                dt = ftpServerDll.getcollectionListByParentAndChildCatagory(db, ParentCatagory, ChildCatagory);
                db.Stop();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public string ftpMovieLocation { get; set; }

        public string ftpIp { get; set; }

        public DataTable getCollectionDetailsById(string FtpCollectionId)
        {
            DataTable dt = new DataTable();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = ftpServerDll.getCollectionDetailsById(db, FtpCollectionId);
                db.Stop();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool deleteFtpCollectionById(string FtpCollectionID)
        {
            bool st = false;
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                st = ftpServerDll.deleteFtpCollectionById(db, FtpCollectionID);
                db.Stop();
            }
            catch (Exception)
            {

                throw;
            }
            return st;
        }

        public bool UpdateFtpCollection(string FtpCollectionId)
        {
            bool status = false;
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                status = ftpServerDll.UpdateFtpCollection(db, this,FtpCollectionId);
                db.Stop();
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        public DataTable getLatestMovieCollection()
        {
            DataTable dt = new DataTable();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = ftpServerDll.getLatestMovieCollection(db);
                db.Stop();
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }

        public DataTable getFtpCollectionDeetailsById(string CollectionId)
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                dt = ftpServerDll.getCollectionDetailsById(db, CollectionId);
                db.Stop();
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }

        public DataTable getFtpCollectionByCottetion(string QueryString,int starPoint, int EndPoint)
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                dt = ftpServerDll.getFtpCollectionByCottetion(db, QueryString,starPoint,EndPoint);
                db.Stop();
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }

        public DataTable getSearchResult(string SearchString)
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                dt = ftpServerDll.getSearchResult(db, SearchString);
                db.Stop();
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }

        public int getRowNumberByCottetion(string Cottetion)
        {
            int Number = 0;
            DBplayer db = new DBplayer();
            ftpServerDLL ftpServerDll = new ftpServerDLL();
            try
            {
                db.Start();
                Number = ftpServerDll.getRowNumberByCottection(db,Cottetion);
                db.Stop();
            }
            catch(Exception)
            {
                throw;
            }
            return Number;
        }
    }
}
