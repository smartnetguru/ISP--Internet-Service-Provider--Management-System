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
    public class ChangeUserPassDLL
    {
        internal bool chkPreviousPass(DBplayer db, string PrePass, string id, string email)
        {
            bool st = false;
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@prePass", AppSupportLibraryManager.EncryptSHA1hash(PrePass.Trim()));
                db.AddParameters("@userId", id);
                db.AddParameters("@UserEmail", email.Trim());

                dt = db.ExecuteDataTable("CHECK_PREVIUOS_PASS_FOR_CHANGE_PASS", true);
                if (dt.Rows.Count > 0)
                {
                    st = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool changePassword(DBplayer db, ChangeUserPassBLL changeUserPassBLL, string id, string Email)
        {
            bool st = false;

            try
            {
                db.AddParameters("@NewPass", AppSupportLibraryManager.EncryptSHA1hash(changeUserPassBLL.newPass.Trim()));
                db.AddParameters("@userId", id);
                db.AddParameters("@UserEmail", Email.Trim());

               db.ExecuteNonQuery("CHANGE_USER_PASSWORD", true);
               st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool resetUserPass(DBplayer db, ChangeUserPassBLL changeUserPassBLL, string UniqueId, string ID, string Email)
        {
            bool st = false;

            try
            {
                DataTable dt = new DataTable();
                db.AddParameters("@UniqueId", UniqueId.Trim());
                db.AddParameters("@NewPass", AppSupportLibraryManager.EncryptSHA1hash(changeUserPassBLL.newPass.Trim()));
                db.AddParameters("@userId", ID);
                db.AddParameters("@UserEmail", Email.Trim());

                dt = db.ExecuteDataTable("RESET_USER_PASSWORD", true);

                if (dt.Rows[0]["IsPasswordChanged"].ToString() == "1")
                {
                    st = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
    }
}
