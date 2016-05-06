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
   public class TorrentBLL
    {
        public bool addTorrentServer()
        {
            bool st = false;
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = torrentDll.addTorrentServer(db,this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public string torrentServerName { get; set; }

        public string torrentServerLInk { get; set; }

        public string imageName { get; set; }

        public DataTable getTorrentServerList()
        {
            DataTable dt = new DataTable();
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = torrentDll.getTorrentServerList(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable EditTorrentById(string TorrentserverId)
        {
            DataTable dt = new DataTable();
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = torrentDll.GetDetailsById(db,TorrentserverId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool updateTorrentserver(string TorrentServerId)
        {
            bool st = false;
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = torrentDll.UpdateTorrentServer(db, this,TorrentServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeactivateTorrentById(string torrentServerId)
        {
            bool st = false;
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = torrentDll.DeactivateTorrent(db, torrentServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool activateTorrentById(string torrentServerId)
        {
            bool st = false;
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = torrentDll.ActivateTorrent(db,torrentServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeleteTorrentById(string torrentServerId)
        {
            bool st = false;
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = torrentDll.deleteTorrentById(db, torrentServerId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable getTorrentServerListForView()
        {
            DataTable dt = new DataTable();
            TorrentDLL torrentDll = new TorrentDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = torrentDll.getTorrentServerListForView(db);
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
