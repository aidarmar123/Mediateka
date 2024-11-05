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
    /// Логика взаимодействия для ListOrdersExecutors.xaml
    /// </summary>
    public partial class ListOrdersExecutors : Page
    {
        public ListOrdersExecutors()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.StatusId == 1).ToList();
            
        }

        private void BResponse_Click(object sender, RoutedEventArgs e)
        {
            var contextEvent = (sender as Button).DataContext as Event;
            if (contextEvent != null)
            {
                var eventExecutor = new EventExecutor()
                {
                    ExecutorId = App.contextExecutor.Id,
                    EventId = contextEvent.Id,
                    StatusExecutorId = 2
                };
                App.Db.EventExecutor.Add(eventExecutor);
                App.Db.SaveChanges();
            }
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
                LVEvents.ItemsSource = App.Db.Event.Where(ev => ev.StatusId ==1 && ev.Name.Contains(text)).ToList();
            }
        }

        

        private void LVEvents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LVEvents.SelectedItem is Event _event)
            {
                new EventWindow(_event).ShowDialog();
            }
        }
    }
}
