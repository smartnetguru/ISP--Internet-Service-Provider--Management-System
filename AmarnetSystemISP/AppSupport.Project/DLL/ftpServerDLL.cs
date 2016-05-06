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
    public class ftpServerDLL
    {
        internal bool addOnlineTvServer(DBplayer db, ftpServerBLL ftpServerBll)
        {
            bool st = false;
            try
            {
                db.AddParameters("@FtpServerName", ftpServerBll.onlineTvName.Trim());
                db.AddParameters("@FtpServerLink", ftpServerBll.onlineTvServerLInk.Trim());
                db.AddParameters("@FtpServerImage", ftpServerBll.imageName.Trim());
                db.AddParameters("@isActive", "No");
                db.AddParameters("@isDeleted", "No");
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate", DateTime.Today);

                db.ExecuteNonQuery("ADD_FTP_SERVER", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool UpdateOnlineTvServerByID(DBplayer db, ftpServerBLL ftpServerBll, string OnlienTvServerId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@ftpServerId", OnlienTvServerId.Trim());
                db.AddParameters("@FtpServerName", ftpServerBll.onlineTvName.Trim());
                db.AddParameters("@FtpServerLink", ftpServerBll.onlineTvServerLInk.Trim());
                db.AddParameters("@FtpServerImage", ftpServerBll.imageName.Trim());

                db.ExecuteNonQuery("UPDATE_FTP_SERVER", true);

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
                dt = db.ExecuteDataTable("GET_FTP_SERVER_LIST", true);

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
                db.AddParameters("@fptServerId", OnlineTvserverId.Trim());

                dt = db.ExecuteDataTable("GET_FTP_SERVER_DETAILS_BY_ID", true);
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
                db.AddParameters("@fptServerId", onlineTvServerId.Trim());

                db.ExecuteNonQuery("ACTIVATE_FTP_SERVER_BY_ID", true);

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
                db.AddParameters("@fptServerId", OnlineTvServerId.Trim());

                db.ExecuteNonQuery("DEACTIVATE_FTP_SERVER_BY_ID", true);

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
                db.AddParameters("@fptServerId", onlineTvServerId.Trim());

                db.ExecuteNonQuery("DELETEE_FTP_SERVER_BY_ID", true);

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
                dt = db.ExecuteDataTable("GET_ALL_FTP_SERVER_LIST_FOR_VIEW");
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool saveFtpCollection(DBplayer db, ftpServerBLL ftpServerBLL)
        {
            bool status = false;
            try
            {
                db.AddParameters("@FTPcollectionParentCatagory", ftpServerBLL.parentCatagory.Trim());
                db.AddParameters("@FTPcollectionChildCatagory", ftpServerBLL.childCatagory.Trim());
                db.AddParameters("@FTPcollectionTitle", ftpServerBLL.ftpcollectionTitle.Trim());
                db.AddParameters("@FTPcollectionDescription", ftpServerBLL.ftpcollectionDescription.Trim());
                db.AddParameters("@FTPip", ftpServerBLL.ftpIp.Trim());
                db.AddParameters("@ftpCollectionLink", ftpServerBLL.ftpMovieLocation.Trim());
                db.AddParameters("@FTPcollectionImageName", ftpServerBLL.ftpCollectionImageName.Trim());
                db.AddParameters("@FTPcollectionFullLink", ftpServerBLL.ftpMovieFullLink.Trim());
                db.AddParameters("@CreatedBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@CreatedForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@CreatedDate", DateTime.Today);

                db.ExecuteNonQuery("SAVE_FTP_COLLECTION", true);
                status = true;
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        internal DataTable getcollectionListByParentAndChildCatagory(DBplayer db, string ParentCatagory, string ChildCatagory)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@ParentCatagory", ParentCatagory.Trim());
                db.AddParameters("@ChildCatagory", ChildCatagory.Trim());

                dt = db.ExecuteDataTable("GET_FTP_COLLECTION_LIST_BY_PARENT_AND_CHILD_CATAGORY", true);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        internal DataTable getCollectionDetailsById(DBplayer db, string FtpCollectionId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@ftpCollectionId", FtpCollectionId.Trim());

                dt = db.ExecuteDataTable("GET_FTP_COLLECTION_DETAILS_BY_ID", true);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        internal bool deleteFtpCollectionById(DBplayer db, string FtpCollectionID)
        {
            bool st = false;
            try
            {
                db.AddParameters("@ftpCollectionId", FtpCollectionID.Trim());

                db.ExecuteNonQuery("DELETE_FTP_COLLECTION_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {

                throw;
            }
            return st;
        }

        internal bool UpdateFtpCollection(DBplayer db, ftpServerBLL ftpServerBLL, string FtpCollectionId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@FtpCollectionId", FtpCollectionId.Trim());
                db.AddParameters("@FTPcollectionParentCatagory", ftpServerBLL.parentCatagory.Trim());
                db.AddParameters("@FTPcollectionChildCatagory", ftpServerBLL.childCatagory.Trim());
                db.AddParameters("@FTPcollectionTitle", ftpServerBLL.ftpcollectionTitle.Trim());
                db.AddParameters("@FTPcollectionDescription", ftpServerBLL.ftpcollectionDescription.Trim());
                db.AddParameters("@FTPip", ftpServerBLL.ftpIp.Trim());
                db.AddParameters("@ftpCollectionLink", ftpServerBLL.ftpMovieLocation.Trim());
                db.AddParameters("@FTPcollectionImageName", ftpServerBLL.ftpCollectionImageName.Trim());
                db.AddParameters("@FTPcollectionFullLink", ftpServerBLL.ftpMovieFullLink.Trim());

                db.ExecuteNonQuery("UPDATE_FTP_COLLECTION_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {

                throw;
            }
            return st;
        }

        internal DataTable getLatestMovieCollection(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                string Query_Command = "select top (20) * from FTPcollection where FTPcollectionParentCatagory='Movie' and IsActive='Yes' and IsDeleted='No' order by FTPcollectionId DESC";

                dt = db.ExecuteDataTable(Query_Command);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        internal DataTable getFtpCollectionByCottetion(DBplayer db, string QueryString, int starPoint, int EndPoint)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@Cottection", QueryString.Trim());
                db.AddParameters("@startPoint", starPoint);
                db.AddParameters("@endPoint", EndPoint);

                dt = db.ExecuteDataTable("GET_FTP_COLLECTION_LIST_BY_COTTETION", true);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        internal DataTable getSearchResult(DBplayer db, string SearchString)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@SearchString", SearchString.Trim());

                dt = db.ExecuteDataTable("GET_FTP_COLLECTION_SEARCH_LIST_BY_SEARCH_STRING", true);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        internal int getRowNumberByCottection(DBplayer db, string Cottetion)
        {
            int number = 0;
            try
            {
                DataTable dt = new DataTable();
                db.AddParameters("@Cottection", Cottetion);
                dt = db.ExecuteDataTable("GET_ROW_COUNT_BY_COTTECTION", true);
                if(dt.Rows.Count>0)
                {
                    number = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            return number;
        }
    }
}
