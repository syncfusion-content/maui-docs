#nullable disable
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Documents;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridViewModel"/> class.
        /// </summary>
        public __VIEW_MODEL_NAME__()
        {
            Gender = new List<string>();
            Gender.Add("Male");
            Gender.Add("Female");

			Trustworthiness = new List<string>();
            Trustworthiness.Add("Sufficient");
            Trustworthiness.Add("Insufficient");
            Trustworthiness.Add("Perfect");
            EmployeeDetails = GetEmployeeDetails(50);
        }

        #endregion

        #region Properties
		
		public List<string> Trustworthiness { get; set; }

        private ObservableCollection<DataGridModel> _employeeDetails = new ObservableCollection<DataGridModel>();

        public ObservableCollection<DataGridModel> EmployeeDetails
        {
            get { return _employeeDetails; }
            set { _employeeDetails = value; }
        }
        public List<string> Gender { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion

        #region Method

        public ObservableCollection<DataGridModel> GetEmployeeDetails(int count)
        {
            Random random = new Random();
            ObservableCollection<DataGridModel> ordersDetails = new ObservableCollection<DataGridModel>();

            for (int i = 10000; i < count + 10000; i++)
            {
                var name = employees[random.Next(25)];
                int index = Array.IndexOf(employees, name);
                string genders = Gender[gender[index]];
                ordersDetails.Add(new DataGridModel(name, designation[random.Next(6)], name.ToLower() + "@" + mail[random.Next(4)], location[random.Next(8)], trust[random.Next(3)], random.Next(1, 5), random.Next(100000, 400000), address[random.Next(1, 25)], genders));
            }

            return ordersDetails;
        }
        #endregion

        #region Collections

        string[] employees = { "Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Therasa",
        "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne",
        "Bergs", "Vinet", "Anto", "Fleet", "Zachery", "Van", "Edward", "Jack", "Rose"};
        int[] gender = { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1};
        string[] designation = { "Manager", "CFO", "Designer", "Developer", "Program Directory", "System Analyst", "Project Lead" };
        string[] mail = { "arpy.com", "sample.com", "rpy.com", "jourrapide.com" };
        string[] trust = { "Sufficient", "Perfect", "Insufficient" };
        string[] location = { "UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico" };
        string[] address = {"59 rue de lAbbaye", "Luisenstr. 48"," Rua do Paço 67", "2 rue du Commerce", "Boulevard Tirou 255",
        "Rua do mailPaço 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12",
        "Carrera 22 con Ave."," Carlos Soublette #8-35", "Kirchgasse 6",
        "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora 12", "2817 Milton Dr.", "Kirchgasse 6",
        "Åkergatan 24", "24, place Kléber", "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.",
        "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye", "Via Ludovico il Moro 22",
        "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1",
        "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10"};

        #endregion
    }

    public class SelectedImageConverter : IValueConverter
    {
        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="info">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
        {

            if (value == null)
                return null;
            return @"/__ROOT_NAMESPACE__;component/DataGrid/Resources/Employee.png";
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="info">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo info)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                string str = value.ToString();

                if (str == "Sufficient")
                    return @"/__ROOT_NAMESPACE__;component/DataGrid/Resources/Sufficient.png";
                else if (str == "Insufficient")
                    return @"/__ROOT_NAMESPACE__;component/DataGrid/Resources/Insufficient.png";
                else if (str == "Perfect")
                    return @"/__ROOT_NAMESPACE__;component/DataGrid/Resources/Perfect.png";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
