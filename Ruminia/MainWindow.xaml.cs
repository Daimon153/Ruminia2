﻿using System;
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

            foreach (string item in readText)
            {
                string country=item.Split(';')[2];
                CityCombobox.Items.Add(country);
            }
        }

        private void GenerationButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
