using Mediateka.Models;
using Mediateka.Pages;
using Mediateka.Windows;
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

        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            new SelectRole().ShowDialog();
            if (App.SelectRoleReg != null)
            {
                if (App.SelectRoleReg.Id == 1)
                    MainFrame.Navigate(new RegestrationPage(new EventPlanner()));
                else if (App.SelectRoleReg.Id == 2)
                    MainFrame.Navigate(new RegestrationPage(new Executor()));
                else if (App.SelectRoleReg.Id == 3)
                    MainFrame.Navigate(new RegestrationModerator(new Moderators()));


            }
        }

        private void GProfile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var contextModerator = this.DataContext as Moderators;
            if(contextModerator != null)
            {
                MainFrame.Navigate(new RegestrationModerator(contextModerator));
            }
            else
            {
                var contextExecutor = DataContext as Executor;
                if(contextExecutor!=null)
                     MainFrame.Navigate(new RegestrationPage(contextExecutor));
                else
                    MainFrame.Navigate(new RegestrationPage(DataContext as EventPlanner));

            }

        }
    }
}
