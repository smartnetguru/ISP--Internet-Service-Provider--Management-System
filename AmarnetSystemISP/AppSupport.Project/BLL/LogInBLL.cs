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
    public class LogInBLL
    {
      

        public string userEmail { get; set; }

        public string passWord { get; set; }

        public DataTable userLogin()
        {
            LogInDLL loginDll = new LogInDLL();
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = loginDll.userLogIn(db, this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public string ResetUserEmail { get; set; }

        public DataTable getUniqueIdForSendEmail()
        {
            LogInDLL loginDll = new LogInDLL();
            DataTable dt = new DataTable();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = loginDll.GetUniqueIdForSendEmail(db,this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable ChkvalidityOfUniqueId(string ID)
        {
            DataTable dt = new DataTable();
            try
            {
                LogInDLL loginDll = new LogInDLL();
                DBplayer db = new DBplayer();

                db.Start();
                dt = loginDll.chkValidityOfUniqueId(db, ID);
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
