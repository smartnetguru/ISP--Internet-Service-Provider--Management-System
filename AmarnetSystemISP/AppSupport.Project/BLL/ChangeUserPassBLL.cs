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
   public class ChangeUserPassBLL
    {
        public string newPass { get; set; }

        public bool checkPreviousPass(string PrePass,string id,string Email)
        {
            bool st = false;
            ChangeUserPassDLL changeUserPassDll = new ChangeUserPassDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = changeUserPassDll.chkPreviousPass(db, PrePass,id,Email);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool ChangeUserPass(string id, string Email)
        {
            bool st = false;
            ChangeUserPassDLL changeUserPassDll = new ChangeUserPassDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = changeUserPassDll.changePassword(db,this, id, Email);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public bool resetUserPss(string UniqueId, string ID, string Email)
        {
            bool st = false;
            ChangeUserPassDLL changeUserPassDll = new ChangeUserPassDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = changeUserPassDll.resetUserPass(db, this, UniqueId, ID, Email);
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
