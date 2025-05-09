using BookLibrary_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary_DataAccess;


namespace BookLibrary_Business
{
    public class clsRating
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public byte Rating { get; set; }
        public DateTime RatingDate { get; set; }


        public clsRating()
        {
            this.RatingID = -1;
            this.UserID = -1;
            this.BookID = -1;
            this.Rating = 0;
            this.Mode = _enMode.Add;
        }

        private clsRating(int RatingID, int UserID, short BookID, byte Rating, DateTime RatingDate)
        {
            this.RatingID = RatingID;
            this.UserID = UserID;
            this.BookID = BookID;
            this.RatingDate = RatingDate;
            this.Rating = Rating;
            this.Mode = _enMode.Update;
        }

        private bool _AddNewRating()
        {
            this.RatingID = clsRatingDataAccess.AddNewRating(this.UserID, this.BookID, this.Rating);

            return (this.RatingID != -1);
        }

        private bool _UpdateRating()
        {
            return clsRatingDataAccess.UpdateRating(this.RatingID, this.UserID, this.BookID, this.Rating);
        }

        public static bool DeleteRating(int RatingID)
        {
            return clsRatingDataAccess.DeleteRating(RatingID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        return _AddNewRating();
                    }
                case _enMode.Update:
                    {
                        return _UpdateRating();
                    }

            }
            return false; // for handl just

        }

        public static DataTable GetAllRatings()
        {
            return clsRatingDataAccess.GetAllRatings();
        }

        public static float GetUserRating(int UserID, int BookID)
        {
            return clsRatingDataAccess.GetUserRating(UserID, BookID);
        }

    }
}
