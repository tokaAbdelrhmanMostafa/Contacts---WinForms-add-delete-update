using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsContact
    {
        public enum enMode { AddNew = 0, update = 1 }
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public clsContact()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;

        }
        private clsContact(int ID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.update;

        }
        public static clsContact Find(int ID)
        {
            string FirstName = "", LastName = "", ImagePath = "",
                 Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = 1;

            if (clsContactDataAccess.GetContactInfoByID(
            ID, ref FirstName, ref LastName,
                        ref Email, ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))

            {
                return new clsContact(ID, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewContact()
        {
            this.ID = clsContactDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
            return (this.ID == -1);

        }
        private bool _updateNewContact()
        {
            return clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        Mode = enMode.update;
                        return true;
                    }
                    else { return false; }
                case enMode.update:
                    return _updateNewContact();


            }
            return false;
        }


        public static bool IsContactExist(int ID)
        {
            return clsContactDataAccess.IsContactExist(ID);
        }

        public static bool DeleteContact(int ID)
        {
            return clsContactDataAccess.DeleleteContact(ID);
        }

        public static DataTable GetAllContacts()
        {
            return clsContactDataAccess.GetAllContacts();
        }
    }
}
