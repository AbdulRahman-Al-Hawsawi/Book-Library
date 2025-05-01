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
    public class clsRatingDataAccess
    {
       static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static int AddNewRating(int UserID, int BookID, int Rating)
        {
            int RatingID = -1;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    string query = "INSERT INTO[dbo].[Ratings](UserID,BookID,Rating,RatingDate)VALUES(@UserID,@BookID,@Rating,@RatingDate);SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@Rating", Rating);
                        command.Parameters.AddWithValue("@RatingDate", RatingDate);

                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            RatingID = InsertedID;
                        }
                    }

                }

            }
            catch (Exception e)
            {
                string error = e.Message;
            }

            return RatingID;
        }

        public static bool UpdateRating(int RatingID, int UserID, int BookID, int Rating, string RatingDate)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Update[dbo].[Ratings] set UserID =@UserID, BookID =@BookID, Rating =@Rating, RatingDate =@RatingDate Where RatingID = @RatingID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RatingID", RatingID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@Rating", Rating);
                        command.Parameters.AddWithValue("@RatingDate", RatingDate);

                        rowsAffected = command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception e)
            {
                string error = e.Message;
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteRating(int RatingID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete [dbo].[Ratings] where RatingID = @RatingID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RatingID", RatingID);
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

        public static DataTable GetAllRatings()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Ratings ";
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

        public static bool isRatingExist(int RatingID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select Found =1 from [Ratings] where RatingID = @RatingID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RatingID", RatingID);

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
