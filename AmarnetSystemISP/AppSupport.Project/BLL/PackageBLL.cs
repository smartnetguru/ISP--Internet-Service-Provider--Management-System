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
    public class PackageBLL
    {
        public string packageName { get; set; }

        public decimal packagePrice { get; set; }

        public decimal packageMinSpeed { get; set; }

        public decimal packageMaxSpeed { get; set; }

        public decimal YoutubeSpeed { get; set; }

        public decimal starNetWorkFtp { get; set; }

        public decimal otherFtp { get; set; }

        public decimal BdixSpd { get; set; }

        public string realIp { get; set; }

        public bool addPackageInfo()
        {
            bool status = false;
            PackageDLL packageDll = new PackageDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                status = packageDll.addPackageInfo(db,this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }

        public DataTable getAllPackageList()
        {
            DataTable dt = new DataTable();
            try
            {
                PackageDLL packageDll = new PackageDLL();
                DBplayer db = new DBplayer();
                db.Start();
                dt = packageDll.getAllPackageList(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool activePackageById(string packageId)
        {
            bool st = false;
            try
            {
                PackageDLL packageDll = new PackageDLL();
                DBplayer db = new DBplayer();
                db.Start();
                st = packageDll.activaePackageById(db,packageId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeactivePackageById(string packageId)
        {
            bool st = false;
            try
            {
                PackageDLL packageDll = new PackageDLL();
                DBplayer db = new DBplayer();
                db.Start();
                st = packageDll.DeactivaePackageById(db, packageId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DetelePackageById(string packageId)
        {
            bool st = false;
            try
            {
                PackageDLL packageDll = new PackageDLL();
                DBplayer db = new DBplayer();
                db.Start();
                st = packageDll.DeletePackageById(db, packageId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable getAllpackageforView(string branchId)
        {
            DataTable dt = new DataTable();
            PackageDLL packageDll = new PackageDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = packageDll.getallpackageListforView(db, branchId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable getPackageDetails(string packageId)
        {
            DataTable dt = new DataTable();
            PackageDLL packageDll = new PackageDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = packageDll.getPackageDetails(packageId, db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool updatePackageInfoById(string packageId)
        {
            bool status = false;
            PackageDLL packageDll = new PackageDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                status = packageDll.updatePackageInfo(db, this,packageId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }

        public string branch { get; set; }

        public DataTable loadBranch()
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            PackageDLL packageDll = new PackageDLL();
            try
            {
                db.Start();
                dt = packageDll.loadBranch(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable LoadPackage(string branchId)
        {
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            PackageDLL packageDll = new PackageDLL();
            try
            {
                db.Start();
                dt = packageDll.loadPackage(db,branchId);
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
