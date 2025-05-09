using BookLibrary_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace BookLibrary_Business
{
    public class clsBook
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public string BookDescription { get; set; }
        public float Rating { get; set; }
        public int NumberOfCopies { get; set; }
        public string ImagePath { get; set; }

        public clsBook()
        {
            this.BookID = -1;
            this.BookName = "";
            this. AuthorName = "";
            this.ISBN = "";
            this.BookDescription = "";
            this.Rating = 0;
            this.NumberOfCopies = 1;
            this.ImagePath = "";
            this.Mode = _enMode.Add;
        }
        private clsBook(int BookID, string BookName, string  AuthorName, string ISBN,string BookDescription,float Rating,int NumberOfCopies, string ImagePath)
        {
            this.BookID = BookID;
            this.BookName = BookName;
            this. AuthorName =  AuthorName;
            this.ISBN = ISBN;
            this.BookDescription = BookDescription;
            this.Rating = Rating;
            this.ImagePath = ImagePath;
            this.NumberOfCopies = NumberOfCopies;
            this.Mode = _enMode.Update;

        }
        private bool _AddNewBook()
        {
            this.BookID = clsBookDataAccess.AddNewBook(this.BookName, this. AuthorName, this.ISBN,this.BookDescription,this.NumberOfCopies, this.ImagePath);

            return (this.BookID != -1);
        }

        private bool _UpdateBook()
        {
            return clsBookDataAccess.UpdateBook(this.BookID, this.BookName, this.AuthorName, this.ISBN, this.BookDescription,this.NumberOfCopies, this.ImagePath);
        }
        public static bool DeleteBook(int BookBookID)
        {
            return clsBookDataAccess.DeleteBook(BookBookID);
        }

        //public static bool isBookExist(int BookBookID)
        //{
        //    return clsBookDataAccess.isBookExist(BookBookID);
        //}

        //public static bool isBookExist(string NationalNo)
        //{
        //    return clsBookDataAccess.isBookExist(NationalNo);
        //}

        public bool IsAvailable()
        {
            return clsBookDataAccess.IsAvailable(this.BookID);
        }

        public bool Borrow(int UserID)
        {
            return clsBookDataAccess.Borrw(this.BookID, UserID);
        }

        public static bool Borrow(int UserID,int BookID)
        {
            return clsBookDataAccess.Borrw(BookID, UserID);
        }

        public static clsBook Find(int BookID)
        {
            string BookName = "", AuthorName = "", ISBN = "", BookDescription ="", ImagePath = "";
            int NumberOfCopies = 0;
            float Rating = 0.0f;
             
            if (clsBookDataAccess.GetBookInfoByBookID(BookID,ref BookName,ref AuthorName,ref ISBN,ref BookDescription,ref Rating,ref NumberOfCopies,ref ImagePath))
                return new clsBook(BookID,BookName, AuthorName, ISBN, BookDescription,Rating,NumberOfCopies, ImagePath);
            else
                return null;

        }


        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        return _AddNewBook();
                    }
                case _enMode.Update:
                    {
                        return _UpdateBook();
                    }

            }
            return false; // for handl just
           
        }

        public static DataTable GetAllBooks()
        {
            return clsBookDataAccess.GetAllBooks();
        }

        

        public static bool ReturnBorrowedBook(int CopyID)
        {
           if(clsBookDataAccess.ReturnBorrowedBook(CopyID))
            {



                return true;
            }
           return false;
        }

        public static  DataTable GetNextPage(int PageNumber,int UserID)
        {
           return clsBookDataAccess.GetNextPage(PageNumber,UserID);
        }

        public static DataTable GetAllUserBorrowedBooks(int UserID)
        {
            return clsBookDataAccess.GetAllUserBorrowedBooks(UserID);
        }

    }
}
