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
    public class BranchDLL
    {
        internal bool AddBranch(DBplayer db, BranchBLL branchBLL)
        {
            bool status = false;
            try
            {
                db.AddParameters("@branchName", branchBLL.BranchName.Trim());
                db.AddParameters("@branchAdd", branchBLL.BranchAdd.Trim());
                db.AddParameters("@branchCreatedDate",DateTime.ParseExact(branchBLL.branchCreatedDate.Trim(),"dd/MM/yyyy",null));
                db.AddParameters("@isActive", "No");
                db.AddParameters("@isDeleted", "No");
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@craetedForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@createdDate", DateTime.Today);

                db.ExecuteNonQuery("ADD_BRANCH", true);

                status = true;
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }

        internal DataTable GetAllBranchList(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataTable("GET_ALL_BRANCH_LIST", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //internal DataTable GetBranchDetailsById(DBplayer db, string branchId)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        db.AddParameters("@branchId", branchId.Trim());

        //        dt = db.ExecuteDataTable("GET_BRANCH_DETAILS_BY_ID", true);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return dt;
        //}

        internal bool UpdateBranchById(DBplayer db, string branchId,BranchBLL BranchBll)
        {
            bool st = false;
            try
            {
                db.AddParameters("@branchId", branchId.Trim());
                db.AddParameters("@branchName", BranchBll.BranchName.Trim());
                db.AddParameters("@branchAddress", BranchBll.BranchAdd.Trim());
                db.AddParameters("@branchCreatedDate", Convert.ToDateTime(BranchBll.branchCreatedDate.Trim()));

                db.ExecuteNonQuery("UPDATE_BRANCH_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool ActivateBranchById(DBplayer db, string branchId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@branchId", branchId.Trim());
               

                db.ExecuteNonQuery("ACTIVATE_BRANCH_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DectivateBranchById(DBplayer db, string branchId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@branchId", branchId.Trim());


                db.ExecuteNonQuery("DEACTIVATE_BRANCH_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeleteBranchById(DBplayer db, string branchId)
        {
            bool st = false;
            try
            {
                db.AddParameters("@branchId", branchId.Trim());


                db.ExecuteNonQuery("DELETE_BRANCH_BY_ID", true);

                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
    }
}
