using Mediateka.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mediateka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.mainWindow = this;
            MainFrame.Navigate(new LoginPage());
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.ExitFromApp();
            this.DataContext = null;
            GProfile.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new LoginPage());
        }
    }
}
