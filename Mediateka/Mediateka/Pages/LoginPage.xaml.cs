using Mediateka.Models;
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

namespace Mediateka.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    /// 

    public partial class LoginPage : Page
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            
            DataContext = this;
            
        }

        private bool ValidationLine()
        {
            //Проверяем заполненость полей
            bool isValid = !(string.IsNullOrEmpty(Login) && string.IsNullOrEmpty(Password));

            //Выводи сообщение пользавтелю если какое-то поле пустое
            if (!isValid)
                MessageBox.Show("Не все поля заполнены");

            return isValid; 
        }

        
        private void BLoginPlanning_Click(object sender, RoutedEventArgs e)
        {
            Password = PBPass.Password;
            if (ValidationLine())
            {
               EventPlanner eventPlanner = App.Db.EventPlanner.FirstOrDefault(ex => ex.Email == Login && ex.Password == Password);
               Executor executor = App.Db.Executor.FirstOrDefault(x => x.Email == Login && x.Password == Password);
               Moderators moderator = App.Db.Moderators.FirstOrDefault(x => x.Login == Login && x.Password == Password);
                if (eventPlanner != null)
                {
                    App.contextEventPlanner = eventPlanner;
                    App.mainWindow.DataContext = eventPlanner;
                    App.mainWindow.GProfile.Visibility = Visibility.Visible;
                    NavigationService.Navigate(new ListEventPlanner());
                }
                else if(executor!=null)
                {
                    App.contextExecutor = executor;
                    App.mainWindow.DataContext = executor;
                    App.mainWindow.GProfile.Visibility = Visibility.Visible;

                    NavigationService.Navigate(new ListOrdersExecutors());
                }
                else if (moderator != null)
                {
                    App.contextModerator = moderator;
                    App.mainWindow.DataContext = moderator;
                    App.mainWindow.GProfile.Visibility = Visibility.Visible;

                    if (moderator.RoleId == 1)
                        App.mainWindow.BAddUser.Visibility = Visibility.Visible;

                    NavigationService.Navigate(new WaitingEventList());
                }
                else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }
        private void BRegestrationPlanning_Click(object sender, RoutedEventArgs e)
        {
            new SelectRole().ShowDialog();
            if(App.SelectRoleReg != null)
            {
                if (App.SelectRoleReg.Id == 1)
                    NavigationService.Navigate(new RegestrationPage( new EventPlanner()));
                else if (App.SelectRoleReg.Id == 2)
                    NavigationService.Navigate(new RegestrationPage( new Executor()));
                else if(App.SelectRoleReg.Id ==3)
                    NavigationService.Navigate(new RegestrationModerator(new Moderators()));

                
            }

        }
    }
}
