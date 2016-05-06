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
    public class EditProfileDLL
    {
        internal bool updateUser(DBplayer db, EditProfileBLL editProfileBLL, string serial)
        {
            bool st = false;
            try
            {
                db.AddParameters("@Serial", Convert.ToInt32(serial));
                db.AddParameters("@Name", editProfileBLL.Name.Trim());
                //db.AddParameters("@Email", updateUserBLL.Email.Trim());
                db.AddParameters("@DOB", editProfileBLL.DOB);

                db.AddParameters("@Gender", editProfileBLL.Gender.Trim());
                db.AddParameters("@ContactNumber", editProfileBLL.ContactNumber.Trim());
                db.AddParameters("@Nationality", editProfileBLL.nationality.Trim());
                db.AddParameters("@BloodGroup", editProfileBLL.bloodGroup.Trim());
                db.AddParameters("@permanentAdd", editProfileBLL.perManentAdd.Trim());
                db.AddParameters("@presentAdd", editProfileBLL.presentAdd.Trim());
                db.AddParameters("@nationalID", editProfileBLL.NationalID.Trim());
                db.AddParameters("@profilePicName", editProfileBLL.profileImage.Trim());
                db.AddParameters("@FathersName", editProfileBLL.FathersName.Trim());
                db.AddParameters("@mothersName", editProfileBLL.motherName.Trim());



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
