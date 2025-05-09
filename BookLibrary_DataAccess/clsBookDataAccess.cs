using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BookLibrary_DataAccess
{
   public class clsBookDataAccess
    {


        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static bool GetBookInfoByBookID(int BookID,ref string BookName,ref string AuthorName,ref string ISBN,ref string BookDescription ,ref float Rating,ref int NumberOfCopies, ref string ImagePath)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "Select * from Books where BookID = @BookID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            BookName = Convert.ToString(reader["BookName"]);
                            AuthorName = Convert.ToString(reader["AuthorName"]);
                            ISBN = Convert.ToString(reader["ISBN"]);
                            BookDescription = Convert.ToString(reader["BookDescription"].ToString());
                            Rating = (float)Convert.ToDouble(reader["Rating"]);
                            NumberOfCopies = Convert.ToInt32(reader["NumberOfCopies"]);
                            ImagePath = Convert.ToString(reader["ImagePath"].ToString());

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

        public static int AddNewBook(string BookName, string AuthorName, string ISBN,string BookDescription,int NumberOfCopies, string ImagePath)
        {

            int BooktID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO [dbo].[Books] ([BookName],[AuthorName],[ISBN],[BookDescription],[NumberOfCopies],[ImagePath])VALUES (@BookName,@AuthorName,@ISBN,@BookDescription,@NumberOfCopies,@ImagePath); select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@BookName", BookName);
                        command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        command.Parameters.AddWithValue("@ISBN", ISBN);
                        command.Parameters.AddWithValue("@BookDescription", BookDescription);
                        command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);


                        if (string.IsNullOrWhiteSpace(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);


                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            BooktID = InsertedID;
                        }

                    }


                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return BooktID;

        }

        public static bool UpdateBook(int BookID,string BookName, string AuthorName, string ISBN, string BookDescription,int NumberOfCopies, string ImagePath)
        {
            int rowAffected = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE [dbo].[Books]SET [BookName] = @BookName,[AuthorName] =@AuthorName,[ISBN] = @ISBN,[BookDescription] = @BookDescription,[NumberOfCopies] = @NumberOfCopies,[ImagePath] = @ImagePath WHERE BookID =@BookID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@BookName", BookName);
                        command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        command.Parameters.AddWithValue("@ISBN", ISBN);
                        command.Parameters.AddWithValue("@BookDescription", BookDescription);
                        command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);

                        if (string.IsNullOrWhiteSpace(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);


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

        public static bool DeleteBook(int BookID)
        {
            int rowAffected = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete [dbo].[Books] WHERE BookID =@BookID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@BookID", BookID);
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

        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
           
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Books where IsActive =1";
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

        public static bool IsAvailable(int BookID)
        {
            int NumberOfAvailableCopies =0;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "select COUNT(*) as AvailableCopies from BookCopies where BookID = @BookID and AvailabilityStatus = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        command.Parameters.AddWithValue("@BookID", BookID);
                       

                        object result = command.ExecuteScalar();
                       

                        if (result != null && int.TryParse(result.ToString(), out NumberOfAvailableCopies))
                        {

                        }
                       

                    }


                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return NumberOfAvailableCopies > 0;
        }

        public static bool Borrw(int BookID, int UserID)
        {
            bool Success = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "DECLARE @Rsult bit; EXEC  @Rsult = [dbo].[SP_BorrowBook] @BookID = @BookId, @UserID = @UserId; SELECT @Rsult";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@BookId", BookID);
                        command.Parameters.AddWithValue("@UserId", UserID);

                        object Result = command.ExecuteScalar();
                        Success = Convert.ToBoolean(Result);
                    }

                }

            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }
            return Success;
        }

        public static bool ReturnBorrowedBook(int CopyID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "EXECUTE [dbo].[SP_ReturnBorrowedBook] @CopyID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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

        public static DataTable GetNextPage(int PageNumber, int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "EXECUTE  [dbo].[SP_GetNetxPage] @PageNumber,@UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
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
                string message = ex.Message;
            }
            return dt;
        }


        public static DataTable GetAllUserBorrowedBooks(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "EXECUTE [dbo].[SP_GetAllUserBorrowedBooks] @UserID";
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


    }
}
