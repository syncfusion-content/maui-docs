#nullable disable
using System.ComponentModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class DataGridModel : INotifyPropertyChanged
    {
        private bool selected;
        private string employeeName = string.Empty;
        private string designation = string.Empty;
        private string mail = string.Empty;
        private string trustworthiness = string.Empty;
        private string status = string.Empty;
        private int softwareProficiency;
        private int salary;
        private string address = string.Empty;
        private string gender = string.Empty;

        public DataGridModel(
            bool selected,
            string name,
            string designation,
            string mail,
            string location,
            string trustworthiness,
            string status,
            int proficiency,
            int salary,
            string address,
            string gender)
        {
            Selected = selected;
            EmployeeName = name;
            Designation = designation;
            Mail = mail;
            Location = location;
            Trustworthiness = trustworthiness;
            Status = status;
            SoftwareProficiency = proficiency;
            Salary = salary;
            Address = address;
            Gender = gender;
        }

        public bool Selected
        {
            get { return selected; }
            set { SetProperty(ref selected, value); }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { SetProperty(ref employeeName, value); }
        }

        public string Designation
        {
            get { return designation; }
            set { SetProperty(ref designation, value); }
        }

        public string Mail
        {
            get { return mail; }
            set { SetProperty(ref mail, value); }
        }

        public string Location { get; set; }

        public string Trustworthiness
        {
            get { return trustworthiness; }
            set { SetProperty(ref trustworthiness, value); }
        }

        public string Status
        {
            get { return status; }
            set { SetProperty(ref status, value); }
        }

        public int SoftwareProficiency
        {
            get { return softwareProficiency; }
            set { SetProperty(ref softwareProficiency, value); }
        }

        public int Salary
        {
            get { return salary; }
            set { SetProperty(ref salary, value); }
        }

        public string Address
        {
            get { return address; }
            set { SetProperty(ref address, value); }
        }

        public string Gender
        {
            get { return gender; }
            set { SetProperty(ref gender, value); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(
            ref T field,
            T value,
            [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            field = value;
            RaisePropertyChanged(propertyName);
        }

        public void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
