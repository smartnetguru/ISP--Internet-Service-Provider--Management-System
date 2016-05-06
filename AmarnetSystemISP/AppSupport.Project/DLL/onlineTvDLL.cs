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
   public class onlineTvDLL
    {
        internal bool addOnlineTvServer(DBplayer db, onlineTvBLL onlineTvBLL)
        {
            bool st = false;
            try
            {
                db.AddParameters("@onlineTvServerName", onlineTvBLL.onlineTvName.Trim());
                db.AddParameters("@onlineTvServerLink", onlineTvBLL.onlineTvServerLInk.Trim());
                db.AddParameters("@onlineTvServerImage", onlineTvBLL.imageName.Trim());
                db.AddParameters("@isActive", "No");
                db.AddParameters("@isDeleted", "No");
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate", DateTime.Today);

                db.ExecuteNonQuery("ADD_ONLINE_TV_SERVER", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool UpdateOnlineTvServerByID(DBplayer db, onlineTvBLL onlineTvBLL, string OnlienTvServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@onlineTvserverId", OnlienTvServerId.Trim());
                db.AddParameters("@onlineTvServerName", onlineTvBLL.onlineTvName.Trim());
                db.AddParameters("@onlineTvServerLink", onlineTvBLL.onlineTvServerLInk.Trim());
                db.AddParameters("@onlineTvServerImage", onlineTvBLL.imageName.Trim());

                db.ExecuteNonQuery("UPDATE_ONLINE_TV_SERVER", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getOnlineTvServerList(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_ONLINE_TV_SERVER_LIST", true);

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable EditOnlineTvServerDetailsById(DBplayer db, string OnlineTvserverId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@onlineTvServerId", OnlineTvserverId.Trim());

                dt = db.ExecuteDataTable("GET_ONLINE_TV_SERVER_DETAILS_BY_ID", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool ActivateOnlineTvServer(DBplayer db, string onlineTvServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@onlineTvServerId", onlineTvServerId.Trim());

                db.ExecuteNonQuery("ACTIVATE_ONLINE_TV_SERVER_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeactivateOnlineTvServer(DBplayer db, string OnlineTvServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@onlineTvServerId", OnlineTvServerId.Trim());

                db.ExecuteNonQuery("DEACTIVATE_ONLINE_TV_SERVER_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool deleteOnlineTvServerById(DBplayer db, string onlineTvServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@onlineTvServerId", onlineTvServerId.Trim());

                db.ExecuteNonQuery("DELETEE_ONLINE_TV_SERVER_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getOnlineTvServerListForView(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_ALL_ONLINE_TV_SERVER_LIST_FOR_VIEW");
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
