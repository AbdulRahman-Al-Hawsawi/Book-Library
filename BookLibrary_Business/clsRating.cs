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
    class clsRating
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int RatingID { get; set; }
        public int UserID { get; set; }
        public short BookID { get; set; }
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
            this.RatingID = clsRatingDataAccess.AddNewRating(this.UserID, this.BookID, this.Rating, this.RatingDate);

            return (this.RatingID != -1);
        }

        private bool _UpdateRating()
        {
            return clsRatingDataAccess.UpdateRating(this.RatingID, this.UserID, this.BookID, this.Rating, this.RatingDate, this.Password);
        }

        public static bool DeleteRating(int RatingRatingID)
        {
            return clsRatingDataAccess.DeleteRating(RatingRatingID);
        }

        public static bool DeleteAdmin(int RatingRatingID)
        {
            return clsRatingDataAccess.DeleteRating(RatingRatingID);
        }

        public static bool isRatingExist(string BookID)
        {
            return clsRatingDataAccess.isRatingExist(BookID);
        }

        public static clsRating Find(int RatingID)
        {
            string BookID = "", Password = "";
            int UserID = -1, RatingDate = 0;
            byte Rating = 0;

            if (clsRatingDataAccess.GetRatingInfoByRatingID(RatingID, ref UserID, ref BookID, ref Rating, ref RatingDate, ref Password))
                return new clsRating(RatingID, UserID, BookID, Rating, RatingDate, Password);
            else
                return null;

        }

        public static clsRating Find(string Email, string Password)
        {
            string BookID = "";
            byte Rating = 0;
            int RatingID = 0, UserID = 0, RatingDate = 0;

            if (clsRatingDataAccess.GetRatingInfoByEmailAndPassword(Email, Password, ref RatingID, ref UserID, ref BookID, ref Rating, ref Password))
                return new clsRating(RatingID, UserID, BookID, Rating, RatingDate, Password);
            else
                return null;

        }

        public static clsRating FindByBookIDAndPassword(string BookID, string Password)
        {

            byte Rating = 0;
            int RatingID = 0, UserID = 0, RatingDate = 0;

            if (clsRatingDataAccess.GetRatingInfoByBookIDAndPassword(BookID, Password, ref RatingID, ref UserID, ref Rating, ref RatingDate))
                return new clsRating(RatingID, UserID, BookID, Rating, RatingDate, Password);
            else
                return null;

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

    }
}
