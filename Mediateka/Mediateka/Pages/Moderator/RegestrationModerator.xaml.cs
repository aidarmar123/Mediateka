using Mediateka.Models;
using Mediateka.Service;
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
                if (contextModerator.Id == 0)
                    App.Db.Moderators.Add(contextModerator);
                App.Db.SaveChanges();
                NavigationService.GoBack();
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
