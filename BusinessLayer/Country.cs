using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Country
    {
        public enum enMode { Update = 0, AddNew = 1 }
        public enMode Mode = enMode.AddNew;
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public Country()
        {
            CountryID = -1;
            CountryName = "";
            Code = "";
            PhoneCode = "";
            Mode = enMode.AddNew;
        }
        public Country(int CountryID, string CountryName, string Code, string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
            Mode = enMode.Update;

        }
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountry.AddNewCountry(this.CountryName, this.Code, this.PhoneCode);
            return CountryID != -1;
        }
        private bool _UpdateCountry()
        {
            return clsCountry.UpdateCountry(this.CountryName, this.CountryID, this.Code, this.PhoneCode);
        }
        public static Country Find(int ID)
        {

            string CountryName = "";
            String Code = "";
            string PhoneCode = "";


            if (clsCountry.GetCountryInfoByID(ID, ref CountryName, ref Code, ref PhoneCode))

                return new Country(ID, CountryName, Code, PhoneCode);
            else
                return null;

        }

        public static Country Find(string CountryName)
        {
            string Code = "";
            string PhoneCode = "";
            int CountryID = -1;


            if (clsCountry.GetCountryInfoByName(CountryName, ref CountryID, ref Code, ref PhoneCode))

                return new Country(CountryID, CountryName, Code, PhoneCode);
            else
                return null;

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.AddNew;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }

            }
            return false;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountry.GetAllCountries();
        }
        public static bool DeleteCountry(int CountryID)
        {
            return clsCountry.DeleteCountry(CountryID);
        }
        public static bool IsCountryExistByID(int CountryID)
        {
            return clsCountry.IsCountryExistByID(CountryID);
        }
        public bool IsCountryExist(string CountryName)
        {
            return clsCountry.IsCountryExistByName(CountryName);
        }

    }
}
