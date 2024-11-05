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
    /// Логика взаимодействия для AddEventPage.xaml
    /// </summary>
    public partial class AddEventPage : Page
    {
        Event contextEvent;
        public AddEventPage(Event _event)
        {
            InitializeComponent();
            CCBSkills.ItemsSource = App.Db.Skill.ToList();
            contextEvent = _event;
            DataContext = contextEvent;
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            var error = ValidationLine.ValidationObject(contextEvent);
            if(error.Length > 0)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(error.ToString(), "Поля не заполнены", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if(contextEvent.Id == 0)
                {
                    contextEvent.StatusId = 3; // Statusid = 3 => на модерации
                    App.Db.Event.Add(contextEvent);
                }
                App.Db.SaveChanges();
                foreach(Skill skill in CCBSkills.SelectedItems)
                {
                    App.Db.EventSkill.Add(new EventSkill() { SkillId = skill.Id ,EventIdint = contextEvent.Id});
                    App.Db.SaveChanges();
                }

                NavigationService.GoBack();
            }
        }
    }
}
