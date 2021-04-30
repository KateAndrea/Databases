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
    /// Логика взаимодействия для Enrolles.xaml
    /// </summary>
    public partial class Enrolles : Window
    {
        public Enrolles(string y)
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputComboBox.SelectedItem == null)
                MessageBox.Show("Оберіть прізвище");
            else
            {
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
                InputComboBox.Text = null;
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            InputComboBox.Text = null;

        }
        private void Inf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainW_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartW_Click(object sender, RoutedEventArgs e)
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

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
