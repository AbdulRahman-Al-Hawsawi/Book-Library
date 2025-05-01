using FineLibrary_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary_DataAccess;

namespace FineLibrary_Business
{
    public class clsFine
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;
        public int FineID { get; set; }
        public int UserID { get; set; }
        public int BorrowingRecordID { get; set; }
        public byte NumberOfLateDays { get; set; }
        public double FineAmount { get; set; }
       
        public clsFine()
        {
            this.FineID = -1;
            this.UserID = -1;
            this.BorrowingRecordID = -1;
            this.NumberOfLateDays = 0;
            this.FineAmount = 0;
            this.Mode = _enMode.Add;
        }
        private clsFine(int FineID, int UserID, int BorrowingRecordID, byte NumberOfLateDays, double FineAmount)
        {
            this.FineID = FineID;
            this.UserID = UserID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.Mode = _enMode.Update;

        }
        private bool _AddNewFine()
        {
            this.FineID = clsFineDataAccess.AddNewFine(this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount);

            return (this.FineID != -1);
        }

        private bool _UpdateFine()
        {
            return clsFineDataAccess.UpdateFine(this.FineID, this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount);
        }
        public static bool DeleteFine(int FineFineID)
        {
            return clsFineDataAccess.DeleteFine(FineFineID);
        }

        public static clsFine Find(int FineID)
        {
            int UserID = -1, BorrowingRecordID = -1;
            byte NumberOfLateDays = 0;
            double FineAmount = 0;
            
            if (clsFineDataAccess.GetFineInfoByFineID(FineID, ref UserID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount))
                return new clsFine(FineID, UserID, BorrowingRecordID, NumberOfLateDays, FineAmount);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        return _AddNewFine();
                    }
                case _enMode.Update:
                    {
                        return _UpdateFine();
                    }

            }
            return false; // for handl just

        }

        public static DataTable GetAllFines()
        {
            return clsFineDataAccess.GetAllFines();
        }

        public static DataTable GetAllUserFines(int UserID)
        {
            return clsFineDataAccess.GetAllUserFines(UserID);
        }

        //public static bool ReturnBorrowedFine(int CopyID)
        //{
        //    return clsFineDataAccess.ReturnBorrowedFine(CopyID);
        //}

        //public static DataTable GetNextPage(int PageNumber, int UserID)
        //{
        //    return clsFineDataAccess.GetNextPage(PageNumber, UserID);
        //}

    }
}

