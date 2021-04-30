using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BD_labs
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            InputComboBox.Items.Add("2018");
            InputComboBox.Items.Add("2019");
            InputComboBox.Items.Add("2020");
            InputComboBox.Items.Add("2021");
        }



        string year;
        

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputComboBox.SelectedItem == null)
                MessageBox.Show("Оберіть рік");
            else
            {
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
                year = InputComboBox.Text;
                InputComboBox.Text = null;
                
                Enrolles enrolles = new Enrolles(year);
                enrolles.Show();
            }
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            InputComboBox.Text = null;

        }

        private void Enrolles_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Visible;
        }


        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ = new StartWindow
            {
                Visibility = System.Windows.Visibility.Visible
            };
        }

       
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _ = new StartWindow
            {
                Visibility = System.Windows.Visibility.Visible
            };
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Spec_Click(object sender, RoutedEventArgs e)
        {
            AllData allData = new AllData(1);
            allData.Show();
        }

        private void Dep_Click(object sender, RoutedEventArgs e)
        {
            AllData allData = new AllData(2);
            allData.Show();
        }
    }
}


