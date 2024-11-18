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
    /// Логика взаимодействия для WaitingEventList.xaml
    /// </summary>
    public partial class WaitingEventList : Page
    {
        public WaitingEventList()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVEvents.ItemsSource = App.Db.Event.OrderByDescending(ev => ev.StatusId == 3).ToList();
            LVReviews.ItemsSource = App.Db.Reviews.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BApprove_Click(object sender, RoutedEventArgs e)
        {
            if (LVEvents.SelectedItem is Event _event && _event.StatusId != 4)
            {
                _event.StatusId = 1;
                App.Db.SaveChanges();
                Refresh();
            }
        }

        private void BNotApprove_Click(object sender, RoutedEventArgs e)
        {
            if (LVEvents.SelectedItem is Event _event && _event.StatusId != 4)
            {
                _event.StatusId = 2;
                new AddCommentEvent(_event).ShowDialog();
                Refresh();

            }
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = TBSearchEvent.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.Name.Contains(text)).ToList();
            }
        }

        private void TBSearchReviews_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = TBSearchReviews.Text;
            if (string.IsNullOrEmpty(text))
            {
                Refresh();
            }
            else
            {
                LVReviews.ItemsSource = App.Db.Reviews.Where(r => r.ContentMsg.Contains(text)).ToList();
            }
        }

        private void BDeleteReviews_Click(object sender, RoutedEventArgs e)
        {
            if (LVReviews.SelectedItem is Reviews review)
            {
                App.Db.Reviews.Remove(review);
                App.Db.SaveChanges();
                Refresh();
            }
        }


        private void LVEvents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LVEvents.SelectedItem is Event _event)
            {

                if (App.contextModerator.RoleId == 2)
                {

                    var window = new EventWindow(_event);
                    window.BResponse.Visibility = Visibility.Collapsed;
                    window.ShowDialog();
                }
                else if (App.contextModerator.RoleId == 1)
                {
                    NavigationService.Navigate(new AddEventPage(_event));
                }
            }
        }
    }
}
