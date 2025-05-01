using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using System.Net;
using System.Windows.Input;

namespace BookLibrary_DataAccess
{
    public class clsPersonDataAccess
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static bool GetPersonInfoByPersonID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Email, ref string Phone, ref string ImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from People where PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            FirstName = Convert.ToString(reader["FirstName"]);
                            SecondName = Convert.ToString(reader["SecondName"]);
                            ThirdName = Convert.ToString(reader["ThirdName"]);
                            LastName = Convert.ToString(reader["LastName"]);
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            Gender = Convert.ToByte(reader["Gender"]);
                            Address = Convert.ToString(reader["Address"]);
                            Email = Convert.ToString(reader["Email"]);
                            Phone = Convert.ToString(reader["Phone"]);
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
                IsFound = false;
            }
            
            return IsFound;

        }

        public static int AddNewPerson( string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Email, string Phone,  string ImagePath)
        {
            int PersontID = -1;
            try
            {
             
              using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                string query = "INSERT INTO [dbo].[People]([FirstName],[SecondName],[ThirdName],[LastName],[DateOfBirth],[Gender],[Address],[Phone],[Email],[ImagePath])VALUES(@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@ImagePath);;SELECT SCOPE_IDENTITY();";
              
                    using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);

                    if (ImagePath != "")
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                        object result = command.ExecuteScalar();
                        int InsertedID;

                        if (result != null && int.TryParse(result.ToString(), out InsertedID))
                        {
                            PersontID = InsertedID;
                        }
                    }

            }
           

            }
            catch (Exception e)
            {
                string error = e.Message;
            }
           
            return PersontID;

        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Email, string Phone, string ImagePath)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Update[dbo].[People] set [FirstName] =@FirstName,SecondName =@SecondName, ThirdName =@ThirdName,[LastName] =@LastName,[DateOfBirth] =@DateOfBirth,Gender =@Gender,[Address] =@Address,[Email] =@Email,[Phone] =@Phone,[ImagePath] =@ImagePath Where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);

                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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


        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Delete [dbo].[People] where PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from People where IsActive = 1";
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

        public static bool isPersonExist(int PersonID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "Select Found =1 from [People] where PersonID = @PersonID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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

        //    public static bool isPersonExist(string NationalNo)
        //    {
        //        bool isFound = false;
        //        SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //        string query = "Select Found =1 from [People] where NationalNo = @NationalNo ";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@NationalNo", NationalNo);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            isFound = reader.HasRows;
        //            reader.Close();
        //        }
        //        catch (Exception e)
        //        {
        //            string M = e.Message;
        //            //Console.WriteLine("Handle the error later");
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }

        //        return isFound;

        //    }



    }
}

