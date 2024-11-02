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
    /// Логика взаимодействия для ListEventPlanner.xaml
    /// </summary>
    public partial class ListEventPlanner : Page
    {
        public ListEventPlanner()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVEvents.ItemsSource = App.Db.Event.Where(ev=>ev.EventPlannerId == App.contextEventPlanner.Id).ToList();
        }

        private void BAddEvent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEventPage(new Models.Event() { EventPlannerId=App.contextEventPlanner.Id}));
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = TBSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.EventPlannerId == App.contextEventPlanner.Id && ev.Name.Contains(text)).ToList();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
