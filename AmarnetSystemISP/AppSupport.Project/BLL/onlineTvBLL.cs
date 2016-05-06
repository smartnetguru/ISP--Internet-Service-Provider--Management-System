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
    public class onlineTvBLL
    {
        public string onlineTvName { get; set; }

        public string onlineTvServerLInk { get; set; }

        public string imageName { get; set; }

        public bool addOnlineTvServer()
        {
            bool st = false;
            onlineTvDLL onlineTvDll = new  onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = onlineTvDll.addOnlineTvServer(db, this);
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
            onlineTvDLL onlienTvDll = new onlineTvDLL();
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
            onlineTvDLL onlineTvDll = new onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = onlineTvDll.getOnlineTvServerList(db);
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
            onlineTvDLL onlineTvDll = new onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = onlineTvDll.EditOnlineTvServerDetailsById(db, OnlineTvserverId);
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
            onlineTvDLL onlineTvDll = new onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = onlineTvDll.ActivateOnlineTvServer(db, onlineTvServerId);
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
            onlineTvDLL onlienTvDll = new onlineTvDLL();
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
            onlineTvDLL onlineTvDll = new onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = onlineTvDll.deleteOnlineTvServerById(db, onlineTvServerId);
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
            onlineTvDLL onlineTvServerDll = new onlineTvDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = onlineTvServerDll.getOnlineTvServerListForView(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
