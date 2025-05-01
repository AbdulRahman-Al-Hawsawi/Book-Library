using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FineLibrary_DataAccess
{
    public class clsFineDataAccess
    {
       public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static bool GetFineInfoByFineID(int FineID, ref int UserID, ref int BorrowingRecordID, ref byte NumberOfLateDays, ref double FineAmount)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "Select * from Fines where FineID = @FineID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            BorrowingRecordID = Convert.ToInt32(reader["BorrowingRecordID"]);
                            NumberOfLateDays = Convert.ToByte(reader["NumberOfLateDays"]);
                            FineAmount = Convert.ToDouble(reader["FineAmount"].ToString());
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
                string message = e.Message;
                IsFound = false;
            }

            return IsFound;

        }

        public static int AddNewFine(int UserID, int BorrowingRecordID, int NumberOfLateDays, double FineAmount)
        {

            int FineID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO [dbo].[Fines] ([UserID],[BorrowingRecordID],[NumberOfLateDays],[FineAmount])VALUES (@UserID,@BorrowingRecordID,@NumberOfLateDays,@FineAmount); select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
                     

                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            FineID = InsertedID;
                        }

                    }


                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return FineID;

        }

        public static bool UpdateFine(int FineID, int UserID, int BorrowingRecordID, byte NumberOfLateDays, double FineAmount)
        {
            int rowAffected = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE [dbo].[Fines]SET [UserID] = @UserID,[BorrowingRecordID] =@BorrowingRecordID,[NumberOfLateDays] = @NumberOfLateDays,[FineAmount] = @FineAmount WHERE FineID =@FineID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@FineID", FineID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
                       
                        rowAffected = command.ExecuteNonQuery();

                    }


                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return (rowAffected > 0);

        }

        public static bool DeleteFine(int FineID)
        {
            int rowAffected = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete [dbo].[Fines] WHERE FineID =@FineID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@FineID", FineID);
                        rowAffected = command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return (rowAffected > 0);

        }

        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Fines";
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
            catch (Exception ex)
            {
                //Console.WriteLine("Handle the error later");
                string message = ex.Message;
            }

            return dt;

        }

        public static DataTable GetAllUserFines(int UserID)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "exec SP_GetAllUserFines @UserID";
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
                string msg = ex.Message;
            }
            return dt;
        }
    }
}
