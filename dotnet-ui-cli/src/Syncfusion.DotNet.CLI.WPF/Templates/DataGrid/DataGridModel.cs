#nullable disable
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Documents;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class DataGridModel : NotificationObject
    {
        #region Private members

        private string _name;
        private string _designation;
        private string _mail;
        private string _trust;
        private int _rating;
        private int _salary;
        private string _address;
        private string _gender;
        #endregion

        public DataGridModel()
        {

        }

        public DataGridModel(string name, string designation, string mail, string location, string trust, int rating, int salary, string address, string gender)
        {
            EmployeeName = name;
            Designation = designation;
            Mail = mail;
            Location = location;
            Trustworthiness = trust;
            Rating = rating;
            Salary = salary;
            Address = address;
            Gender = gender;
        }

        /// <summary>
        /// Gets or sets the employee name.
        /// </summary>        
        public string EmployeeName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("EmployeeName");
            }
        }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>        
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                _designation = value;
                RaisePropertyChanged("Designation");
            }
        }

        /// <summary>
        /// Gets or sets the mail ID.
        /// </summary>        
        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
                RaisePropertyChanged("Mail");
            }
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>        
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the Trustworthiness.
        /// </summary>        
        public string Trustworthiness
        {
            get
            {
                return _trust;
            }
            set
            {
                _trust = value;
                RaisePropertyChanged("Trustworthiness");
            }
        }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>        
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
                RaisePropertyChanged("Rating");
            }
        }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>        
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
                RaisePropertyChanged("Salary");
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>        
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                RaisePropertyChanged("Address");
            }
        }

        ///<summary>
        ///Gets or sets the gender
        ///</summary>
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
    }
}
