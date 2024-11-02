using Mediateka.Models;
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

        // Обработчик событий для кнопки входа Исполнителя
        private void BLoginExecutor_Click(object sender, RoutedEventArgs e)
        {
            if (ValidationLine())
            {
                Executor executor = App.Db.Executor.FirstOrDefault(ex=>ex.Email == Login && ex.Password== Password);
                if (executor != null)
                {
                    App.contextExecutor = executor;
                    NavigationService.Navigate(new ListOrdersExecutors());
                }
                else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }

        // Обработчик событий для кнопки регестрациии Исполнителя
        private void BRegestrationExecutor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegestrationPage(new Executor()));
        }

        // Обработчик событий для кнопки входа Модератора и Администратора
        private void BLoginModerator_Click(object sender, RoutedEventArgs e)
        {
            if (ValidationLine())
            {
                var moderator = App.Db.Moderators.FirstOrDefault(ex => ex.Login == Login && ex.Password == Password);
                if (moderator != null)
                {
                    App.contextModerator = moderator;
                    NavigationService.Navigate(new ListEvent());
                }
                else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }

        // Обработчик событий для кнопки регестрации Модератора и Администратора
        private void BRegestrationModerator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegestrationModerator(new Moderators()));

        }

        // Обработчик событий для кнопки входа Организатора
        private void BLoginPlanning_Click(object sender, RoutedEventArgs e)
        {
            if (ValidationLine())
            {
               EventPlanner eventPlanner = App.Db.EventPlanner.FirstOrDefault(ex => ex.Email == Login && ex.Password == Password);
                if (eventPlanner != null)
                {
                    App.contextEventPlanner = eventPlanner;
                    NavigationService.Navigate(new ListEvent());
                }
                else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }
        // Обработчик событий для кнопки регестрации Организатора
        private void BRegestrationPlanning_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegestrationPage(new EventPlanner()));

        }
    }
}
