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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

        }

        private void Pass_Checked(object sender, RoutedEventArgs e)
        {
            passText.Text = passBox.Password;
            passBox.Visibility = Visibility.Collapsed;
            passText.Visibility = Visibility.Visible;
        }

        private void Pass_Unchecked(object sender, RoutedEventArgs e)
        {
            passBox.Password = passText.Text;
            passBox.Visibility = Visibility.Visible;
            passText.Visibility = Visibility.Collapsed;

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if ((passBox.Password == "Test" || passText.Text == "Test") && logText.Text == "Test")
            {
                passBox.Password = null;
            passText.Text = null;
            logText.Text = null;
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
                if ((passBox.Password != "Test" || passText.Text != "Test") && logText.Text == "Test")
            {
                MessageBox.Show("Wrong password");
            }
            else if ((passBox.Password == "Test" || passText.Text == "Test") && logText.Text != "Test")
            {
                MessageBox.Show("Wrong username");
            }
            else MessageBox.Show("Wrong username and password");
        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
