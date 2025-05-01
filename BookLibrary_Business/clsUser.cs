using BookLibrary_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary_DataAccess;
using System.Data;

namespace BookLibrary_Business
{
    public class clsUser
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public byte isAdmin { get; set; }
        public int Permissions { get; set; }
        public string Password { get; set; }

        public clsPerson PersonInfo;
       
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Permissions = 0;
            this.Password = "";
            this.isAdmin = 0;
            this.Mode = _enMode.Add;
        }

        private clsUser(int UserID, int PersonID,string Username, byte isAdmin, int Permissions, string Password)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.Username = Username;
            this.Permissions = Permissions;
            this.Password = Password;
            this.isAdmin = isAdmin;
            this.Mode = _enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.Username,this.isAdmin, this.Permissions, this.Password);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.Username, this.isAdmin, this.Permissions, this.Password);
        }

        public static bool DeleteUser(int UserUserID)
        {
            return clsUserDataAccess.DeleteUser(UserUserID);
        }

        public static bool DeleteAdmin(int UserUserID)
        {
            return clsUserDataAccess.DeleteUser(UserUserID);
        }

        public static bool isUserExist(string Username)
        {
            return clsUserDataAccess.isUserExist(Username);
        }

        public static clsUser Find(int UserID)
        {
            string Username = "", Password = "";
            int PersonID = -1, Permissions = 0;
            byte isAdmin = 0;
           
            if (clsUserDataAccess.GetUserInfoByUserID(UserID, ref PersonID, ref Username, ref isAdmin, ref Permissions, ref Password))
                return new clsUser(UserID, PersonID, Username,isAdmin,  Permissions, Password);
            else
                return null;

        }

        public static clsUser Find(string Email,string Password)
        {
            string Username = "";
            byte isAdmin = 0;
            int UserID = 0, PersonID = 0, Permissions = 0;

            if (clsUserDataAccess.GetUserInfoByEmailAndPassword(Email,Password, ref UserID, ref PersonID, ref Username, ref isAdmin, ref Password))
                return new clsUser(UserID, PersonID, Username, isAdmin, Permissions, Password);
            else
                return null;

        }

        public static clsUser FindByUsernameAndPassword(string Username, string Password)
        {
           
            byte isAdmin = 0;
            int UserID = 0, PersonID = 0, Permissions = 0;

            if (clsUserDataAccess.GetUserInfoByUsernameAndPassword(Username, Password, ref UserID, ref PersonID, ref isAdmin,ref Permissions))
                return new clsUser(UserID, PersonID, Username, isAdmin, Permissions, Password);
            else
                return null;

        }


        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        return _AddNewUser();
                    }
                case _enMode.Update:
                    {
                        return _UpdateUser();
                    }

            }
            return false; // for handl just

        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static DataTable GetAllAdmins()
        {
            return clsUserDataAccess.GetAllAdmins();
        }



        public  DataTable GetAllUserBorrowedBooks()
        {
            return clsBookDataAccess.GetAllUserBorrowedBooks(this.UserID);
        }

        public static DataTable GetAllUserMetaphors(int UserID)
        {
            return clsUserDataAccess.GetAllUserMetaphors(UserID);
        }
        public  DataTable GetAllUserMetaphors()
        {
            return clsUserDataAccess.GetAllUserMetaphors(this.UserID);
        }

    }
}
