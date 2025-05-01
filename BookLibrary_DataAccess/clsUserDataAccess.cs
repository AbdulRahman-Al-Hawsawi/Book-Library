using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace BookLibrary_DataAccess
{
   public class clsUserDataAccess
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string Username, ref byte isAdmin, ref int Permissions, ref string Password)
        {
           
            bool IsFound = false;
           
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Users where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                       SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    Username = Convert.ToString(reader["Username"]);
                    isAdmin = Convert.ToByte(reader["isAdmin"]);
                    Permissions = Convert.ToInt32(reader["Permissions"]);
                    Password = Convert.ToString(reader["Password"]);
                   
                }
                else
                {
                    IsFound = false;
                }

                     reader.Close();

                    }

                }
            }
            catch (Exception e)
            {
                IsFound = false;
            }
           
            return IsFound;

        }


        public static bool GetUserInfoByEmailAndPassword(string Email, string Password, ref int UserID, ref int PersonID, ref string Username, ref byte isAdmin, ref string phone)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Users where Email = @Email and Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password", Password);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            Username = Convert.ToString(reader["Username"]);
                            isAdmin = Convert.ToByte(reader["isAdmin"]);
                            UserID = Convert.ToInt32(reader["UserID"]);
                            //Password = Convert.ToString(reader["Password"]);

                        }
                        else
                        {
                            IsFound = false;
                        }

                        reader.Close();

                    }

                }
            }
            catch (Exception e)
            {
                IsFound = false;
                string msg = e.Message;
            }

            return IsFound;

        }

         public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int UserID, ref int PersonID,  ref byte isAdmin,ref int Permissions)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Users where Username = @Username and Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            Permissions = Convert.ToInt32(reader["Permissions"]);
                            isAdmin = Convert.ToByte(reader["isAdmin"]);
                            UserID = Convert.ToInt32(reader["UserID"]);
                           

                        }
                        else
                        {
                            IsFound = false;
                        }

                        reader.Close();

                    }

                }
            }
            catch (Exception e)
            {
                IsFound = false;
                string msg = e.Message;
            }

            return IsFound;

        }

        public static int AddNewUser(int PersonID, string Username, byte isAdmin, int Permissions, string Password)
        {

            int UsertID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO [dbo].[Users] ([PersonID],[Username],[isAdmin],[Password],[Permissions])VALUES (@PersonID,@Username,@isAdmin,@Password,@Permissions); select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@isAdmin", isAdmin);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Permissions", Permissions);

                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            UsertID = InsertedID;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return UsertID;

        }

        public static bool UpdateUser(int UserID,int PersonID, string Username, byte isAdmin, int Permissions, string Password)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Update[dbo].[Users] set PersonID = @PersonID,Username = @Username,isAdmin = @isAdmin,Permissions = @Permissions,Password = @Password Where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Permissions", Permissions);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@isAdmin", isAdmin);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");
                return false;
            }
           
            return (rowsAffected > 0);
        }

        
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete Users where UserID =  @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");
                return false;
            }        
            return (rowsAffected > 0);

        }

        public static bool DeleteAdmin(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete Users where UserID =  @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");
                return false;
            }
            return (rowsAffected > 0);

        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Users where IsAdmin =0 and IsActive = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
             return dt;

        }

        public static DataTable GetAllAdmins()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Users where IsAdmin = 1 and IsActive = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
            return dt;

        }

        public static DataTable GetAllUserMetaphors(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "select * from BorrowingRecords where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                ///
            }
            return dt;

        }

        //public static DataTable GetAllUserFines(int UserID)
        //{

        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ConnectionString))
        //        {
        //            string query = "select * from Fines where UserID = @UserID";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@UserID", UserID);
        //                connection.Open();
        //                SqlDataReader reader = command.ExecuteReader();
        //                if (reader.HasRows)
        //                {
        //                    dt.Load(reader);
        //                }
        //                reader.Close();

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ///
        //    }
        //    return dt;
        //}

        public static bool isUserExist(string Username)
        {
            bool isFound = false;
            try
            {
              using (SqlConnection connection = new SqlConnection(ConnectionString))
              {
                  string query = "Select Found =1 from [Users] where Username = @Username ";
                  using (SqlCommand command = new SqlCommand(query, connection))
                  {
                      command.Parameters.AddWithValue("@Username", Username);
                      connection.Open();
                      SqlDataReader reader = command.ExecuteReader();
              
                      isFound = reader.HasRows;
                      reader.Close();
                  }
              }

            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
          
            return isFound;

        }


    }
}
