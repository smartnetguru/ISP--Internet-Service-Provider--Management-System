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
   public class PackageDLL
    {

        internal bool addPackageInfo(DBplayer db, PackageBLL packageBLL)
        {
            bool st = false;
            try
            {
                db.AddParameters("@packageName",packageBLL.packageName.Trim());
                db.AddParameters("@packagePrice",packageBLL.packagePrice);
                db.AddParameters("@packageMinSpd",packageBLL.packageMinSpeed);
                db.AddParameters("@packageMaxSpd",packageBLL.packageMaxSpeed);
                db.AddParameters("@youtubeSpeed",packageBLL.YoutubeSpeed);
                db.AddParameters("@starNetworkFtpSpd",packageBLL.starNetWorkFtp);
                db.AddParameters("@otherFtpSpd",packageBLL.otherFtp);
                db.AddParameters("@bdixSpd",packageBLL.BdixSpd);
                db.AddParameters("@RealIp",packageBLL.realIp.Trim());
                db.AddParameters("@IsActive","No");
                db.AddParameters("@IsDeleted","No");
                db.AddParameters("@createdBy",AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdFrom",AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate",DateTime.Today);
                db.AddParameters("@BranchId", packageBLL.branch.Trim());

                db.ExecuteNonQuery("ADD_PACKAGE_INFO", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getAllPackageList(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_ALL_PACKAGE_LIST",true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool activaePackageById(DBplayer db, string packageId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@packageId", packageId.Trim());
                db.ExecuteNonQuery("ACTIVATE_PACKAGE_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeactivaePackageById(DBplayer db, string packageId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@packageId", packageId.Trim());
                db.ExecuteNonQuery("DEACTIVATE_PACKAGE_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeletePackageById(DBplayer db, string packageId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@packageId", packageId.Trim());
                db.ExecuteNonQuery("DELETE_PACKAGE_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable getallpackageListforView(DBplayer db,string branchId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@branchId", branchId.Trim());
                dt = db.ExecuteDataTable("GET_PACKAGELIST_WITH_DETAILS",true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable getPackageDetails(string packageId, DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@PackageId", packageId.Trim());
                dt = db.ExecuteDataTable("GET_PACKAGE_DETAILS_BY_ID", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool updatePackageInfo(DBplayer db, PackageBLL packageBLL, string packageId)
        {

            bool st = false;
            try
            {
                db.AddParameters("@PackageId", packageId.Trim());
                db.AddParameters("@packageName", packageBLL.packageName.Trim());
                db.AddParameters("@packagePrice", packageBLL.packagePrice);
                db.AddParameters("@packageMinSpd", packageBLL.packageMinSpeed);
                db.AddParameters("@packageMaxSpd", packageBLL.packageMaxSpeed);
                db.AddParameters("@youtubeSpeed", packageBLL.YoutubeSpeed);
                db.AddParameters("@starNetworkFtpSpd", packageBLL.starNetWorkFtp);
                db.AddParameters("@otherFtpSpd", packageBLL.otherFtp);
                db.AddParameters("@bdixSpd", packageBLL.BdixSpd);
                db.AddParameters("@RealIp", packageBLL.realIp.Trim());
                db.AddParameters("@branchId", packageBLL.branch.Trim());
                

                db.ExecuteNonQuery("UPDATE_PACKAGE_INFO", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal DataTable loadBranch(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("LOAD_BRANCH_LIST", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable loadPackage(DBplayer db,string branchId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@BranchId", branchId.Trim());
                dt = db.ExecuteDataTable("LOAD_PACKAGE_BY_BRANCH_ID", true);
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }
    }
}
