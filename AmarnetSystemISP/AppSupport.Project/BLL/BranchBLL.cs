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
    public class BranchBLL
    {
        public string BranchName { get; set; }

        public string BranchAdd { get; set; }

        public string branchCreatedDate { get; set; }

        public bool AddBranch()
        {
            bool st = false;
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = branchDll.AddBranch(db, this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable GetAllBranchList()
        {
            DataTable dt = new DataTable();
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = branchDll.GetAllBranchList(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //public DataTable GetBranchDetailsById(string branchId)
        //{
        //    DataTable dt = new DataTable();
        //    BranchDLL branchDll = new BranchDLL();
        //    DBplayer db = new DBplayer();

        //    try
        //    {
        //        db.Start();
        //        dt = branchDll.GetBranchDetailsById(db, branchId);
        //        db.Stop();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return dt;
        //}

        public bool UpdateBranch(string branchId)
        {
            bool st = false;
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = branchDll.UpdateBranchById(db, branchId,this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool ActivateBranchById(string branchId)
        {
            bool st = false;
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = branchDll.ActivateBranchById(db, branchId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DectivateBranchById(string branchId)
        {
            bool st = false;
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = branchDll.DectivateBranchById(db, branchId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool DeleteBranchById(string branchId)
        {
            bool st = false;
            BranchDLL branchDll = new BranchDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = branchDll.DeleteBranchById(db, branchId);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
    }
}
