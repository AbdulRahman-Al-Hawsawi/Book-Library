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
    public class clsPerson
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int PersonID { get; set; }
      
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public string ImagePath { get; set; }
        public byte Gender { get; set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.SecondName + " " + this.ThirdName + " " + this.LastName; }
        }

        public clsPerson()
        {

            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            this.Gender = 0;
            this.Mode = _enMode.Add;
        }

        private clsPerson(int PersonID,  string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Email, string Phone, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;
            this.Gender = Gender;
            this.Mode = _enMode.Update;

        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson( this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Email, this.Phone, this.ImagePath);

            return (this.PersonID != -1);
        }



        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Email, this.Phone, this.ImagePath);
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPersonDataAccess.isPersonExist(PersonID);
        }

        

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
                byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;



            if (clsPersonDataAccess.GetPersonInfoByPersonID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Email, ref Phone, ref ImagePath))
                return new clsPerson(PersonID,FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Email, Phone, ImagePath);
            else
                return null;

        }

       
        public bool Save()
        {
            bool IsSaved = false;
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        if (_AddNewPerson())
                        {
                            Mode = _enMode.Update;
                            return  true;
                        }
                        else
                        {
                            return  false;
                        }
                        break;
                    }
                case _enMode.Update:
                    {
                       return _UpdatePerson();
                        break;
                    }

            }


            return IsSaved;

        }

        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }



    }
}
