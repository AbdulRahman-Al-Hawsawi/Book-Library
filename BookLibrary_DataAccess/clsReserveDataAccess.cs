using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BookLibrary_DataAccess
{
    public class clsReserveDataAccess
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static bool GetReserveInfoByReserveID(int ReserveID, ref int UserID, ref int CopyID, ref DateTime ReservationDate/*, ref int Permissions, ref string Password*/)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Reservations where ReserveID = @ReserveID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReserveID", ReserveID);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            CopyID = Convert.ToInt32(reader["CopyID"]);
                            ReservationDate = Convert.ToDateTime(reader["ReservationDate"]);
                            //Permissions = Convert.ToInt32(reader["Permissions"]);
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
            }

            return IsFound;

        }

        public static bool GetReserveInfoByEmailAndPassword(string Email, string Password, ref int ReserveID, ref int UserID, ref string CopyID, ref byte ReservationDate, ref string phone)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Reserves where Email = @Email and Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password", Password);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            CopyID = Convert.ToString(reader["CopyID"]);
                            ReservationDate = Convert.ToByte(reader["ReservationDate"]);
                            ReserveID = Convert.ToInt32(reader["ReserveID"]);
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

        public static bool GetReserveInfoByCopyIDAndPassword(string CopyID, string Password, ref int ReserveID, ref int UserID, ref byte ReservationDate, ref int Permissions)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Reserves where CopyID = @CopyID and Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@Password", Password);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            Permissions = Convert.ToInt32(reader["Permissions"]);
                            ReservationDate = Convert.ToByte(reader["ReservationDate"]);
                            ReserveID = Convert.ToInt32(reader["ReserveID"]);


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

        public static int AddNewReserve(int UserID, int BookID)
        {

            int ReserveID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "EXECUTE [dbo].[SP_ReserveBook]  @UserID,@BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                       
                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            ReserveID = InsertedID;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return ReserveID;

        }

        public static int ReturnUserIdFromReservationsTableToSendBookAvailable(int CopyID)
        {

            int ReserveID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "exec SP_ReturnUserIdFromReservationsTableToSendBookAvailable @CopyID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@CopyID", CopyID);

                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            ReserveID = InsertedID;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return ReserveID;

        }
        public static bool UpdateReserve(int ReserveID, int UserID, string CopyID, byte ReservationDate, int Permissions, string Password)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Update[dbo].[Reserves] set UserID = @UserID,CopyID = @CopyID,ReservationDate = @ReservationDate,Permissions = @Permissions,Password = @Password Where ReserveID = @ReserveID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReserveID", ReserveID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@Permissions", Permissions);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@ReservationDate", ReservationDate);

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
        public static bool DeleteReserve(int ReserveID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "EXECUTE [dbo].[SP_DeleteReserve]  @ReserveID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReserveID", ReserveID);
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

        public static DataTable GetAllUserReservations(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Reservations where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID",UserID);
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
                string msg = ex.Message;

            }
            return dt;
        }
        public static DataTable GetAllReserves()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Reserves";
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
        public static DataTable GetAllReserveMetaphors(int ReserveID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "select * from BorrowingRecords where ReserveID = @ReserveID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReserveID", ReserveID);
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

        //public static DataTable GetAllReserveFines(int ReserveID)
        //{

        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ConnectionString))
        //        {
        //            string query = "select * from Fines where ReserveID = @ReserveID";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@ReserveID", ReserveID);
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

        public static bool isReserveExist(string CopyID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select Found =1 from [Reserves] where CopyID = @CopyID ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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

