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
    public class userDLL
    {
        internal DataTable CheckDuplicateEmail(string Email, DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@Email", Email.Trim());
                dt = db.ExecuteDataTable("DUPLICATE_EMAIL", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool SaveUser(DBplayer db, userBLL createUserBLL)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Name", createUserBLL.Name.Trim());
                db.AddParameters("@Email", createUserBLL.Email.Trim());
                db.AddParameters("@DOB", createUserBLL.DOB);
                db.AddParameters("@Password", AppSupportLibraryManager.EncryptSHA1hash(createUserBLL.password.Trim()));
                db.AddParameters("@Gender", createUserBLL.Gender.Trim());
                db.AddParameters("@ContactNumber", createUserBLL.ContactNumber.Trim());
                db.AddParameters("@Nationality", createUserBLL.nationality.Trim());
                db.AddParameters("@BloodGroup", createUserBLL.bloodGroup.Trim());
                db.AddParameters("@permanentAdd", createUserBLL.perManentAdd.Trim());
                db.AddParameters("@presentAdd", createUserBLL.presentAdd.Trim());
                db.AddParameters("@nationalID", createUserBLL.NationalID.Trim());
                db.AddParameters("@profilePicName", createUserBLL.profileImage.Trim());
                db.AddParameters("@FathersName", createUserBLL.FathersName.Trim());
                db.AddParameters("@mothersName", createUserBLL.motherName.Trim());
                db.AddParameters("@userRole", createUserBLL.userRole.Trim());
                db.AddParameters("@isActive", "No");
                db.AddParameters("@createdBy", AppSupportSessionManager.Get("UserId").ToString());
                db.AddParameters("@createdDate", DateTime.Today);
                db.AddParameters("@createdFrom", AppSupportLibraryManager.Terminal());
                db.AddParameters("@isDeleted", "No");

                //st = Convert.ToBoolean(db.ExecuteNonQuery("CREATE_USER", true));
                db.ExecuteDataTable("CREATE_USER", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        internal DataTable getUserByType(DBplayer db, string type)
        {
            DataTable dt = new DataTable();

            try
            {
                db.AddParameters("@type", type.Trim());

                dt = db.ExecuteDataTable("GET_USER_LIST_TYPE_WISE", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        internal DataTable getALLUserByType(DBplayer db)
        {
            DataTable dt = new DataTable();

            try
            {
                string command = "select * from users";

                dt = db.ExecuteDataTable(command);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool ActiveUser(DBplayer db, string serial)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Serial", serial.Trim());

                db.ExecuteNonQuery("ACTIVATE_USER_BY_SERAL", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool DeactivateUser(DBplayer db, string serial)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Serial", serial.Trim());
                db.ExecuteNonQuery("DEACTIVATE_USER_BY_SERAL", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        internal bool deleteUser(DBplayer db, string serial)
        {
            bool st = false;
            try
            {
                string Command_Query = "update users set isDeleted='Yes',isActive='No' where Serial=@serial";
                db.AddParameters("@serial", serial.Trim());
                db.ExecuteNonQuery(Command_Query);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        internal DataTable getUserByID(DBplayer db, string serial)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@serial", serial.Trim());
                dt = db.ExecuteDataTable("GET_USER_BY_ID", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        internal bool updateUser(DBplayer db, userBLL updateUserBLL, string serial)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Serial",serial.Trim());
                db.AddParameters("@Name", updateUserBLL.Name.Trim());
                //db.AddParameters("@Email", updateUserBLL.Email.Trim());
                db.AddParameters("@DOB", updateUserBLL.DOB);

                db.AddParameters("@Gender", updateUserBLL.Gender.Trim());
                db.AddParameters("@ContactNumber", updateUserBLL.ContactNumber.Trim());
                db.AddParameters("@Nationality", updateUserBLL.nationality.Trim());
                db.AddParameters("@BloodGroup", updateUserBLL.bloodGroup.Trim());
                db.AddParameters("@permanentAdd", updateUserBLL.perManentAdd.Trim());
                db.AddParameters("@presentAdd", updateUserBLL.presentAdd.Trim());
                db.AddParameters("@nationalID", updateUserBLL.NationalID.Trim());
                db.AddParameters("@profilePicName", updateUserBLL.profileImage.Trim());
                db.AddParameters("@FathersName", updateUserBLL.FathersName.Trim());
                db.AddParameters("@mothersName", updateUserBLL.motherName.Trim());
                db.AddParameters("@userRole", updateUserBLL.userRole.Trim());


                db.ExecuteDataTable("UPDATE_USER_BY_ID", true);
                st = true;
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        internal DataTable getUserDetailByID(DBplayer db, string Serial)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AddParameters("@Serial", Serial.Trim());

                dt = db.ExecuteDataTable("GET_USER_BY_ID", true);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;

        }

        internal DataTable loadUserGroup(DBplayer db)
        {
            DataTable dt = new DataTable();
            try
            {
                string Query_Command = "select UserGroupName,UserGroupId from UserGroup where IsActive='Yes' and IsDeleted='No'";
                dt = db.ExecuteDataTable(Query_Command);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        internal bool updateUserProfile(DBplayer db, userBLL updateUserBLL, string serial)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Serial", serial.Trim());
                db.AddParameters("@Name", updateUserBLL.Name.Trim());
                //db.AddParameters("@Email", updateUserBLL.Email.Trim());
                db.AddParameters("@DOB", updateUserBLL.DOB);

                db.AddParameters("@Gender", updateUserBLL.Gender.Trim());
                db.AddParameters("@ContactNumber", updateUserBLL.ContactNumber.Trim());
                db.AddParameters("@Nationality", updateUserBLL.nationality.Trim());
                db.AddParameters("@BloodGroup", updateUserBLL.bloodGroup.Trim());
                db.AddParameters("@permanentAdd", updateUserBLL.perManentAdd.Trim());
                db.AddParameters("@presentAdd", updateUserBLL.presentAdd.Trim());
                db.AddParameters("@nationalID", updateUserBLL.NationalID.Trim());
                db.AddParameters("@profilePicName", updateUserBLL.profileImage.Trim());
                db.AddParameters("@FathersName", updateUserBLL.FathersName.Trim());
                db.AddParameters("@mothersName", updateUserBLL.motherName.Trim());



                db.ExecuteDataTable("UPDATE_USER_PROFILE_BY_ID", true);
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
