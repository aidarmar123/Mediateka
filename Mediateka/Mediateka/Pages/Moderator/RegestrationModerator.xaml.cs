using Mediateka.Models;
using Mediateka.Services;
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
    /// Логика взаимодействия для RegestrationModerator.xaml
    /// </summary>
    public partial class RegestrationModerator : Page
    {
        Moderators contextModerator;
        public RegestrationModerator(Models.Moderators moderators)
        {
            InitializeComponent();
            CbRole.ItemsSource = App.Db.Role.ToList();
            contextModerator = moderators;
            DataContext = contextModerator;
        }

        private void Regestr_Click(object sender, RoutedEventArgs e)
        {
            var error = ValidationLine.ValidationObject(contextModerator);
            if (error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                if (!IsReapetUser(contextModerator.Login))
                {
                    if (contextModerator.Id == 0)
                        App.Db.Moderators.Add(contextModerator);
                    App.Db.SaveChanges();
                    NavigationService.GoBack();
                }
               
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private bool IsReapetUser(string email)
        {
            var moderator = App.Db.Moderators.FirstOrDefault(x => x.Login == email);
            var executor = App.Db.Executor.FirstOrDefault(x => x.Email == email);
            var eventPlanner = App.Db.EventPlanner.FirstOrDefault(x => x.Email == email);

            bool isReapet = moderator != null || executor != null || eventPlanner != null;
            if (isReapet)
                Xceed.Wpf.Toolkit.MessageBox.Show("Пользователь уже существует");

            return isReapet;
        }

    }
}
