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
    public class LogInDLL
    {
        internal DataTable userLogIn(DBplayer db, LogInBLL logInBLL)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@email", logInBLL.userEmail.Trim());
                db.AddParameters("@pass", AppSupportLibraryManager.EncryptSHA1hash(logInBLL.passWord.Trim()));

                dt = db.ExecuteDataTable("USER_LOGIN", true);

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable GetUniqueIdForSendEmail(DBplayer db,LogInBLL loginBll)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@userEmail", loginBll.ResetUserEmail.Trim());
                db.AddParameters("@requestedForm", AppSupportLibraryManager.Terminal());
                db.AddParameters("@RequestedDate", DateTime.Today);

                dt = db.ExecuteDataTable("CREATE_RESET_PASS_LINK", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal DataTable chkValidityOfUniqueId(DBplayer db, string ID)
        {
            DataTable dt = new DataTable();
            try
            {
               
                db.AddParameters("@uniqueId", ID.Trim());

                dt = db.ExecuteDataTable("CHK_VALIDITY_OF_RESET_PASS_LINK", true);

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
