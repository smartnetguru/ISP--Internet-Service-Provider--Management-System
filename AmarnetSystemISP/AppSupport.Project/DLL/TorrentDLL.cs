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
   public class TorrentDLL
    {
        internal bool addTorrentServer(DBplayer db, TorrentBLL torrentBLL)
        {
            bool st = false;
            try
            {
              
                db.AddParameters("@torrentServerName", torrentBLL.torrentServerName.Trim());
                db.AddParameters("@torrentServerLink", torrentBLL.torrentServerLInk.Trim());
                db.AddParameters("@torrentImage", torrentBLL.imageName.Trim());
                db.AddParameters("@IsActive", "No");
                db.AddParameters("@IsDeleted", "No");
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate", DateTime.Today);

                db.ExecuteDataTable("ADD_TORRENT_SERVER", true);

                st = true;
               
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getTorrentServerList(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_TTORRENT_SERVER_LIST");
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable GetDetailsById(DBplayer db, string TorrentserverId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@torrentServerId", TorrentserverId.Trim());
                dt = db.ExecuteDataTable("GET_TORRENT_DETAILS_BY_ID",true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool UpdateTorrentServer(DBplayer db, TorrentBLL torrentBLL, string TorrentServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@torrentServerId", TorrentServerId.Trim());
                db.AddParameters("@torrentServerName", torrentBLL.torrentServerName.Trim());
                db.AddParameters("@torrentServerLink", torrentBLL.torrentServerLInk.Trim());
                db.AddParameters("@torrentImage", torrentBLL.imageName.Trim());

                db.ExecuteDataTable("UPDATE_TORRENT_SERVER_BY_ID", true);

                st = true;

            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool ActivateTorrent(DBplayer db, string torrentServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@torrentServerId", torrentServerId.Trim());
                db.ExecuteNonQuery("ACTIVATE_TORRENT_SERVER_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeactivateTorrent(DBplayer db, string torrentServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@torrentServerId", torrentServerId.Trim());
                db.ExecuteNonQuery("DEACTIVATE_TORRENT_SERVER_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool deleteTorrentById(DBplayer db, string torrentServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@torrentServerId", torrentServerId.Trim());
                db.ExecuteNonQuery("DELETE_TORRENT_SERVER_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getTorrentServerListForView(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_TTORRENT_SERVER_LIST_FOR_VIEW");
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
