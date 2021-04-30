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
    /// Логика взаимодействия для AllData.xaml
    /// </summary>
    public partial class AllData : Window
    {
        public AllData(int i)
        {
            InitializeComponent();
            if (i == 1)
                Specialties.IsSelected = true;
            if (i == 2)
                Departments.IsSelected = true;
            if (i == 3)
                Subjects.IsSelected = true;
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
            MainMenu mainMenu = new MainMenu();
            mainMenu.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
