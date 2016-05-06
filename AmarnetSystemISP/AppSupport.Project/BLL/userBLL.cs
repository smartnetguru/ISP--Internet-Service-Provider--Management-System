﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppSupport.Tech;
using AppSupport.Project.DLL;

namespace AppSupport.Project.BLL
{
    public class userBLL
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DOB { get; set; }

        public string ContactNumber { get; set; }

        public string Gender { get; set; }

        public string bloodGroup { get; set; }

        public string nationality { get; set; }

        public string NationalID { get; set; }

        public string perManentAdd { get; set; }

        public string presentAdd { get; set; }

        public string FathersName { get; set; }

        public string motherName { get; set; }

        public string password { get; set; }

        public string userRole { get; set; }

        public bool SaveUser()
        {
            bool st = false;
           userDLL createuserDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = createuserDll.SaveUser(db, this);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }

        public DataTable CheckDuplicateEmail(string Email)
        {
            DataTable dt = new DataTable();
            userDLL createUserDll = new userDLL();
            try
            {
                DBplayer db = new DBplayer();
                db.Start();
                dt = createUserDll.CheckDuplicateEmail(Email, db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public string profileImage { get; set; }

        public DataTable getALLUserListbyType()
        {
            DataTable dt = new DataTable();
            userDLL userlistDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = userlistDll.getALLUserByType(db);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        public DataTable getUserListbyType(string type)
        {
            DataTable dt = new DataTable();
            userDLL userlistDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {

                db.Start();
                dt = userlistDll.getUserByType(db, type);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        public bool ActiveUser(string serial)
        {
            bool st = false;
            userDLL userlistDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = userlistDll.ActiveUser(db, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        public bool DeactivateUser(string serial)
        {
            bool st = false;
            userDLL userlistDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = userlistDll.DeactivateUser(db, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        public bool DeleteUser(string serial)
        {
            bool st = false;
            userDLL userlistDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = userlistDll.deleteUser(db, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        public DataTable getUserByID(string serial)
        {
            DataTable dt = new DataTable();
            userDLL updateUserDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = updateUserDll.getUserByID(db, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool UpdateUser(string serial)
        {
            bool st = false;
            userDLL updateuserDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = updateuserDll.updateUser(db, this, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
             public bool UpdateUserProfile(string serial)
        {
            bool st = false;
            userDLL updateuserDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                st = updateuserDll.updateUserProfile(db, this, serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return st;
        }
        public DataTable getUserDetailsbyID(string Serial)
        {
            DataTable dt = new DataTable();
            userDLL userViewDll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {

                db.Start();
                dt = userViewDll.getUserDetailByID(db, Serial);
                db.Stop();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable loadUserGroup()
        {
            DataTable dt = new DataTable();
            userDLL userdll = new userDLL();
            DBplayer db = new DBplayer();
            try
            {
                db.Start();
                dt = userdll.loadUserGroup(db);
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
