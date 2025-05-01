using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary_DataAccess;


namespace BookLibrary_Business
{
    public class clsReserve
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;
        public int ReserveID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        //public byte NumberOfLateDays { get; set; }
        //public double ReserveAmount { get; set; }

        public clsReserve()
        {
            this.ReserveID = -1;
            this.UserID = -1;
            this.BookID = -1;
           
            this.Mode = _enMode.Add;
        }
        private clsReserve(int ReserveID, int UserID, int BookID)
        {
            this.ReserveID = ReserveID;
            this.UserID = UserID;
            this.BookID = BookID;
          
            this.Mode = _enMode.Update;

        }
        private bool _AddNewReserve()
        {
            this.ReserveID = clsReserveDataAccess.AddNewReserve(this.UserID, this.BookID);
            return (this.ReserveID != -1);
        }

       public static int ReturnUserIdFromReservationsTableToSendBookAvailable(int CopyID)
        {
            return clsReserveDataAccess.ReturnUserIdFromReservationsTableToSendBookAvailable(CopyID);
        }

        //private bool _UpdateReserve()
        //{
        //    return clsReserveDataAccess.UpdateReserve(this.ReserveID, this.UserID, this.BookID);
        //}
        //public static bool DeleteReserve(int ReserveReserveID)
        //{
        //    return clsReserveDataAccess.DeleteReserve(ReserveReserveID);
        //}

        //public static clsReserve Find(int ReserveID)
        //{
        //    int UserID = -1, BookID = -1;
        //    byte NumberOfLateDays = 0;
        //    double ReserveAmount = 0;

        //    if (clsReserveDataAccess.GetReserveInfoByReserveID(ReserveID, ref UserID, ref BookID, ref NumberOfLateDays, ref ReserveAmount))
        //        return new clsReserve(ReserveID, UserID, BookID, NumberOfLateDays, ReserveAmount);
        //    else
        //        return null;

        //}

        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        return _AddNewReserve();
                    }
                case _enMode.Update:
                    {
                        //return _UpdateReserve();
                        break;
                    }

            }
            return false; // for handl just

        }

        public static DataTable GetAllReserves()
        {
            return clsReserveDataAccess.GetAllReserves();
        }

        public static DataTable GetAllUserReservations(int UserID)
        {
            return clsReserveDataAccess.GetAllUserReservations(UserID);
        }

        //public static bool ReturnBorrowedReserve(int CopyID)
        //{
        //    return clsReserveDataAccess.ReturnBorrowedReserve(CopyID);
        //}

        //public static DataTable GetNextPage(int PageNumber, int UserID)
        //{
        //    return clsReserveDataAccess.GetNextPage(PageNumber, UserID);
        //}
    }
}
