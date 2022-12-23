using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ruminia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateBirthDatePicker.SelectedDate = DateTime.Now;
            string[] readText = File.ReadAllLines("Roman.csv");
            List<string> data= new List<string>();

            foreach (string item in readText)
            {
                data.Add(item);
                
               
            }
            foreach (var item in data)
            {
            string country=item.Split(';')[2];
                CityCombobox.Items.Add(country);
            }
             
        }

        private void GenerationButton_Click(object sender, RoutedEventArgs e)
        {
            string codeName="";
            if (DateBirthDatePicker.SelectedDate.Value.Year>=1900 && DateBirthDatePicker.SelectedDate.Value.Year <= 1949 && ResidentYes.IsChecked == true)
            {
                codeName= codeName+"1";
            }
            if (DateBirthDatePicker.SelectedDate.Value.Year >= 1950 && DateBirthDatePicker.SelectedDate.Value.Year <= 1999 && ResidentYes.IsChecked == true)
            {
                codeName = codeName + "2";
            }
            if (DateBirthDatePicker.SelectedDate.Value.Year >= 1800 && DateBirthDatePicker.SelectedDate.Value.Year <= 1849 && ResidentYes.IsChecked == true)
            {
                codeName = codeName + "3";
            }
            if (DateBirthDatePicker.SelectedDate.Value.Year >= 1850 && DateBirthDatePicker.SelectedDate.Value.Year <= 1899
                && ResidentYes.IsChecked == true
                )
            {
                codeName = codeName + "4";
            }
            if (DateBirthDatePicker.SelectedDate.Value.Year >= 2000 && DateBirthDatePicker.SelectedDate.Value.Year <= 2049 && ResidentYes.IsChecked == true)
            {
                codeName = codeName + "5";
            }
            if (DateBirthDatePicker.SelectedDate.Value.Year >= 2050 && DateBirthDatePicker.SelectedDate.Value.Year <= 2099 && ResidentYes.IsChecked == true)
            {
                codeName = codeName + "6";
            }
            Random rnd = new Random();
            if (ResidentNo.IsChecked==true)
            {
                codeName = codeName+ rnd.Next(7, 10);
            }
            
            string date =DateBirthDatePicker.SelectedDate.Value.Year.ToString();
            codeName=codeName+date.Substring(2,2);
            
            MessageBox.Show(codeName);
        }
    }
}
